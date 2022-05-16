namespace Bai02
{
    partial class Bai02_POST
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
            this.rtbURL = new System.Windows.Forms.RichTextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.rtbResponse = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbURL
            // 
            this.rtbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbURL.Location = new System.Drawing.Point(46, 34);
            this.rtbURL.Name = "rtbURL";
            this.rtbURL.Size = new System.Drawing.Size(493, 31);
            this.rtbURL.TabIndex = 0;
            this.rtbURL.Text = "http://www.contoso.com/PostAccepter.aspx";
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(46, 85);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(493, 31);
            this.rtbData.TabIndex = 1;
            this.rtbData.Text = "";
            // 
            // rtbResponse
            // 
            this.rtbResponse.Location = new System.Drawing.Point(46, 152);
            this.rtbResponse.Name = "rtbResponse";
            this.rtbResponse.Size = new System.Drawing.Size(706, 253);
            this.rtbResponse.TabIndex = 2;
            this.rtbResponse.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(601, 34);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(102, 31);
            this.btnPost.TabIndex = 3;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Bai02_POST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.rtbResponse);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.rtbURL);
            this.Name = "Bai02_POST";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbURL;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.RichTextBox rtbResponse;
        private System.Windows.Forms.Button btnPost;
    }
}

