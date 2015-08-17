namespace MergeFiles
{
    partial class Main
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSource = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(299, 65);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(163, 23);
            this.buttonSource.TabIndex = 0;
            this.buttonSource.Text = "Selecionar pasta";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSouce_Click);
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(12, 39);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(450, 20);
            this.sourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pasta dos arquivos";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(299, 163);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(163, 23);
            this.buttonConvert.TabIndex = 4;
            this.buttonConvert.Text = "Converter";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daniel Prado\r\ndanieloprado@outlook.com";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.buttonSource);
            this.Name = "Main";
            this.Text = "Compilador de HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label2;
    }
}

