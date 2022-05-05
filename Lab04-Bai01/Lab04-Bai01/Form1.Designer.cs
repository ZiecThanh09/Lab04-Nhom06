
namespace Lab04_Bai01
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
            this.btGet = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.rtbHTML = new System.Windows.Forms.RichTextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(774, 24);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(87, 35);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "Get";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(38, 36);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(708, 22);
            this.tbURL.TabIndex = 1;
            // 
            // rtbHTML
            // 
            this.rtbHTML.Location = new System.Drawing.Point(38, 106);
            this.rtbHTML.Name = "rtbHTML";
            this.rtbHTML.ReadOnly = true;
            this.rtbHTML.Size = new System.Drawing.Size(708, 545);
            this.rtbHTML.TabIndex = 2;
            this.rtbHTML.Text = "";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(774, 77);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(87, 33);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(774, 135);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(87, 33);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(38, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhập vào địa chỉ URL của trang web:";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbNote.Location = new System.Drawing.Point(39, 85);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(0, 20);
            this.lbNote.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 685);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.rtbHTML);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.RichTextBox rtbHTML;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNote;
    }
}

