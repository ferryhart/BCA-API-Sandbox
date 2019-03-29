namespace BCA_Sandbox
{
    partial class frmAccountStatement
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblCorporateID = new System.Windows.Forms.Label();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblBalanceInformation = new System.Windows.Forms.Label();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.tbCorporateID = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSignature
            // 
            this.lblSignature.Location = new System.Drawing.Point(29, 175);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(96, 13);
            this.lblSignature.TabIndex = 43;
            this.lblSignature.Text = "X-BCA-Signature : ";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(131, 172);
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
            this.rtbResult.TabIndex = 0;
            this.rtbResult.TabStop = false;
            this.rtbResult.Text = "";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Location = new System.Drawing.Point(29, 253);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(96, 13);
            this.lblAccountNumber.TabIndex = 41;
            this.lblAccountNumber.Text = "Account Number : ";
            this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCorporateID
            // 
            this.lblCorporateID.Location = new System.Drawing.Point(29, 227);
            this.lblCorporateID.Name = "lblCorporateID";
            this.lblCorporateID.Size = new System.Drawing.Size(96, 13);
            this.lblCorporateID.TabIndex = 40;
            this.lblCorporateID.Text = "Corporate ID : ";
            this.lblCorporateID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURI
            // 
            this.lblURI.Location = new System.Drawing.Point(29, 201);
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
            // lblBalanceInformation
            // 
            this.lblBalanceInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBalanceInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceInformation.Location = new System.Drawing.Point(0, 0);
            this.lblBalanceInformation.Name = "lblBalanceInformation";
            this.lblBalanceInformation.Size = new System.Drawing.Size(1366, 64);
            this.lblBalanceInformation.TabIndex = 37;
            this.lblBalanceInformation.Text = "  Account Statement";
            this.lblBalanceInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(131, 198);
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
            this.tbAccessToken.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 276);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(131, 250);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(128, 20);
            this.tbAccountNumber.TabIndex = 5;
            this.tbAccountNumber.TextChanged += new System.EventHandler(this.tbAccountNumber_TextChanged);
            // 
            // tbCorporateID
            // 
            this.tbCorporateID.Location = new System.Drawing.Point(131, 224);
            this.tbCorporateID.Name = "tbCorporateID";
            this.tbCorporateID.Size = new System.Drawing.Size(128, 20);
            this.tbCorporateID.TabIndex = 4;
            this.tbCorporateID.TextChanged += new System.EventHandler(this.tbCorporateID_TextChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(29, 152);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(96, 13);
            this.lblEndDate.TabIndex = 45;
            this.lblEndDate.Text = "End Date : ";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(29, 126);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 13);
            this.lblStartDate.TabIndex = 44;
            this.lblStartDate.Text = "Start Date : ";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(131, 120);
            this.dtpStartDate.MaxDate = new System.DateTime(2016, 9, 1, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(2016, 8, 29, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.Value = new System.DateTime(2016, 8, 29, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(131, 146);
            this.dtpEndDate.MaxDate = new System.DateTime(2016, 9, 1, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(2016, 8, 29, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 3;
            this.dtpEndDate.Value = new System.DateTime(2016, 8, 29, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // frmAccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 502);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblCorporateID);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.lblBalanceInformation);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.tbAccessToken);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.tbCorporateID);
            this.Name = "frmAccountStatement";
            this.Text = "Account Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblCorporateID;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblBalanceInformation;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.TextBox tbCorporateID;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}