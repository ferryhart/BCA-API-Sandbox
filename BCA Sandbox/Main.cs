using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.IO;

namespace BCA_Sandbox
{
    public partial class Main : Form
    {
        public static string API_KEY, API_KEY_SECRET, CLIENT_ID, CLIENT_ID_SECRET, HOST;
        
        public Main()
        {
            InitializeComponent();
            API_KEY = ConfigurationManager.AppSettings["API_KEY"];
            API_KEY_SECRET = ConfigurationManager.AppSettings["API_KEY_SECRET"];
            CLIENT_ID = ConfigurationManager.AppSettings["CLIENT_ID"];
            CLIENT_ID_SECRET = ConfigurationManager.AppSettings["CLIENT_ID_SECRET"];
            HOST = ConfigurationManager.AppSettings["HOST"];
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            requestTokenToolStripMenuItem.PerformClick();
        }

        private void requestTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmRequestToken")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmRequestToken frm = new frmRequestToken();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void balanceInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmBalanceInformation")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmBalanceInformation frm = new frmBalanceInformation();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void accountStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmAccountStatement")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmAccountStatement frm = new frmAccountStatement();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmTransfer")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmTransfer frm = new frmTransfer();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void transferDomesticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmTransferDomestic")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmTransferDomestic frm = new frmTransferDomestic();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void foreignExchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmForeignExchangeRate")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmForeignExchangeRate frm = new frmForeignExchangeRate();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        private void nearestBranchLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmNearestBranchLocation")
                {
                    f.Focus();
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                frmNearestBranchLocation frm = new frmNearestBranchLocation();
                frm.MdiParent = this;
                frm.Size = frm.MdiParent.ClientSize;
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        public static string CreateSignature(string URI, string accessToken, string method, out string timestamp, string contentType = "", string requestPayload = "")
        {
            var request = (HttpWebRequest)WebRequest.Create(HOST + "/utilities/signature");

            var postData = requestPayload;
            var data = Encoding.ASCII.GetBytes(postData);

            timestamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffK");
            request.Method = "POST";
            request.Headers.Add("Timestamp", timestamp);
            request.Headers.Add("URI", URI);
            request.Headers.Add("AccessToken", accessToken);
            request.Headers.Add("APISecret", API_KEY_SECRET);
            request.Headers.Add("HTTPMethod", method);
            request.ContentType = contentType;
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
    }
}
