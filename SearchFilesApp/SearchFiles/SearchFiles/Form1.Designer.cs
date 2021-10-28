
namespace SearchFiles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPdf = new System.Windows.Forms.CheckBox();
            this.cbDocx = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbSearchPath = new System.Windows.Forms.ComboBox();
            this.cmbRequires = new System.Windows.Forms.ComboBox();
            this.btnSearchPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(45, 172);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSearch.Size = new System.Drawing.Size(905, 248);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(599, 460);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(351, 39);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Искать";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Где искать (полный путь к папке)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите поисковый запрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(47, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите тип файлов:";
            // 
            // cbPdf
            // 
            this.cbPdf.AutoSize = true;
            this.cbPdf.Checked = true;
            this.cbPdf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPdf.Location = new System.Drawing.Point(336, 464);
            this.cbPdf.Name = "cbPdf";
            this.cbPdf.Size = new System.Drawing.Size(73, 29);
            this.cbPdf.TabIndex = 7;
            this.cbPdf.Text = "PDF";
            this.cbPdf.UseVisualStyleBackColor = true;
            this.cbPdf.CheckedChanged += new System.EventHandler(this.cbPdf_CheckedChanged);
            // 
            // cbDocx
            // 
            this.cbDocx.AutoSize = true;
            this.cbDocx.Checked = true;
            this.cbDocx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDocx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDocx.Location = new System.Drawing.Point(445, 463);
            this.cbDocx.Name = "cbDocx";
            this.cbDocx.Size = new System.Drawing.Size(79, 29);
            this.cbDocx.TabIndex = 8;
            this.cbDocx.Text = "Docx";
            this.cbDocx.UseVisualStyleBackColor = true;
            this.cbDocx.CheckedChanged += new System.EventHandler(this.cbDocx_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.AliceBlue;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(378, 541);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(255, 33);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус выполнения";
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // cmbSearchPath
            // 
            this.cmbSearchPath.BackColor = System.Drawing.Color.White;
            this.cmbSearchPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbSearchPath.FormattingEnabled = true;
            this.cmbSearchPath.Location = new System.Drawing.Point(45, 73);
            this.cmbSearchPath.Name = "cmbSearchPath";
            this.cmbSearchPath.Size = new System.Drawing.Size(817, 33);
            this.cmbSearchPath.TabIndex = 1;
            this.cmbSearchPath.SelectedIndexChanged += new System.EventHandler(this.cmbSearchPath_SelectedIndexChanged);
            this.cmbSearchPath.TextChanged += new System.EventHandler(this.cmbSearchPath_TextChanged);
            // 
            // cmbRequires
            // 
            this.cmbRequires.BackColor = System.Drawing.Color.White;
            this.cmbRequires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRequires.FormattingEnabled = true;
            this.cmbRequires.Location = new System.Drawing.Point(370, 140);
            this.cmbRequires.Name = "cmbRequires";
            this.cmbRequires.Size = new System.Drawing.Size(580, 28);
            this.cmbRequires.TabIndex = 4;
            this.cmbRequires.Text = "   Недавние запросы";
            this.cmbRequires.SelectedIndexChanged += new System.EventHandler(this.cmbRequires_SelectedIndexChanged);
            // 
            // btnSearchPath
            // 
            this.btnSearchPath.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSearchPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPath.BackgroundImage")));
            this.btnSearchPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchPath.Location = new System.Drawing.Point(891, 58);
            this.btnSearchPath.Name = "btnSearchPath";
            this.btnSearchPath.Size = new System.Drawing.Size(58, 50);
            this.btnSearchPath.TabIndex = 2;
            this.btnSearchPath.Text = " ";
            this.btnSearchPath.UseVisualStyleBackColor = false;
            this.btnSearchPath.Click += new System.EventHandler(this.btnSearchPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(996, 602);
            this.Controls.Add(this.cmbRequires);
            this.Controls.Add(this.cmbSearchPath);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbDocx);
            this.Controls.Add(this.cbPdf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearchPath);
            this.Name = "Form1";
            this.Text = "Search files app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchPath;
        private System.Windows.Forms.Button btnSearchPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRequires;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbPdf;
        private System.Windows.Forms.CheckBox cbDocx;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
    }
}

