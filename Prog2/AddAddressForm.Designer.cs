namespace UPVApp
{
    partial class AddAddressForm
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
            this.components = new System.ComponentModel.Container();
            this.name_Lbl = new System.Windows.Forms.Label();
            this.addressLine1_Lbl = new System.Windows.Forms.Label();
            this.addressLine2_Lbl = new System.Windows.Forms.Label();
            this.city_Lbl = new System.Windows.Forms.Label();
            this.state_Lbl = new System.Windows.Forms.Label();
            this.zipCode_Lbl = new System.Windows.Forms.Label();
            this.name_Txt = new System.Windows.Forms.TextBox();
            this.addressLine1_Txt = new System.Windows.Forms.TextBox();
            this.addressLine2_Txt = new System.Windows.Forms.TextBox();
            this.city_Txt = new System.Windows.Forms.TextBox();
            this.zipCode_Txt = new System.Windows.Forms.TextBox();
            this.stateSelector_ComboBox = new System.Windows.Forms.ComboBox();
            this.addAddress_Btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_Lbl
            // 
            this.name_Lbl.Location = new System.Drawing.Point(7, 7);
            this.name_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_Lbl.Name = "name_Lbl";
            this.name_Lbl.Size = new System.Drawing.Size(87, 12);
            this.name_Lbl.TabIndex = 0;
            this.name_Lbl.Text = "Name:";
            // 
            // addressLine1_Lbl
            // 
            this.addressLine1_Lbl.Location = new System.Drawing.Point(7, 29);
            this.addressLine1_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLine1_Lbl.Name = "addressLine1_Lbl";
            this.addressLine1_Lbl.Size = new System.Drawing.Size(87, 12);
            this.addressLine1_Lbl.TabIndex = 1;
            this.addressLine1_Lbl.Text = "Address Line 1:";
            // 
            // addressLine2_Lbl
            // 
            this.addressLine2_Lbl.Location = new System.Drawing.Point(7, 50);
            this.addressLine2_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLine2_Lbl.Name = "addressLine2_Lbl";
            this.addressLine2_Lbl.Size = new System.Drawing.Size(87, 12);
            this.addressLine2_Lbl.TabIndex = 2;
            this.addressLine2_Lbl.Text = "Address Line 2:";
            // 
            // city_Lbl
            // 
            this.city_Lbl.Location = new System.Drawing.Point(7, 72);
            this.city_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.city_Lbl.Name = "city_Lbl";
            this.city_Lbl.Size = new System.Drawing.Size(87, 12);
            this.city_Lbl.TabIndex = 3;
            this.city_Lbl.Text = "City:";
            // 
            // state_Lbl
            // 
            this.state_Lbl.Location = new System.Drawing.Point(7, 94);
            this.state_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.state_Lbl.Name = "state_Lbl";
            this.state_Lbl.Size = new System.Drawing.Size(87, 12);
            this.state_Lbl.TabIndex = 4;
            this.state_Lbl.Text = "State:";
            // 
            // zipCode_Lbl
            // 
            this.zipCode_Lbl.Location = new System.Drawing.Point(7, 116);
            this.zipCode_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipCode_Lbl.Name = "zipCode_Lbl";
            this.zipCode_Lbl.Size = new System.Drawing.Size(87, 12);
            this.zipCode_Lbl.TabIndex = 5;
            this.zipCode_Lbl.Text = "Zip Code:";
            // 
            // name_Txt
            // 
            this.name_Txt.Location = new System.Drawing.Point(97, 5);
            this.name_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.name_Txt.Name = "name_Txt";
            this.name_Txt.Size = new System.Drawing.Size(148, 20);
            this.name_Txt.TabIndex = 6;
            this.name_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Validating);
            // 
            // addressLine1_Txt
            // 
            this.addressLine1_Txt.Location = new System.Drawing.Point(97, 28);
            this.addressLine1_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.addressLine1_Txt.Name = "addressLine1_Txt";
            this.addressLine1_Txt.Size = new System.Drawing.Size(148, 20);
            this.addressLine1_Txt.TabIndex = 7;
            this.addressLine1_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Validating);
            // 
            // addressLine2_Txt
            // 
            this.addressLine2_Txt.Location = new System.Drawing.Point(97, 49);
            this.addressLine2_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.addressLine2_Txt.Name = "addressLine2_Txt";
            this.addressLine2_Txt.Size = new System.Drawing.Size(148, 20);
            this.addressLine2_Txt.TabIndex = 8;
            // 
            // city_Txt
            // 
            this.city_Txt.Location = new System.Drawing.Point(97, 70);
            this.city_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.city_Txt.Name = "city_Txt";
            this.city_Txt.Size = new System.Drawing.Size(148, 20);
            this.city_Txt.TabIndex = 9;
            this.city_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Validating);
            // 
            // zipCode_Txt
            // 
            this.zipCode_Txt.Location = new System.Drawing.Point(97, 114);
            this.zipCode_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.zipCode_Txt.Name = "zipCode_Txt";
            this.zipCode_Txt.Size = new System.Drawing.Size(68, 20);
            this.zipCode_Txt.TabIndex = 10;
            this.zipCode_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.ZipCode_Validating);
            // 
            // stateSelector_ComboBox
            // 
            this.stateSelector_ComboBox.FormattingEnabled = true;
            this.stateSelector_ComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateSelector_ComboBox.Location = new System.Drawing.Point(97, 93);
            this.stateSelector_ComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.stateSelector_ComboBox.Name = "stateSelector_ComboBox";
            this.stateSelector_ComboBox.Size = new System.Drawing.Size(68, 21);
            this.stateSelector_ComboBox.TabIndex = 11;
            this.stateSelector_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.StateSelector_Validating);
            // 
            // addAddress_Btn
            // 
            this.addAddress_Btn.Location = new System.Drawing.Point(10, 140);
            this.addAddress_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.addAddress_Btn.Name = "addAddress_Btn";
            this.addAddress_Btn.Size = new System.Drawing.Size(251, 24);
            this.addAddress_Btn.TabIndex = 12;
            this.addAddress_Btn.Text = "Add Address";
            this.addAddress_Btn.UseVisualStyleBackColor = true;
            this.addAddress_Btn.Click += new System.EventHandler(this.AddAddress_Btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 171);
            this.Controls.Add(this.addAddress_Btn);
            this.Controls.Add(this.stateSelector_ComboBox);
            this.Controls.Add(this.zipCode_Txt);
            this.Controls.Add(this.city_Txt);
            this.Controls.Add(this.addressLine2_Txt);
            this.Controls.Add(this.addressLine1_Txt);
            this.Controls.Add(this.name_Txt);
            this.Controls.Add(this.zipCode_Lbl);
            this.Controls.Add(this.state_Lbl);
            this.Controls.Add(this.city_Lbl);
            this.Controls.Add(this.addressLine2_Lbl);
            this.Controls.Add(this.addressLine1_Lbl);
            this.Controls.Add(this.name_Lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddAddressForm";
            this.Text = "AddAddressForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_Lbl;
        private System.Windows.Forms.Label addressLine1_Lbl;
        private System.Windows.Forms.Label addressLine2_Lbl;
        private System.Windows.Forms.Label city_Lbl;
        private System.Windows.Forms.Label state_Lbl;
        private System.Windows.Forms.Label zipCode_Lbl;
        private System.Windows.Forms.TextBox name_Txt;
        private System.Windows.Forms.TextBox addressLine1_Txt;
        private System.Windows.Forms.TextBox addressLine2_Txt;
        private System.Windows.Forms.TextBox city_Txt;
        private System.Windows.Forms.TextBox zipCode_Txt;
        private System.Windows.Forms.ComboBox stateSelector_ComboBox;
        private System.Windows.Forms.Button addAddress_Btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}