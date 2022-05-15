namespace Lab4_Bai04
{
    partial class ViewSource
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
            this.tbSource = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbSource
            // 
            this.tbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSource.Location = new System.Drawing.Point(0, 0);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(816, 488);
            this.tbSource.TabIndex = 0;
            this.tbSource.Text = "";
            // 
            // ViewSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 488);
            this.Controls.Add(this.tbSource);
            this.Name = "ViewSource";
            this.Text = "ViewSource";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbSource;
    }
}