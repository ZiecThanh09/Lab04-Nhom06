using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
namespace Lab04_thuy
{
    public partial class Lab04_Bai03 : Form
    {
        public Lab04_Bai03()
        {
            InitializeComponent();
        }

        public void Get_Content(WebClient myClient)
        {
            
            try
            {
                byte[] response = myClient.DownloadData(tbURL.Text);
                rtbContent.Text = Encoding.ASCII.GetString(response);
            }
            catch (WebException wex)
            {
                rtbContent.Text = wex.Message;
            }
        }
        private string OpenReader(string argv, WebClient myClient)
        {
            string response = "";
            Stream strm = myClient.OpenRead(argv);
            StreamReader sr = new StreamReader(strm);
            while (sr.Peek() > -1)
            {
                response += sr.ReadLine();
            }
            sr.Close();
            return response;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tbURL.Text.Trim() == "")
            {
                MessageBox.Show("Please input URL",
                "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            WebClient myClient = new WebClient();
            if(tbDesFile.Text == "")
            {
                MessageBox.Show("Please input Save location and File name",
                "Warning", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            try
            {
                myClient.DownloadFile(tbURL.Text, tbDesFile.Text);
                OpenReader(tbDesFile.Text, myClient);
                MessageBox.Show("File downloaded", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException wex)
            {
                rtbContent.Text = wex.Message;
            }
            Get_Content(myClient);

        }
    } 
}
