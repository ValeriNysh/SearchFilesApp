using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFiles
{
    public partial class FormNewFolder : Form
    {
        FormCopyOrMove parent;
        public FormNewFolder(FormCopyOrMove parent)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            this.parent = parent;

            FillComboBox();            
        }


        private void btnAddToPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            dlg.ShowNewFolderButton = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                cmbDestinationPath.Text = dlg.SelectedPath;
            }
        }


        private void cmbDestinationPath_TextChanged(object sender, EventArgs e)
        {
            if (cmbDestinationPath.Text.Length != 0)
                btnExecute.Enabled = true;
            else
                btnExecute.Enabled = false;
        }

        private void cmbDestinationPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestinationPath.Text.Length != 0)
                btnExecute.Enabled = true;
            else
                btnExecute.Enabled = false;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(cmbDestinationPath.Text))
            {
                using (RequestModel db = new RequestModel())
                {
                    RequestPath p = new RequestPath { Path = cmbDestinationPath.Text };

                    bool exist = false;
                    foreach (var pth in db.RequestPath)
                    {
                        if (p.Path == pth.Path)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (exist == false)
                    {
                        db.RequestPath.Add(p);
                    }

                    db.SaveChanges();

                };

                cmbDestinationPath.Items.Clear();

                FillComboBox();

                string path = cmbDestinationPath.Text;
                parent.SetAddToPath(path);
                Close();
            }
            else
                MessageBox.Show("Путь к папке указан некорректно!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void FillComboBox()
        {
            using (RequestModel db = new RequestModel())
            {
                List<string> PathList = new List<string>();

                foreach (var pth in db.RequestPath)
                    PathList.Add(pth.Path);
                PathList.Reverse();
                cmbDestinationPath.Items.AddRange(PathList.ToArray());

            };
        }
    }
}
