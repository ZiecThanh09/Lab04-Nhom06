namespace Lab4_Bai04
{
    partial class Bai04
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Download = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.btn_Source = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.976744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.02325F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(811, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Download, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Go, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Source, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbURL, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Back, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Refresh, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_Download
            // 
            this.btn_Download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Download.Location = new System.Drawing.Point(645, 2);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(76, 23);
            this.btn_Download.TabIndex = 2;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Go
            // 
            this.btn_Go.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Go.Location = new System.Drawing.Point(485, 2);
            this.btn_Go.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(76, 23);
            this.btn_Go.TabIndex = 1;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // btn_Source
            // 
            this.btn_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Source.Location = new System.Drawing.Point(725, 2);
            this.btn_Source.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(80, 23);
            this.btn_Source.TabIndex = 3;
            this.btn_Source.Text = "Source";
            this.btn_Source.UseVisualStyleBackColor = true;
            this.btn_Source.Click += new System.EventHandler(this.btn_Source_Click);
            // 
            // tbURL
            // 
            this.tbURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbURL.Location = new System.Drawing.Point(82, 2);
            this.tbURL.Margin = new System.Windows.Forms.Padding(2);
            this.tbURL.Multiline = true;
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(399, 23);
            this.tbURL.TabIndex = 0;
            this.tbURL.Text = "https://google.com\r\n";
            // 
            // btn_Back
            // 
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Back.Location = new System.Drawing.Point(2, 2);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(76, 23);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(2, 33);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(807, 419);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Refresh.Location = new System.Drawing.Point(565, 2);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 23);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refresh;
    }
}

