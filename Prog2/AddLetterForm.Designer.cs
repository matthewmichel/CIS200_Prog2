namespace UPVApp
{
    partial class AddLetterForm
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
            this.originAddress_Lbl = new System.Windows.Forms.Label();
            this.destinationAddress_Lbl = new System.Windows.Forms.Label();
            this.originAddress_ComboBox = new System.Windows.Forms.ComboBox();
            this.destinationAddress_ComboBox = new System.Windows.Forms.ComboBox();
            this.fixedCost_Lbl = new System.Windows.Forms.Label();
            this.fixedCost_Txt = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addLetter_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddress_Lbl
            // 
            this.originAddress_Lbl.Location = new System.Drawing.Point(13, 13);
            this.originAddress_Lbl.Name = "originAddress_Lbl";
            this.originAddress_Lbl.Size = new System.Drawing.Size(135, 23);
            this.originAddress_Lbl.TabIndex = 0;
            this.originAddress_Lbl.Text = "Origin Address:";
            // 
            // destinationAddress_Lbl
            // 
            this.destinationAddress_Lbl.Location = new System.Drawing.Point(13, 36);
            this.destinationAddress_Lbl.Name = "destinationAddress_Lbl";
            this.destinationAddress_Lbl.Size = new System.Drawing.Size(135, 23);
            this.destinationAddress_Lbl.TabIndex = 1;
            this.destinationAddress_Lbl.Text = "Destination Address:";
            // 
            // originAddress_ComboBox
            // 
            this.originAddress_ComboBox.FormattingEnabled = true;
            this.originAddress_ComboBox.Location = new System.Drawing.Point(154, 10);
            this.originAddress_ComboBox.Name = "originAddress_ComboBox";
            this.originAddress_ComboBox.Size = new System.Drawing.Size(184, 21);
            this.originAddress_ComboBox.TabIndex = 2;
            this.originAddress_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.OriginAddress_ComboBox_Validating);
            // 
            // destinationAddress_ComboBox
            // 
            this.destinationAddress_ComboBox.FormattingEnabled = true;
            this.destinationAddress_ComboBox.Location = new System.Drawing.Point(154, 33);
            this.destinationAddress_ComboBox.Name = "destinationAddress_ComboBox";
            this.destinationAddress_ComboBox.Size = new System.Drawing.Size(184, 21);
            this.destinationAddress_ComboBox.TabIndex = 3;
            this.destinationAddress_ComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.DestinationAddress_ComboBox_Validating);
            // 
            // fixedCost_Lbl
            // 
            this.fixedCost_Lbl.AutoSize = true;
            this.fixedCost_Lbl.Location = new System.Drawing.Point(13, 59);
            this.fixedCost_Lbl.Name = "fixedCost_Lbl";
            this.fixedCost_Lbl.Size = new System.Drawing.Size(59, 13);
            this.fixedCost_Lbl.TabIndex = 4;
            this.fixedCost_Lbl.Text = "Fixed Cost:";
            // 
            // fixedCost_Txt
            // 
            this.fixedCost_Txt.Location = new System.Drawing.Point(154, 56);
            this.fixedCost_Txt.Name = "fixedCost_Txt";
            this.fixedCost_Txt.Size = new System.Drawing.Size(100, 20);
            this.fixedCost_Txt.TabIndex = 5;
            this.fixedCost_Txt.Validating += new System.ComponentModel.CancelEventHandler(this.FixedCost_Txt_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addLetter_Btn
            // 
            this.addLetter_Btn.Location = new System.Drawing.Point(122, 97);
            this.addLetter_Btn.Name = "addLetter_Btn";
            this.addLetter_Btn.Size = new System.Drawing.Size(123, 23);
            this.addLetter_Btn.TabIndex = 6;
            this.addLetter_Btn.Text = "Add Letter";
            this.addLetter_Btn.UseVisualStyleBackColor = true;
            this.addLetter_Btn.Click += new System.EventHandler(this.AddLetter_Btn_Click);
            // 
            // AddLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 140);
            this.Controls.Add(this.addLetter_Btn);
            this.Controls.Add(this.fixedCost_Txt);
            this.Controls.Add(this.fixedCost_Lbl);
            this.Controls.Add(this.destinationAddress_ComboBox);
            this.Controls.Add(this.originAddress_ComboBox);
            this.Controls.Add(this.destinationAddress_Lbl);
            this.Controls.Add(this.originAddress_Lbl);
            this.Name = "AddLetterForm";
            this.Text = "Add Letter";
            this.Load += new System.EventHandler(this.AddLetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAddress_Lbl;
        private System.Windows.Forms.Label destinationAddress_Lbl;
        private System.Windows.Forms.ComboBox originAddress_ComboBox;
        private System.Windows.Forms.ComboBox destinationAddress_ComboBox;
        private System.Windows.Forms.Label fixedCost_Lbl;
        private System.Windows.Forms.TextBox fixedCost_Txt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button addLetter_Btn;
    }
}