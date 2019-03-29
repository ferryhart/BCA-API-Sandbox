using System;
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
    public partial class frmTransferDomestic : Form
    {
        public frmTransferDomestic()
        {
            InitializeComponent();
            InitializeCBBeneficiaryCustType();
            InitializeCBBeneficiaryCustResidence();
            dtpTransactionDate.MaxDate = new DateTime(2018, 05, 03);
            nudAmount.Maximum = decimal.MaxValue;

            tbURI.Text = "/banking/corporates/transfers/domestic";
            tbChanneID.Text = "95051";
            tbCredentialID.Text = "BCAAPI";
            cbContentType.SelectedIndex = 0;
            tbSourceAccount.Text = "0201245680";
            tbTransactionID.Text = "00000001";
            tbReferenceID.Text = "12345/PO/2016";
            tbCurrencyCode.Text = "IDR";
            nudAmount.Value = 100000;
            cbTransferType.SelectedIndex = 0;
            tbBeneficiaryAccount.Text = "0201245501";
            tbBeneficiaryBank.Text = "BRONINJA";
            tbBeneficiaryName.Text = "Tester";
            cbBeneficiaryCustType.SelectedIndex = 0;
            cbBeneficiaryCustResidence.SelectedIndex = 0;
            rtbRemark1.Text = "Transfer Test";
            rtbRemark2.Text = "Online Transfer";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var postData = "{" +
                    "\"SourceAccountNumber\":\"" + tbSourceAccount.Text + "\"," +
                    "\"TransactionID\":\"" + tbTransactionID.Text + "\"," +
                    "\"TransactionDate\":\"" + dtpTransactionDate.Value.ToString("yyyy-MM-dd") + "\"," +
                    "\"ReferenceID\":\"" + tbReferenceID.Text + "\"," +
                    "\"CurrencyCode\":\"" + tbCurrencyCode.Text + "\"," +
                    "\"Amount\":\"" + nudAmount.Text + "\"," +
                    "\"TransferType\":\"" + cbTransferType.Text + "\"," +
                    "\"BeneficiaryAccountNumber\":\"" + tbBeneficiaryAccount.Text + "\"," +
                    "\"BeneficiaryBankCode\":\"" + tbBeneficiaryBank.Text + "\"," +
                    "\"BeneficiaryName\":\"" + tbBeneficiaryName.Text + "\"," +
                    "\"BeneficiaryCustType\":\"" + cbBeneficiaryCustType.SelectedValue + "\"," +
                    "\"BeneficiaryCustResidence\":\"" + cbBeneficiaryCustResidence.SelectedValue + "\"," +
                    "\"Remark1\":\"" + rtbRemark1.Text + "\"," +
                    "\"Remark2\":\"" + rtbRemark2.Text + "\"" +
                "}";
                string timestamp;
                string responseSignature = Main.CreateSignature(tbURI.Text, tbAccessToken.Text, "POST", out timestamp, cbContentType.Text, postData);
                string[] lines = responseSignature.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                string result = lines.SingleOrDefault(l => l.StartsWith("CalculatedHMAC"));
                string[] HMAC = result.Split(':');
                tbSignature.Text = HMAC[1].Replace(" ", "");

                var request = (HttpWebRequest)WebRequest.Create(Main.HOST + tbURI.Text);

                var data = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.Headers.Add("Authorization", "Bearer " + tbAccessToken.Text);
                request.Headers.Add("X-BCA-Key", Main.API_KEY);
                request.Headers.Add("X-BCA-Signature", tbSignature.Text);
                request.Headers.Add("X-BCA-Timestamp", timestamp);
                request.Headers.Add("ChannelID", tbChanneID.Text);
                request.Headers.Add("CredentialID", tbCredentialID.Text);
                request.ContentType = cbContentType.Text;
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

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

        private void InitializeCBBeneficiaryCustType()
        {
            cbBeneficiaryCustType.DisplayMember = "Text";
            cbBeneficiaryCustType.ValueMember = "Value";
            var items = new[] {
                new { Text = "Personal", Value = "1" },
                new { Text = "Corporate", Value = "2" },
                new { Text = "Government", Value = "3" }
            };
            cbBeneficiaryCustType.DataSource = items;
        }

        private void InitializeCBBeneficiaryCustResidence()
        {
            cbBeneficiaryCustResidence.DisplayMember = "Text";
            cbBeneficiaryCustResidence.ValueMember = "Value";
            var items = new[] {
                new { Text = "Resident", Value = "1" },
                new { Text = "Non Resident", Value = "2" }
            };
            cbBeneficiaryCustResidence.DataSource = items;
        }
    }
}
