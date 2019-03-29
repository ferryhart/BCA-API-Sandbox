namespace BCA_Sandbox
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankingCorporatesV3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessBankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferDomesticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreignExchangeRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nearestBranchLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilitiesToolStripMenuItem,
            this.bankingCorporatesV3ToolStripMenuItem,
            this.businessBankingToolStripMenuItem,
            this.generalInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.utilitiesToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestTokenToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // requestTokenToolStripMenuItem
            // 
            this.requestTokenToolStripMenuItem.Name = "requestTokenToolStripMenuItem";
            this.requestTokenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.requestTokenToolStripMenuItem.Text = "Request Token";
            this.requestTokenToolStripMenuItem.Click += new System.EventHandler(this.requestTokenToolStripMenuItem_Click);
            // 
            // bankingCorporatesV3ToolStripMenuItem
            // 
            this.bankingCorporatesV3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceInformationToolStripMenuItem,
            this.accountStatementToolStripMenuItem});
            this.bankingCorporatesV3ToolStripMenuItem.Name = "bankingCorporatesV3ToolStripMenuItem";
            this.bankingCorporatesV3ToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.bankingCorporatesV3ToolStripMenuItem.Text = "Banking Corporates v3";
            // 
            // balanceInformationToolStripMenuItem
            // 
            this.balanceInformationToolStripMenuItem.Name = "balanceInformationToolStripMenuItem";
            this.balanceInformationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.balanceInformationToolStripMenuItem.Text = "Balance Information";
            this.balanceInformationToolStripMenuItem.Click += new System.EventHandler(this.balanceInformationToolStripMenuItem_Click);
            // 
            // accountStatementToolStripMenuItem
            // 
            this.accountStatementToolStripMenuItem.Name = "accountStatementToolStripMenuItem";
            this.accountStatementToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.accountStatementToolStripMenuItem.Text = "Account Statement";
            this.accountStatementToolStripMenuItem.Click += new System.EventHandler(this.accountStatementToolStripMenuItem_Click);
            // 
            // businessBankingToolStripMenuItem
            // 
            this.businessBankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferToolStripMenuItem,
            this.transferDomesticToolStripMenuItem});
            this.businessBankingToolStripMenuItem.Name = "businessBankingToolStripMenuItem";
            this.businessBankingToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.businessBankingToolStripMenuItem.Text = "Business Banking";
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // transferDomesticToolStripMenuItem
            // 
            this.transferDomesticToolStripMenuItem.Name = "transferDomesticToolStripMenuItem";
            this.transferDomesticToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.transferDomesticToolStripMenuItem.Text = "Transfer Domestic";
            this.transferDomesticToolStripMenuItem.Click += new System.EventHandler(this.transferDomesticToolStripMenuItem_Click);
            // 
            // generalInformationToolStripMenuItem
            // 
            this.generalInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreignExchangeRateToolStripMenuItem,
            this.nearestBranchLocationToolStripMenuItem});
            this.generalInformationToolStripMenuItem.Name = "generalInformationToolStripMenuItem";
            this.generalInformationToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.generalInformationToolStripMenuItem.Text = "General Information";
            // 
            // foreignExchangeRateToolStripMenuItem
            // 
            this.foreignExchangeRateToolStripMenuItem.Name = "foreignExchangeRateToolStripMenuItem";
            this.foreignExchangeRateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.foreignExchangeRateToolStripMenuItem.Text = "Foreign Exchange Rate";
            this.foreignExchangeRateToolStripMenuItem.Click += new System.EventHandler(this.foreignExchangeRateToolStripMenuItem_Click);
            // 
            // nearestBranchLocationToolStripMenuItem
            // 
            this.nearestBranchLocationToolStripMenuItem.Name = "nearestBranchLocationToolStripMenuItem";
            this.nearestBranchLocationToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nearestBranchLocationToolStripMenuItem.Text = "Nearest Branch Location";
            this.nearestBranchLocationToolStripMenuItem.Click += new System.EventHandler(this.nearestBranchLocationToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 398);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "BCA Sandbox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankingCorporatesV3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessBankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferDomesticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreignExchangeRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nearestBranchLocationToolStripMenuItem;
    }
}

