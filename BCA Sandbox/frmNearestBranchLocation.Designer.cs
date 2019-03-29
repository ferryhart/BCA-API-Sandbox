namespace BCA_Sandbox
{
    partial class frmNearestBranchLocation
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
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.tbSignature = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblURI = new System.Windows.Forms.Label();
            this.lblAccessToken = new System.Windows.Forms.Label();
            this.lblNearestBranchLocation = new System.Windows.Forms.Label();
            this.tbURI = new System.Windows.Forms.TextBox();
            this.tbAccessToken = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbValue
            // 
            this.cbValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Items.AddRange(new object[] {
            "kcu",
            "kcp",
            "e-branch",
            "weekendbanking"});
            this.cbValue.Location = new System.Drawing.Point(131, 303);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(128, 21);
            this.cbValue.TabIndex = 59;
            this.cbValue.Tag = "";
            this.cbValue.TextChanged += new System.EventHandler(this.cbValue_TextChanged);
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "",
            "Address",
            "City",
            "Type"});
            this.cbSearchBy.Location = new System.Drawing.Point(131, 276);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(128, 21);
            this.cbSearchBy.TabIndex = 58;
            this.cbSearchBy.Tag = "";
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // lblSignature
            // 
            this.lblSignature.Location = new System.Drawing.Point(29, 123);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(96, 13);
            this.lblSignature.TabIndex = 57;
            this.lblSignature.Text = "X-BCA-Signature : ";
            this.lblSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSignature
            // 
            this.tbSignature.Location = new System.Drawing.Point(131, 120);
            this.tbSignature.Name = "tbSignature";
            this.tbSignature.ReadOnly = true;
            this.tbSignature.Size = new System.Drawing.Size(256, 20);
            this.tbSignature.TabIndex = 46;
            this.tbSignature.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(393, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(96, 13);
            this.lblResult.TabIndex = 56;
            this.lblResult.Text = "Result : ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(495, 94);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(502, 318);
            this.rtbResult.TabIndex = 47;
            this.rtbResult.TabStop = false;
            this.rtbResult.Text = "";
            // 
            // lblValue
            // 
            this.lblValue.Location = new System.Drawing.Point(29, 306);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(96, 13);
            this.lblValue.TabIndex = 55;
            this.lblValue.Text = "Value : ";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Location = new System.Drawing.Point(29, 279);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(96, 13);
            this.lblSearchBy.TabIndex = 54;
            this.lblSearchBy.Text = "Search By : ";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblURI
            // 
            this.lblURI.Location = new System.Drawing.Point(29, 149);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(96, 13);
            this.lblURI.TabIndex = 53;
            this.lblURI.Text = "URI : ";
            this.lblURI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccessToken
            // 
            this.lblAccessToken.Location = new System.Drawing.Point(29, 97);
            this.lblAccessToken.Name = "lblAccessToken";
            this.lblAccessToken.Size = new System.Drawing.Size(96, 13);
            this.lblAccessToken.TabIndex = 52;
            this.lblAccessToken.Text = "Access Token : ";
            this.lblAccessToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNearestBranchLocation
            // 
            this.lblNearestBranchLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNearestBranchLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNearestBranchLocation.Location = new System.Drawing.Point(0, 0);
            this.lblNearestBranchLocation.Name = "lblNearestBranchLocation";
            this.lblNearestBranchLocation.Size = new System.Drawing.Size(1366, 64);
            this.lblNearestBranchLocation.TabIndex = 51;
            this.lblNearestBranchLocation.Text = "  Nearest Branch Location";
            this.lblNearestBranchLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbURI
            // 
            this.tbURI.Location = new System.Drawing.Point(131, 146);
            this.tbURI.Name = "tbURI";
            this.tbURI.ReadOnly = true;
            this.tbURI.Size = new System.Drawing.Size(256, 20);
            this.tbURI.TabIndex = 48;
            this.tbURI.TabStop = false;
            // 
            // tbAccessToken
            // 
            this.tbAccessToken.Location = new System.Drawing.Point(131, 94);
            this.tbAccessToken.Name = "tbAccessToken";
            this.tbAccessToken.Size = new System.Drawing.Size(256, 20);
            this.tbAccessToken.TabIndex = 49;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 330);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 50;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(131, 172);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(128, 20);
            this.tbLatitude.TabIndex = 60;
            this.tbLatitude.TextChanged += new System.EventHandler(this.tbLatitude_TextChanged);
            // 
            // lblLatitude
            // 
            this.lblLatitude.Location = new System.Drawing.Point(29, 175);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(96, 13);
            this.lblLatitude.TabIndex = 61;
            this.lblLatitude.Text = "Latitude : ";
            this.lblLatitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLongitude
            // 
            this.lblLongitude.Location = new System.Drawing.Point(29, 201);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(96, 13);
            this.lblLongitude.TabIndex = 62;
            this.lblLongitude.Text = "Longitude : ";
            this.lblLongitude.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(131, 198);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(128, 20);
            this.tbLongitude.TabIndex = 63;
            this.tbLongitude.TextChanged += new System.EventHandler(this.tbLongitude_TextChanged);
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(131, 224);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(64, 20);
            this.nudRadius.TabIndex = 68;
            this.nudRadius.ValueChanged += new System.EventHandler(this.nudRadius_ValueChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.Location = new System.Drawing.Point(29, 226);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(96, 13);
            this.lblRadius.TabIndex = 67;
            this.lblRadius.Text = "Radius (Meter) : ";
            this.lblRadius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(131, 250);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(64, 20);
            this.nudCount.TabIndex = 70;
            this.nudCount.ValueChanged += new System.EventHandler(this.nudCount_ValueChanged);
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(29, 252);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(96, 13);
            this.lblCount.TabIndex = 69;
            this.lblCount.Text = "Count : ";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNearestBranchLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 492);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.tbLongitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.tbLatitude);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.tbSignature);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblURI);
            this.Controls.Add(this.lblAccessToken);
            this.Controls.Add(this.lblNearestBranchLocation);
            this.Controls.Add(this.tbURI);
            this.Controls.Add(this.tbAccessToken);
            this.Controls.Add(this.btnSend);
            this.Name = "frmNearestBranchLocation";
            this.Text = "Nearest Branch Location";
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.TextBox tbSignature;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.Label lblAccessToken;
        private System.Windows.Forms.Label lblNearestBranchLocation;
        private System.Windows.Forms.TextBox tbURI;
        private System.Windows.Forms.TextBox tbAccessToken;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lblCount;
    }
}