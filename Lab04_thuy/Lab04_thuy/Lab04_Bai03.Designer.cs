
namespace Lab04_thuy
{
    partial class Lab04_Bai03
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbDesFile = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(600, 15);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(122, 31);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(42, 17);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(495, 26);
            this.tbURL.TabIndex = 1;
            // 
            // tbDesFile
            // 
            this.tbDesFile.Location = new System.Drawing.Point(42, 49);
            this.tbDesFile.Name = "tbDesFile";
            this.tbDesFile.Size = new System.Drawing.Size(495, 26);
            this.tbDesFile.TabIndex = 2;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(12, 81);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(776, 357);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.tbDesFile);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbDesFile;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

