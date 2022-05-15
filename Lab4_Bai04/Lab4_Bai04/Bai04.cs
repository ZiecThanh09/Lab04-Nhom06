using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4_Bai04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();         
            CheckForIllegalCrossThreadCalls = true;

        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(tbURL.Text);
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            webBrowser.ShowSaveAsDialog();
        }

        private void btn_Source_Click(object sender, EventArgs e)
        {
            ViewSource viewSource = new ViewSource(webBrowser.DocumentText);
            viewSource.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
    }
}
