// Program 2
// CIS 200-01
// Fall 2019
// Due: 21/20/2019
// By: M1752

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {

        public UserParcelView upvController = new UserParcelView(); // The UserParcelView object to be used throughout the program.

        // Pre-Condition: None
        // Post-Condition: A new Prog2Form object is created.
        //          Three test addresses are created. Three test letters are created.
        public Prog2Form()
        {
            InitializeComponent();
            upvController.AddAddress("test address 1", "123 random st.", "somewhere", "KS", 12345);
            upvController.AddAddress("test address 2", "456 this ave.", "polis", "KY", 67891);
            upvController.AddAddress("test address 3", "789 park pl.", "acity", "NY", 49832);
            upvController.AddLetter(upvController.AddressList[0], upvController.AddressList[1], 3.12M);
            upvController.AddLetter(upvController.AddressList[2], upvController.AddressList[1], 1.57M);
            upvController.AddLetter(upvController.AddressList[2], upvController.AddressList[0], 2.23M);
        }

        // Pre-Condition: None
        // Post-Condition: A new AboutForm Windows Form will be created and shown.
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

        }

        // Pre-Condition: None
        // Post-Condition: The application will end.
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Pre-Condition: None
        // Post-Condition: A new AddAddressForm will be created and shown.
        private void AddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm(this);
            addAddressForm.Show();
        }

        // Pre-Condition: None
        // Post-Condition: A new AddLetterForm will be created and shown.
        private void LetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLetterForm addLetterForm = new AddLetterForm(this);
            addLetterForm.Show();
        }

        // Pre-Condition: None
        // Post-Condition: The report_Txt textbox will show a list of Addresses. It will also clear the value from the totalCostAmount_Lbl label.
        private void ListAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            totalCostAmount_Lbl.Text = "";
            string addressListString = "";

            foreach(Address addr in upvController.AddressList)
            {
                addressListString += addr + "\n";
            }

            report_Txt.Text = addressListString;
        }

        // Pre-Condition: None
        // Post-Condition: The report_Txt textbox will show a list of Parcels. It will also show the total cost in the totalCostAmount_Lbl label.
        private void ListParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;
            string letterListString = "";

            foreach(Letter ltr in upvController.ParcelList)
            {
                letterListString += ltr + "\n";
                totalCost += ltr.CalcCost();
            }

            report_Txt.Text = letterListString;
            totalCostAmount_Lbl.Text = totalCost.ToString("C2");
        }
    }
}
