
namespace SearchFiles
{
    partial class FormNewFolder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnAddToPath = new System.Windows.Forms.Button();
            this.cmbDestinationPath = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Укажите новое расположение файла";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = " Полный путь к папке:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExecute.Enabled = false;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExecute.Location = new System.Drawing.Point(324, 209);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(147, 53);
            this.btnExecute.TabIndex = 18;
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnAddToPath
            // 
            this.btnAddToPath.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddToPath.BackgroundImage = global::SearchFiles.Properties.Resources.Folder_48x48;
            this.btnAddToPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToPath.Location = new System.Drawing.Point(692, 122);
            this.btnAddToPath.Name = "btnAddToPath";
            this.btnAddToPath.Size = new System.Drawing.Size(63, 58);
            this.btnAddToPath.TabIndex = 19;
            this.btnAddToPath.Text = " ";
            this.btnAddToPath.UseVisualStyleBackColor = false;
            this.btnAddToPath.Click += new System.EventHandler(this.btnAddToPath_Click);
            // 
            // cmbDestinationPath
            // 
            this.cmbDestinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDestinationPath.FormattingEnabled = true;
            this.cmbDestinationPath.Location = new System.Drawing.Point(41, 145);
            this.cmbDestinationPath.Name = "cmbDestinationPath";
            this.cmbDestinationPath.Size = new System.Drawing.Size(633, 33);
            this.cmbDestinationPath.TabIndex = 20;
            this.cmbDestinationPath.SelectedIndexChanged += new System.EventHandler(this.cmbDestinationPath_SelectedIndexChanged);
            this.cmbDestinationPath.TextChanged += new System.EventHandler(this.cmbDestinationPath_TextChanged);
            // 
            // FormNewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.Controls.Add(this.cmbDestinationPath);
            this.Controls.Add(this.btnAddToPath);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormNewFolder";
            this.Text = "Новое разположение файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnAddToPath;
        private System.Windows.Forms.ComboBox cmbDestinationPath;
    }
}