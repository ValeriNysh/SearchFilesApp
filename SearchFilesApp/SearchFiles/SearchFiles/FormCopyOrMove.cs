using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFiles
{
    public partial class FormCopyOrMove : Form
    {
        Form1 parent;
        bool applyToAll = false;
        string addToPath;

        public FormCopyOrMove(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
        }
        FormNewFolder formNewFolder;

        private void FormCopyOrMove_Load(object sender, EventArgs e)
        {
            
            Text = "Какое действие следует выполнить?";
            lblFileName.Text = $"\"{parent.GetCurrentName()}\"";
            lblCurrentLocation.Text = parent.GetCurrentPath();
            lblFileName.Left = (Width - lblFileName.Width) / 2;
            lblCurrentLocation.Left = (Width - lblCurrentLocation.Width) / 2;
            
            if (lblCurrentLocation.Width > 560)
                this.Width = lblCurrentLocation.Width + 120;            

            label1.Left = 60;
            btnShowInFolder.Left = 60;
            btnCopy.Left = 60 + btnShowInFolder.Width + 6;
            btnMove.Left = Width - 60 - btnSkip.Width - 6 - btnMove.Width;
            btnSkip.Left = Width - 60 - btnMove.Width;

            cbApplyToAll.Left = 60;
        }


        private void btnShowInFolder_Click(object sender, EventArgs e)
        {
            parent.GetButtonClicked(applyToAll, "show");
            Close();
        }
        
        private void btnCopy_Click(object sender, EventArgs e)
        {
            formNewFolder = new FormNewFolder(this);
            formNewFolder.ShowDialog();

            parent.GetButtonClicked(applyToAll, "copy", addToPath);
            Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            formNewFolder = new FormNewFolder(this);
            formNewFolder.ShowDialog();

            parent.GetButtonClicked(applyToAll, "move", addToPath);
            Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            parent.GetButtonClicked(applyToAll, "skip");
            Close();
        }
        private void btnBreak_Click(object sender, EventArgs e)
        {
            parent.GetButtonClicked(applyToAll, "break");
            Close();
        }

        private void cbApplyToAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbApplyToAll.Checked == true)
                applyToAll = true;
            else
                applyToAll = false;
        }

        public void SetAddToPath(string path)
        {
            addToPath = path;
        }

    }
}
