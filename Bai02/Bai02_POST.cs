using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Bai02_POST : Form
    {
        public Bai02_POST()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            rtbResponse.Text = getHTTP(rtbURL.Text, "rtbData = " + rtbData.Text);
        }
        public string getHTTP(string szURL, string szPost)
        {
            WebRequest request;
            WebResponse response;
            StreamReader bodyreader;
            string bodytext = "";
            Stream responsestream;
            Stream requestStream;
            request = (HttpWebRequest)WebRequest.Create("http://www.contoso.com/PostAccepter.aspx");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = szPost.Length;
            requestStream = request.GetRequestStream();
            requestStream.Write(Encoding.ASCII.GetBytes(szPost), 0,szPost.Length);
            requestStream.Close();
            response = (HttpWebResponse)
            request.GetResponse();
            responsestream = response.GetResponseStream();
            bodyreader = new StreamReader(responsestream);
            bodytext = bodyreader.ReadToEnd();
            return bodytext;
        }
    }
}
