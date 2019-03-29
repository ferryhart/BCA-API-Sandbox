namespace BCA_Sandbox
{
    partial class frmTransfer
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
            this.lblSignature = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblFundTransfer = new System.Windows.Forms.Label();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblCorporateID = new System.Windows.Forms.Label();
            this.cbContentType = new System.Windows.Forms.ComboBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.lblSourceAccount = new System.Windows.Forms.Label();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.lblTransactionDate = new System.Windows.Forms.Label();
            this.lblReferenceID = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBeneficiaryAccount = new System.Windows.Forms.Label();
            this.lblRemark1 = new System.Windows.Forms.Label();
            this.lblRemark2 = new System.Windows.Forms.Label();
            this.tbCorporateID = new System.Windows.Forms.TextBox();
            this.tbSourceAccount = new System.Windows.Forms.TextBox();
            this.tbTransactionID = new System.Windows.Forms.TextBox();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.tbReferenceID = new System.Windows.Forms.TextBox();
            this.tbCurrencyCode = new System.Windows.Forms.TextBox();
            this.tbBeneficiaryAccount = new System.Windows.Forms.TextBox();
            this.rtbRemark1 = new System.Windows.Forms.RichTextBox();
            this.rtbRemark2 = new System.Windows.Forms.RichTextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSignature
            // 
            this.lblSignature.Location = new System.Drawing.Point(29, 123);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(96, 13);
            this.lblSignature.TabIndex = 43;
            this.lblSignature.Text = "X-BCA-Signature : ";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(131, 120);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.ReadOnly = true;
            this.tbSignature.Size = new System.Drawing.Size(256, 20);
            this.tbSignature.TabIndex = 30;
            this.tbSignature.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(393, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(96, 13);
            this.lblResult.TabIndex = 42;
            this.lblResult.Text = "Result : ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(495, 94);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(502, 318);
            this.rtbResult.TabIndex = 31;
            this.rtbResult.TabStop = false;
            this.rtbResult.Text = "";
            // 
            // lblURI
            // 
            this.lblURI.Location = new System.Drawing.Point(29, 149);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(96, 13);
            this.lblURI.TabIndex = 39;
            this.lblURI.Text = "URI : ";
            this.lblURI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.Location = new System.Drawing.Point(29, 97);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(96, 13);
            this.lblAccessToken.TabIndex = 38;
            this.lblAccessToken.Text = "Access Token : ";
            this.lblAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFundTransfer
            // 
            this.lblFundTransfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFundTransfer.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundTransfer.Location = new System.Drawing.Point(0, 0);
            this.lblFundTransfer.Name = "lblFundTransfer";
            this.lblFundTransfer.Size = new System.Drawing.Size(1366, 64);
            this.lblFundTransfer.TabIndex = 37;
            this.lblFundTransfer.Text = "  Fund Transfer";
            this.lblFundTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(131, 146);
            this.tbURI.Name = "tbURI";
            this.tbURI.ReadOnly = true;
            this.tbURI.Size = new System.Drawing.Size(256, 20);
            this.tbURI.TabIndex = 32;
            this.tbURI.TabStop = false;
            // 
            // tbAccessToken
            // 
            this.tbAccessToken.Location = new System.Drawing.Point(131, 94);
            this.tbAccessToken.Name = "tbAccessToken";
            this.tbAccessToken.Size = new System.Drawing.Size(256, 20);
            this.tbAccessToken.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 550);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 36;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblCorporateID
            // 
            this.lblCorporateID.Location = new System.Drawing.Point(29, 202);
            this.lblCorporateID.Name = "lblCorporateID";
            this.lblCorporateID.Size = new System.Drawing.Size(96, 13);
            this.lblCorporateID.TabIndex = 44;
            this.lblCorporateID.Text = "Corporate ID : ";
            this.lblCorporateID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbContentType
            // 
            this.cbContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContentType.FormattingEnabled = true;
            this.cbContentType.Items.AddRange(new object[] {
            "application/json"});
            this.cbContentType.Location = new System.Drawing.Point(131, 172);
            this.cbContentType.Name = "cbContentType";
            this.cbContentType.Size = new System.Drawing.Size(192, 21);
            this.cbContentType.TabIndex = 45;
            this.cbContentType.Tag = "";
            // 
            // lblContentType
            // 
            this.lblContentType.Location = new System.Drawing.Point(29, 175);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(96, 13);
            this.lblContentType.TabIndex = 46;
            this.lblContentType.Text = "Content-Type : ";
            this.lblContentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSourceAccount
            // 
            this.lblSourceAccount.Location = new System.Drawing.Point(29, 228);
            this.lblSourceAccount.Name = "lblSourceAccount";
            this.lblSourceAccount.Size = new System.Drawing.Size(96, 13);
            this.lblSourceAccount.TabIndex = 47;
            this.lblSourceAccount.Text = "Source Account : ";
            this.lblSourceAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.Location = new System.Drawing.Point(29, 254);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(96, 13);
            this.lblTransactionID.TabIndex = 48;
            this.lblTransactionID.Text = "Transaction ID : ";
            this.lblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransactionDate
            // 
            this.lblTransactionDate.Location = new System.Drawing.Point(27, 281);
            this.lblTransactionDate.Name = "lblTransactionDate";
            this.lblTransactionDate.Size = new System.Drawing.Size(96, 13);
            this.lblTransactionDate.TabIndex = 49;
            this.lblTransactionDate.Text = "Transaction Date : ";
            this.lblTransactionDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblReferenceID
            // 
            this.lblReferenceID.Location = new System.Drawing.Point(29, 306);
            this.lblReferenceID.Name = "lblReferenceID";
            this.lblReferenceID.Size = new System.Drawing.Size(96, 13);
            this.lblReferenceID.TabIndex = 50;
            this.lblReferenceID.Text = "Reference ID : ";
            this.lblReferenceID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.Location = new System.Drawing.Point(29, 332);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(96, 13);
            this.lblCurrencyCode.TabIndex = 51;
            this.lblCurrencyCode.Text = "Currency Code : ";
            this.lblCurrencyCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(29, 358);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(96, 13);
            this.lblAmount.TabIndex = 52;
            this.lblAmount.Text = "Amount : ";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBeneficiaryAccount
            // 
            this.lblBeneficiaryAccount.Location = new System.Drawing.Point(15, 384);
            this.lblBeneficiaryAccount.Name = "lblBeneficiaryAccount";
            this.lblBeneficiaryAccount.Size = new System.Drawing.Size(110, 13);
            this.lblBeneficiaryAccount.TabIndex = 53;
            this.lblBeneficiaryAccount.Text = "Beneficiary Account : ";
            this.lblBeneficiaryAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemark1
            // 
            this.lblRemark1.Location = new System.Drawing.Point(29, 410);
            this.lblRemark1.Name = "lblRemark1";
            this.lblRemark1.Size = new System.Drawing.Size(96, 13);
            this.lblRemark1.TabIndex = 54;
            this.lblRemark1.Text = "Remark 1 : ";
            this.lblRemark1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRemark2
            // 
            this.lblRemark2.Location = new System.Drawing.Point(29, 483);
            this.lblRemark2.Name = "lblRemark2";
            this.lblRemark2.Size = new System.Drawing.Size(96, 13);
            this.lblRemark2.TabIndex = 55;
            this.lblRemark2.Text = "Remark 2 : ";
            this.lblRemark2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCorporateID
            // 
            this.tbCorporateID.Location = new System.Drawing.Point(131, 199);
            this.tbCorporateID.Name = "tbCorporateID";
            this.tbCorporateID.Size = new System.Drawing.Size(128, 20);
            this.tbCorporateID.TabIndex = 56;
            // 
            // tbSourceAccount
            // 
            this.tbSourceAccount.Location = new System.Drawing.Point(131, 225);
            this.tbSourceAccount.Name = "tbSourceAccount";
            this.tbSourceAccount.Size = new System.Drawing.Size(128, 20);
            this.tbSourceAccount.TabIndex = 57;
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Location = new System.Drawing.Point(131, 251);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.Size = new System.Drawing.Size(128, 20);
            this.tbTransactionID.TabIndex = 58;
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.Location = new System.Drawing.Point(131, 277);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(192, 20);
            this.dtpTransactionDate.TabIndex = 59;
            // 
            // tbReferenceID
            // 
            this.tbReferenceID.Location = new System.Drawing.Point(131, 303);
            this.tbReferenceID.Name = "tbReferenceID";
            this.tbReferenceID.Size = new System.Drawing.Size(128, 20);
            this.tbReferenceID.TabIndex = 60;
            // 
            // tbCurrencyCode
            // 
            this.tbCurrencyCode.Location = new System.Drawing.Point(131, 329);
            this.tbCurrencyCode.Name = "tbCurrencyCode";
            this.tbCurrencyCode.ReadOnly = true;
            this.tbCurrencyCode.Size = new System.Drawing.Size(64, 20);
            this.tbCurrencyCode.TabIndex = 61;
            // 
            // tbBeneficiaryAccount
            // 
            this.tbBeneficiaryAccount.Location = new System.Drawing.Point(131, 381);
            this.tbBeneficiaryAccount.Name = "tbBeneficiaryAccount";
            this.tbBeneficiaryAccount.Size = new System.Drawing.Size(128, 20);
            this.tbBeneficiaryAccount.TabIndex = 63;
            // 
            // rtbRemark1
            // 
            this.rtbRemark1.Location = new System.Drawing.Point(131, 410);
            this.rtbRemark1.Name = "rtbRemark1";
            this.rtbRemark1.Size = new System.Drawing.Size(256, 64);
            this.rtbRemark1.TabIndex = 64;
            this.rtbRemark1.Text = "";
            // 
            // rtbRemark2
            // 
            this.rtbRemark2.Location = new System.Drawing.Point(131, 480);
            this.rtbRemark2.Name = "rtbRemark2";
            this.rtbRemark2.Size = new System.Drawing.Size(256, 64);
            this.rtbRemark2.TabIndex = 65;
            this.rtbRemark2.Text = "";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(131, 356);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(128, 20);
            this.nudAmount.TabIndex = 66;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 595);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.rtbRemark2);
            this.Controls.Add(this.rtbRemark1);
            this.Controls.Add(this.tbBeneficiaryAccount);
            this.Controls.Add(this.tbCurrencyCode);
            this.Controls.Add(this.tbReferenceID);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.tbTransactionID);
            this.Controls.Add(this.tbSourceAccount);
            this.Controls.Add(this.tbCorporateID);
            this.Controls.Add(this.lblRemark2);
            this.Controls.Add(this.lblRemark1);
            this.Controls.Add(this.lblBeneficiaryAccount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblCurrencyCode);
            this.Controls.Add(this.lblReferenceID);
            this.Controls.Add(this.lblTransactionDate);
            this.Controls.Add(this.lblTransactionID);
            this.Controls.Add(this.lblSourceAccount);
            this.Controls.Add(this.cbContentType);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.lblCorporateID);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.lblFundTransfer);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.tbAccessToken);
            this.Controls.Add(this.btnSend);
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblFundTransfer;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblCorporateID;
        private System.Windows.Forms.ComboBox cbContentType;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label lblSourceAccount;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.Label lblTransactionDate;
        private System.Windows.Forms.Label lblReferenceID;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBeneficiaryAccount;
        private System.Windows.Forms.Label lblRemark1;
        private System.Windows.Forms.Label lblRemark2;
        private System.Windows.Forms.TextBox tbCorporateID;
        private System.Windows.Forms.TextBox tbSourceAccount;
        private System.Windows.Forms.TextBox tbTransactionID;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.TextBox tbReferenceID;
        private System.Windows.Forms.TextBox tbCurrencyCode;
        private System.Windows.Forms.TextBox tbBeneficiaryAccount;
        private System.Windows.Forms.RichTextBox rtbRemark1;
        private System.Windows.Forms.RichTextBox rtbRemark2;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}