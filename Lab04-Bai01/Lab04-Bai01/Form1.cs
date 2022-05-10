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
using System.Threading;
using System.Net;

namespace Lab04_Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            lbNote.Text = "Xin chờ một vài giây để có thể xem nội dung HTML của trang web!";
            try
            {
                rtbHTML.Text = getHTTP(tbURL.Text);
            }
            // Xu ly cac exception
            catch (Exception)
            {
                // Neu nguoi dung de trong (khong nhap URL của trang web) thi se xuat ra thong bao loi la: "Vui long nhap vao URL cua trang web!"
                if (tbURL.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập vào URL của trang web!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbNote.Text = null;
                }
                // Neu nguoi dung nhap sai URL cua trang web, hoac URL khong ton tai thì sẽ xuất ra canh bao la: "Vui long nhap dung URL cua trang web!"
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng URL của trang web!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lbNote.Text = null;
                }
            }
        }

        private string getHTTP(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(tbURL.Text);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbURL.Text = null;
            rtbHTML.Text = null;
            lbNote.Text = null;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
