namespace BCA_Sandbox
{
    partial class frmForeignExchangeRate
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
            this.lblRateType = new System.Windows.Forms.Label();
            this.lblCurrencyCode = new System.Windows.Forms.Label();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblForeignExchangeRate = new System.Windows.Forms.Label();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbCurrencyCode = new System.Windows.Forms.ComboBox();
            this.cbRateType = new System.Windows.Forms.ComboBox();
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
            // lblRateType
            // 
            this.lblRateType.Location = new System.Drawing.Point(29, 202);
            this.lblRateType.Name = "lblRateType";
            this.lblRateType.Size = new System.Drawing.Size(96, 13);
            this.lblRateType.TabIndex = 41;
            this.lblRateType.Text = "Rate Type : ";
            this.lblRateType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrencyCode
            // 
            this.lblCurrencyCode.Location = new System.Drawing.Point(29, 175);
            this.lblCurrencyCode.Name = "lblCurrencyCode";
            this.lblCurrencyCode.Size = new System.Drawing.Size(96, 13);
            this.lblCurrencyCode.TabIndex = 40;
            this.lblCurrencyCode.Text = "Currency Code : ";
            this.lblCurrencyCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // lblForeignExchangeRate
            // 
            this.lblForeignExchangeRate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblForeignExchangeRate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForeignExchangeRate.Location = new System.Drawing.Point(0, 0);
            this.lblForeignExchangeRate.Name = "lblForeignExchangeRate";
            this.lblForeignExchangeRate.Size = new System.Drawing.Size(1366, 64);
            this.lblForeignExchangeRate.TabIndex = 37;
            this.lblForeignExchangeRate.Text = "  Foreign Exchange Rate";
            this.lblForeignExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tbAccessToken.TabIndex = 33;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 36;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbCurrencyCode
            // 
            this.cbCurrencyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrencyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCurrencyCode.FormattingEnabled = true;
            this.cbCurrencyCode.Location = new System.Drawing.Point(131, 172);
            this.cbCurrencyCode.Name = "cbCurrencyCode";
            this.cbCurrencyCode.Size = new System.Drawing.Size(192, 21);
            this.cbCurrencyCode.TabIndex = 44;
            this.cbCurrencyCode.Tag = "";
            this.cbCurrencyCode.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyCode_SelectedIndexChanged);
            // 
            // cbRateType
            // 
            this.cbRateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRateType.FormattingEnabled = true;
            this.cbRateType.Location = new System.Drawing.Point(131, 199);
            this.cbRateType.Name = "cbRateType";
            this.cbRateType.Size = new System.Drawing.Size(192, 21);
            this.cbRateType.TabIndex = 45;
            this.cbRateType.Tag = "";
            this.cbRateType.SelectedIndexChanged += new System.EventHandler(this.cbRateType_SelectedIndexChanged);
            // 
            // frmForeignExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 465);
            this.Controls.Add(this.cbRateType);
            this.Controls.Add(this.cbCurrencyCode);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblRateType);
            this.Controls.Add(this.lblCurrencyCode);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.lblForeignExchangeRate);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.tbAccessToken);
            this.Controls.Add(this.btnSend);
            this.Name = "frmForeignExchangeRate";
            this.Text = "Foreign Exchange Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblRateType;
        private System.Windows.Forms.Label lblCurrencyCode;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblForeignExchangeRate;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbCurrencyCode;
        private System.Windows.Forms.ComboBox cbRateType;
    }
}