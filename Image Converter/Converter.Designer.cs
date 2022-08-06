namespace Image_Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.ConversionFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.CleanPBox = new System.Windows.Forms.Button();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.CleanTextBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(12, 87);
            this.PictureBox.MinimumSize = new System.Drawing.Size(400, 460);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(400, 460);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile.Location = new System.Drawing.Point(12, 12);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 70);
            this.OpenFile.TabIndex = 1;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ConversionFile
            // 
            this.ConversionFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConversionFile.Location = new System.Drawing.Point(114, 12);
            this.ConversionFile.Name = "ConversionFile";
            this.ConversionFile.Size = new System.Drawing.Size(96, 70);
            this.ConversionFile.TabIndex = 2;
            this.ConversionFile.Text = "Convert";
            this.ConversionFile.UseVisualStyleBackColor = true;
            this.ConversionFile.Click += new System.EventHandler(this.ConversionFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveFile.Location = new System.Drawing.Point(318, 11);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(96, 70);
            this.SaveFile.TabIndex = 3;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // CleanPBox
            // 
            this.CleanPBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CleanPBox.Location = new System.Drawing.Point(216, 12);
            this.CleanPBox.Name = "CleanPBox";
            this.CleanPBox.Size = new System.Drawing.Size(96, 70);
            this.CleanPBox.TabIndex = 4;
            this.CleanPBox.Text = "Clean";
            this.CleanPBox.UseVisualStyleBackColor = true;
            this.CleanPBox.Click += new System.EventHandler(this.CleanPBox_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorBox.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorBox.Location = new System.Drawing.Point(12, 555);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.ShortcutsEnabled = false;
            this.ErrorBox.Size = new System.Drawing.Size(359, 38);
            this.ErrorBox.TabIndex = 5;
            this.ErrorBox.Text = "Select the file to convert";
            this.ErrorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CleanTextBox
            // 
            this.CleanTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CleanTextBox.Location = new System.Drawing.Point(377, 555);
            this.CleanTextBox.Name = "CleanTextBox";
            this.CleanTextBox.Size = new System.Drawing.Size(35, 38);
            this.CleanTextBox.TabIndex = 6;
            this.CleanTextBox.Text = "Del";
            this.CleanTextBox.UseVisualStyleBackColor = true;
            this.CleanTextBox.Click += new System.EventHandler(this.CleanTextBox_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(424, 601);
            this.Controls.Add(this.CleanTextBox);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.CleanPBox);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.ConversionFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.PictureBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 640);
            this.MinimumSize = new System.Drawing.Size(440, 600);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PictureBox;
        private Button OpenFile;
        private Button ConversionFile;
        private Button SaveFile;
        private Button CleanPBox;
        private TextBox ErrorBox;
        private Button CleanTextBox;
    }
}
