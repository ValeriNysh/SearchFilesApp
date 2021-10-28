
namespace SearchFiles
{
    partial class FormCopyOrMove
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentLocation = new System.Windows.Forms.Label();
            this.btnShowInFolder = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.cbApplyToAll = new System.Windows.Forms.CheckBox();
            this.btnBreak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFileName.Location = new System.Drawing.Point(336, 29);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(220, 29);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Название файла";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущее расположение файла:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentLocation
            // 
            this.lblCurrentLocation.AutoSize = true;
            this.lblCurrentLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCurrentLocation.Location = new System.Drawing.Point(343, 135);
            this.lblCurrentLocation.Name = "lblCurrentLocation";
            this.lblCurrentLocation.Size = new System.Drawing.Size(213, 25);
            this.lblCurrentLocation.TabIndex = 1;
            this.lblCurrentLocation.Text = "Полный путь к файлу";
            this.lblCurrentLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowInFolder
            // 
            this.btnShowInFolder.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowInFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowInFolder.Location = new System.Drawing.Point(59, 212);
            this.btnShowInFolder.Name = "btnShowInFolder";
            this.btnShowInFolder.Size = new System.Drawing.Size(217, 44);
            this.btnShowInFolder.TabIndex = 3;
            this.btnShowInFolder.Text = "Показать в папке";
            this.btnShowInFolder.UseVisualStyleBackColor = false;
            this.btnShowInFolder.Click += new System.EventHandler(this.btnShowInFolder_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(288, 212);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(166, 44);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Копировать";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMove.Location = new System.Drawing.Point(465, 212);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(166, 44);
            this.btnMove.TabIndex = 5;
            this.btnMove.Text = "Переместить";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSkip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSkip.Location = new System.Drawing.Point(643, 212);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(166, 44);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.Text = "Пропустить";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // cbApplyToAll
            // 
            this.cbApplyToAll.AutoSize = true;
            this.cbApplyToAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbApplyToAll.Location = new System.Drawing.Point(60, 313);
            this.cbApplyToAll.Name = "cbApplyToAll";
            this.cbApplyToAll.Size = new System.Drawing.Size(452, 24);
            this.cbApplyToAll.TabIndex = 7;
            this.cbApplyToAll.Text = "Применить выбранное действие ко всем файлам";
            this.cbApplyToAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbApplyToAll.UseVisualStyleBackColor = true;
            this.cbApplyToAll.CheckedChanged += new System.EventHandler(this.cbApplyToAll_CheckedChanged);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.LightCoral;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBreak.Location = new System.Drawing.Point(566, 300);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(244, 44);
            this.btnBreak.TabIndex = 8;
            this.btnBreak.Text = "Прервать поиск";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // FormCopyOrMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(873, 364);
            this.Controls.Add(this.lblCurrentLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnShowInFolder);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.cbApplyToAll);
            this.Controls.Add(this.btnBreak);
            this.Name = "FormCopyOrMove";
            this.Text = "Выберите действие для данного файла";
            this.Load += new System.EventHandler(this.FormCopyOrMove_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentLocation;
        protected System.Windows.Forms.Button btnShowInFolder;
        public System.Windows.Forms.Button btnCopy;
        protected System.Windows.Forms.Button btnMove;
        protected System.Windows.Forms.Button btnSkip;
        protected System.Windows.Forms.CheckBox cbApplyToAll;
        protected System.Windows.Forms.Button btnBreak;
    }
}