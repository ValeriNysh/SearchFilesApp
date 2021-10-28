using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using org.pdfclown.documents;
using System.Text.RegularExpressions;
using org.pdfclown.tools;
using org.pdfclown.documents.contents;
using DocumentFormat.OpenXml.Packaging;
using Aspose.Words;
using System.Diagnostics;
using System.Threading;

namespace SearchFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            lblStatus.Left = (Width - lblStatus.Width) / 2;
            lblStatus.Text = "";

            FillComboBoxes();
        }

        FormCopyOrMove formCopyMove;
        bool isAll = false, nothing = true;
        public string curName = "", curPath = "", action = "copy";
        public string addToPath = "";


        public object StructuredStorageReader { get; private set; }

        private void btnSearchPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                cmbSearchPath.Text = dlg.SelectedPath;
            }
            addToPath = cmbSearchPath.Text;
        }

        private void cmbSearchPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchPath.Text.Length == 0)
                btnSearch.Enabled = false;
            else if (cmbSearchPath.Text.Length != 0 && tbSearch.TextLength != 0 && (cbPdf.Checked == true || cbDocx.Checked == true))
                btnSearch.Enabled = true;
        }


        private void cmbRequires_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = cmbRequires.Text;
        }

        private void cmbSearchPath_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearchPath.Text.Length == 0)
                btnSearch.Enabled = false;
            else if (cmbSearchPath.Text.Length != 0 && tbSearch.TextLength != 0 && (cbPdf.Checked == true || cbDocx.Checked == true))
                btnSearch.Enabled = true;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.TextLength == 0)
                btnSearch.Enabled = false;
            else if (cmbSearchPath.Text.Length != 0 && tbSearch.TextLength != 0 && (cbPdf.Checked == true || cbDocx.Checked == true))
                btnSearch.Enabled = true;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            isAll = false; action = "copy";
            if (Directory.Exists(cmbSearchPath.Text))
            {
                using (RequestModel db = new RequestModel())
                {
                    RequestPath path = new RequestPath { Path = cmbSearchPath.Text };
                    RequestString request = new RequestString { String = tbSearch.Text };

                    bool exist = false;
                    foreach (var pth in db.RequestPath)
                    {
                        if (path.Path == pth.Path)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                        db.RequestPath.Add(path);

                    exist = false;
                    foreach (var str in db.RequestString)
                    {
                        if (request.String == str.String)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                        db.RequestString.Add(request);

                    db.SaveChanges();

                };

                cmbSearchPath.Items.Clear();
                cmbRequires.Items.Clear();

                FillComboBoxes();

                lblStatus.Text = "Поиск файлов...";
                lblStatus.Left = (Width - lblStatus.Width) / 2;
                lblStatus.ForeColor = Color.Orange;
                lblStatus.Padding = new Padding(20, 5, 20, 5);
                
                btnSearch.Enabled = false;

                isAll = false;
                nothing = true;

                Action<string, string> action = FindInFolder;
                action.BeginInvoke(cmbSearchPath.Text, tbSearch.Text, (x) =>
                {
                    if (nothing == true)
                    {
                        lblStatus.Text = "Совпадений не найдено";
                        lblStatus.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        lblStatus.Text = "Поиск файлов завершен!";
                        lblStatus.ForeColor = Color.Green;
                    }
                    btnSearch.BackColor = Color.LightGreen;
                    lblStatus.Left = (Width - lblStatus.Width) / 2;
                    lblStatus.BackColor = Color.Transparent;
                    btnSearch.Enabled = true;
                }, action);
            }
            else
                MessageBox.Show("Путь к папке указан некорректно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillComboBoxes()
        {
            using (RequestModel db = new RequestModel())
            {
                List<string> PathList = new List<string>();
                List<string> RequestList = new List<string>();

                foreach (var pth in db.RequestPath)
                    PathList.Add(pth.Path);
                PathList.Reverse();
                cmbSearchPath.Items.AddRange(PathList.ToArray());

                foreach (var req in db.RequestString)
                    RequestList.Add(req.String);
                RequestList.Reverse();
                cmbRequires.Items.AddRange(RequestList.ToArray());
            };

        }


        private void FindInFolder(string path, string find)
        {
            nothing = FindMatchesFiles(path, tbSearch.Text.ToLower());

            foreach (var f in Directory.GetDirectories(path))
            {
                if (action == "break")
                {
                    nothing = false;
                    break;
                }
                if (Path.GetExtension(f) == "")
                {
                    path = f;
                    FindInFolder(path, find);
                }
            }
        }



        private List<string> filesToDelete = new List<string>();
        
        // Проверяем файл на совпадение с ключевым словом.
        private bool FindMatchesFiles(string objectPath, string find)
        {
            foreach (var f in Directory.GetFiles(objectPath))
            {
                if (action == "break")
                {
                    nothing = false;
                    break;
                }
                Regex pattern = new Regex(find.ToLower(), RegexOptions.IgnoreCase);
                MatchCollection matches;
                TextExtractor textExtractor = new TextExtractor(true, true);
                string fileName = f.Substring(objectPath.Length + 1);

                if (Path.GetExtension(f) == ".pdf" && cbPdf.Checked == true)
                {
                    using (org.pdfclown.files.File file = new org.pdfclown.files.File(f))
                    {
                        org.pdfclown.documents.Document document = file.Document;
                        foreach (Page page in document.Pages)
                        {
                            // Extract the page text
                            IDictionary<RectangleF?, IList<ITextString>> textStrings = textExtractor.Extract(page);

                            // Find the text pattern matches
                            matches = pattern.Matches(TextExtractor.ToString(textStrings));

                            if (matches.Count > 0)
                            {
                                nothing = false;
                                FileMatched(fileName, objectPath);
                                break;
                            }
                        }
                    }
                }
                else if ((/*Path.GetExtension(f) == ".doc" || */Path.GetExtension(f) == ".docx") && cbDocx.Checked == true)
                {
                    WordprocessingDocument wordDoc;
                    //StreamReader sr;
                    Aspose.Words.Document document = null;
                    if (Path.GetExtension(f) == ".doc")
                    {
                        string newName = f.Remove(f.Length - 4);
                        //StructuredStorageReader reader = new StructuredStorageReader(f);
                        LoadOptions options = new LoadOptions();
                        options.LoadFormat = LoadFormat.Doc;
                        document = new Aspose.Words.Document(f, options);
                        document.Save(newName + ".docx", SaveFormat.Docx);
                        string str = document.OriginalFileName;
                        wordDoc = WordprocessingDocument.Open(str, false);
                    }
                    else
                        wordDoc = WordprocessingDocument.Open(f, false);

                    var text = wordDoc.MainDocumentPart.Document.InnerText;
                    if (text.Contains(find.ToLower()))
                    {
                        nothing = false;
                        wordDoc.Close();

                        FileMatched(fileName, objectPath);
                        break;
                    }
                    else
                        wordDoc.Close();

                    //Action<string, string> action = FileMatched;
                    //action.BeginInvoke(fileName, objectPath, x =>
                    //{
                    //    Action<string, string> act = (Action<string, string>)x.AsyncState;
                    //    act.EndInvoke(x);
                    //}, action);
                    //break;
                    if (Path.GetExtension(f) == ".doc")
                        document.Remove();
                }

            }
            
            foreach(var fToDel in filesToDelete)
            {
                File.Delete(fToDel);
            }
            filesToDelete.Clear();

            return nothing;
        }


        public void FileMatched(string fileName, string objectPath)
        {

            //Проверяем стоит ли отметка "Запомнить мой выбор" при выборе действия (открыть в папке / копировать / переместить / пропустить).
            if (isAll == false)
            {
                curName = fileName;
                curPath = objectPath;
                formCopyMove = new FormCopyOrMove(this);
                formCopyMove.ShowDialog();
            }


            if (action == "show")
            {
                Process.Start("explorer.exe", $"/select, \"{Path.Combine(objectPath, fileName)}\"");
            }
            else if (action == "skip")
            { }
            else
            {
                bool alreadyExist = false;
                foreach (var fl in Directory.GetFiles(addToPath))
                {
                    //Проверяем есть ли уже такой файл в папке назначения.
                    if (fl.Substring(addToPath.Length + 1) == fileName)
                    {
                        alreadyExist = true;
                        break;
                    }
                }
                
                if (alreadyExist == false)
                {
                    if (action == "copy")
                    {
                        File.Copy(Path.Combine(objectPath, fileName), Path.Combine(addToPath, fileName));
                    }
                    else if (action == "move")
                    {
                        File.Copy(Path.Combine(objectPath, fileName), Path.Combine(addToPath, fileName));
                        filesToDelete.Add(Path.Combine(objectPath, fileName));
                    }
                    else
                        nothing = true;
                }
                else if (isAll == false)
                    MessageBox.Show($"Файл \"{fileName}\" уже есть в папке назначения!");

            }
            
        }


        public void GetButtonClicked(bool all, string btn)
        {
            isAll = all;
            action = btn;
        }

        public void GetButtonClicked(bool all, string btn, string path)
        {
            isAll = all;
            action = btn;
            addToPath = path;
        }

        private void cbPdf_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPdf.Checked == true || cbDocx.Checked == true)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void cbDocx_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPdf.Checked == true || cbDocx.Checked == true)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Left = (Width - lblStatus.Width) / 2;
        }

        public string GetCurrentName()
        {
            return curName;
        }

        public string GetCurrentPath()
        {
            return curPath;
        }

        

    }
}

