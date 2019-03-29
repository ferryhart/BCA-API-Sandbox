﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BCA_Sandbox
{
    public partial class frmAccountStatement : Form
    {
        public frmAccountStatement()
        {
            InitializeComponent();
            tbCorporateID.Text = "BCAAPI2016";
            tbAccountNumber.Text = "0201245680";
            dtpStartDate.MinDate = new DateTime(2016, 08, 29);
            dtpStartDate.MaxDate = new DateTime(2016, 09, 01);
            dtpStartDate.Value = new DateTime(2016, 08, 29);
            dtpEndDate.MinDate = new DateTime(2016, 08, 29);
            dtpEndDate.MaxDate = new DateTime(2016, 09, 01);
            dtpEndDate.Value = new DateTime(2016, 08, 29);
            refreshURI();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
            refreshURI();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value;
            }
            dtpEndDate.MinDate = dtpStartDate.Value;
            refreshURI();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string timestamp;
                string responseSignature = Main.CreateSignature(tbURI.Text, tbAccessToken.Text, "GET", out timestamp);
                string[] lines = responseSignature.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string result = lines.SingleOrDefault(l => l.StartsWith("CalculatedHMAC"));
                string[] HMAC = result.Split(':');
                tbSignature.Text = HMAC[1].Replace(" ", "");

                var request = (HttpWebRequest)WebRequest.Create(Main.HOST + tbURI.Text);

                request.Method = "GET";
                request.Headers.Add("Authorization", "Bearer " + tbAccessToken.Text);
                request.Headers.Add("X-BCA-Key", Main.API_KEY);
                request.Headers.Add("X-BCA-Signature", tbSignature.Text);
                request.Headers.Add("X-BCA-Timestamp", timestamp);

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic jsonParsed = JsonConvert.DeserializeObject(responseString);
                rtbResult.Text = JsonConvert.SerializeObject(jsonParsed, Formatting.Indented);
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    using (var errorResponse = (HttpWebResponse)wex.Response)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            string error = reader.ReadToEnd();
                            JObject jObject = JObject.Parse(error);
                            string message = (string)jObject.SelectToken("ErrorMessage.Indonesian");
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void tbCorporateID_TextChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void tbAccountNumber_TextChanged(object sender, EventArgs e)
        {
            refreshURI();
        }

        private void refreshURI()
        {
            tbURI.Text = "/banking/v3/corporates/" + tbCorporateID.Text + "/accounts/" + tbAccountNumber.Text + "/statements?StartDate=" + dtpStartDate.Value.ToString("yyyy-MM-dd") + "&EndDate=" + dtpEndDate.Value.ToString("yyyy-MM-dd");
        }
    }
}
