namespace BCA_Sandbox
{
    partial class frmRequestToken
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
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.lblContentType = new System.Windows.Forms.Label();
            this.lblGrantType = new System.Windows.Forms.Label();
            this.tbGrantType = new System.Windows.Forms.TextBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbAuthorization = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbContentType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.Location = new System.Drawing.Point(29, 97);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(96, 13);
            this.lblAuthorization.TabIndex = 0;
            this.lblAuthorization.Text = "Authorization : ";
            this.lblAuthorization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContentType
            // 
            this.lblContentType.Location = new System.Drawing.Point(29, 123);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(96, 13);
            this.lblContentType.TabIndex = 1;
            this.lblContentType.Text = "Content-Type : ";
            this.lblContentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrantType
            // 
            this.lblGrantType.Location = new System.Drawing.Point(29, 149);
            this.lblGrantType.Name = "lblGrantType";
            this.lblGrantType.Size = new System.Drawing.Size(96, 13);
            this.lblGrantType.TabIndex = 2;
            this.lblGrantType.Text = "Grant Type : ";
            this.lblGrantType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbGrantType
            // 
            this.tbGrantType.Location = new System.Drawing.Point(131, 146);
            this.tbGrantType.Name = "tbGrantType";
            this.tbGrantType.ReadOnly = true;
            this.tbGrantType.Size = new System.Drawing.Size(96, 20);
            this.tbGrantType.TabIndex = 0;
            this.tbGrantType.TabStop = false;
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
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(393, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResult.Size = new System.Drawing.Size(96, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result : ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAuthorization
            // 
            this.tbAuthorization.Location = new System.Drawing.Point(131, 94);
            this.tbAuthorization.Name = "tbAuthorization";
            this.tbAuthorization.ReadOnly = true;
            this.tbAuthorization.Size = new System.Drawing.Size(256, 20);
            this.tbAuthorization.TabIndex = 0;
            this.tbAuthorization.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(131, 172);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbContentType
            // 
            this.cbContentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbContentType.FormattingEnabled = true;
            this.cbContentType.Items.AddRange(new object[] {
            "application/x-www-form-urlencoded"});
            this.cbContentType.Location = new System.Drawing.Point(131, 120);
            this.cbContentType.Name = "cbContentType";
            this.cbContentType.Size = new System.Drawing.Size(192, 21);
            this.cbContentType.TabIndex = 0;
            this.cbContentType.Tag = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1366, 64);
            this.label1.TabIndex = 20;
            this.label1.Text = "  Request Token";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRequestToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbContentType);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.tbGrantType);
            this.Controls.Add(this.tbAuthorization);
            this.Controls.Add(this.lblGrantType);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.lblAuthorization);
            this.Name = "frmRequestToken";
            this.Text = "Request Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label lblGrantType;
        private System.Windows.Forms.TextBox tbGrantType;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbAuthorization;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbContentType;
        private System.Windows.Forms.Label label1;
    }
}