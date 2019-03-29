namespace BCA_Sandbox
{
    partial class frmBalanceInformation
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
            this.tbCorporateID = new System.Windows.Forms.TextBox();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.lblBalanceInformation = new System.Windows.Forms.Label();
            this.lblCorporateID = new System.Windows.Forms.Label();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCorporateID
            // 
            this.tbCorporateID.Location = new System.Drawing.Point(131, 172);
            this.tbCorporateID.Name = "tbCorporateID";
            this.tbCorporateID.Size = new System.Drawing.Size(128, 20);
            this.tbCorporateID.TabIndex = 2;
            this.tbCorporateID.TextChanged += new System.EventHandler(this.tbCorporateID_TextChanged);
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(131, 198);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(128, 20);
            this.tbAccountNumber.TabIndex = 3;
            this.tbAccountNumber.TextChanged += new System.EventHandler(this.tbAccountNumber_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 224);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbAccessToken
            // 
            this.tbAccessToken.Location = new System.Drawing.Point(131, 94);
            this.tbAccessToken.Name = "tbAccessToken";
            this.tbAccessToken.Size = new System.Drawing.Size(256, 20);
            this.tbAccessToken.TabIndex = 0;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(131, 146);
            this.tbURI.Name = "tbURI";
            this.tbURI.ReadOnly = true;
            this.tbURI.Size = new System.Drawing.Size(256, 20);
            this.tbURI.TabIndex = 0;
            this.tbURI.TabStop = false;
            // 
            // lblBalanceInformation
            // 
            this.lblBalanceInformation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBalanceInformation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceInformation.Location = new System.Drawing.Point(0, 0);
            this.lblBalanceInformation.Name = "lblBalanceInformation";
            this.lblBalanceInformation.Size = new System.Drawing.Size(1366, 64);
            this.lblBalanceInformation.TabIndex = 21;
            this.lblBalanceInformation.Text = "  Balance Information";
            this.lblBalanceInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCorporateID
            // 
            this.lblCorporateID.Location = new System.Drawing.Point(29, 175);
            this.lblCorporateID.Name = "lblCorporateID";
            this.lblCorporateID.Size = new System.Drawing.Size(96, 13);
            this.lblCorporateID.TabIndex = 24;
            this.lblCorporateID.Text = "Corporate ID : ";
            this.lblCorporateID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURI
            // 
            this.lblURI.Location = new System.Drawing.Point(29, 149);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(96, 13);
            this.lblURI.TabIndex = 23;
            this.lblURI.Text = "URI : ";
            this.lblURI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.Location = new System.Drawing.Point(29, 97);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(96, 13);
            this.lblAccessToken.TabIndex = 22;
            this.lblAccessToken.Text = "Access Token : ";
            this.lblAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Location = new System.Drawing.Point(29, 201);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(96, 13);
            this.lblAccountNumber.TabIndex = 25;
            this.lblAccountNumber.Text = "Account Number : ";
            this.lblAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(393, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(96, 13);
            this.lblResult.TabIndex = 27;
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
            // lblSignature
            // 
            this.lblSignature.Location = new System.Drawing.Point(29, 123);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(96, 13);
            this.lblSignature.TabIndex = 29;
            this.lblSignature.Text = "X-BCA-Signature : ";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(131, 120);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.ReadOnly = true;
            this.tbSignature.Size = new System.Drawing.Size(256, 20);
            this.tbSignature.TabIndex = 0;
            this.tbSignature.TabStop = false;
            // 
            // frmBalanceInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 438);
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
            this.Name = "frmBalanceInformation";
            this.Text = "Balance Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCorporateID;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.Label lblBalanceInformation;
        private System.Windows.Forms.Label lblCorporateID;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox tbSignature;
    }
}