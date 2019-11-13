namespace UPVApp
{
    partial class Prog2Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report_Txt = new System.Windows.Forms.TextBox();
            this.totalCost_Lbl = new System.Windows.Forms.Label();
            this.totalCostAmount_Lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.resportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addressToolStripMenuItem,
            this.letterToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // addressToolStripMenuItem
            // 
            this.addressToolStripMenuItem.Name = "addressToolStripMenuItem";
            this.addressToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addressToolStripMenuItem.Text = "&Address";
            this.addressToolStripMenuItem.Click += new System.EventHandler(this.AddressToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem
            // 
            this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            this.letterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.letterToolStripMenuItem.Text = "&Letter";
            this.letterToolStripMenuItem.Click += new System.EventHandler(this.LetterToolStripMenuItem_Click);
            // 
            // resportToolStripMenuItem
            // 
            this.resportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressesToolStripMenuItem,
            this.listParcelsToolStripMenuItem});
            this.resportToolStripMenuItem.Name = "resportToolStripMenuItem";
            this.resportToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.resportToolStripMenuItem.Text = "R&eport";
            // 
            // listAddressesToolStripMenuItem
            // 
            this.listAddressesToolStripMenuItem.Name = "listAddressesToolStripMenuItem";
            this.listAddressesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listAddressesToolStripMenuItem.Text = "List &Addresses";
            this.listAddressesToolStripMenuItem.Click += new System.EventHandler(this.ListAddressesToolStripMenuItem_Click);
            // 
            // listParcelsToolStripMenuItem
            // 
            this.listParcelsToolStripMenuItem.Name = "listParcelsToolStripMenuItem";
            this.listParcelsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.listParcelsToolStripMenuItem.Text = "List &Parcels";
            this.listParcelsToolStripMenuItem.Click += new System.EventHandler(this.ListParcelsToolStripMenuItem_Click);
            // 
            // report_Txt
            // 
            this.report_Txt.Location = new System.Drawing.Point(13, 48);
            this.report_Txt.Multiline = true;
            this.report_Txt.Name = "report_Txt";
            this.report_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.report_Txt.Size = new System.Drawing.Size(315, 82);
            this.report_Txt.TabIndex = 1;
            // 
            // totalCost_Lbl
            // 
            this.totalCost_Lbl.AutoSize = true;
            this.totalCost_Lbl.Location = new System.Drawing.Point(13, 149);
            this.totalCost_Lbl.Name = "totalCost_Lbl";
            this.totalCost_Lbl.Size = new System.Drawing.Size(58, 13);
            this.totalCost_Lbl.TabIndex = 2;
            this.totalCost_Lbl.Text = "Total Cost:";
            // 
            // totalCostAmount_Lbl
            // 
            this.totalCostAmount_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostAmount_Lbl.Location = new System.Drawing.Point(77, 149);
            this.totalCostAmount_Lbl.Name = "totalCostAmount_Lbl";
            this.totalCostAmount_Lbl.Size = new System.Drawing.Size(122, 16);
            this.totalCostAmount_Lbl.TabIndex = 3;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 174);
            this.Controls.Add(this.totalCostAmount_Lbl);
            this.Controls.Add(this.totalCost_Lbl);
            this.Controls.Add(this.report_Txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prog2Form";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelsToolStripMenuItem;
        private System.Windows.Forms.TextBox report_Txt;
        private System.Windows.Forms.Label totalCost_Lbl;
        private System.Windows.Forms.Label totalCostAmount_Lbl;
    }
}

