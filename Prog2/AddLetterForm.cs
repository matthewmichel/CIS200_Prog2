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
    public partial class AddLetterForm : Form
    {
        Prog2Form currentForm; // This variable is the parent form of the AddLetterForm. It is set to whatever form called the AddLetterForm.

        // Pre-Condition: _currentForm must be a Prog2Form object
        // Post-Condition: A new AddLetterForm object will be created.
        public AddLetterForm(Prog2Form _currentForm)
        {
            currentForm = _currentForm;
            InitializeComponent();
        }

        // Pre-Condition: None
        // Post-Condition: Both Combo Boxes will contain all Address elements in the AddressList.
        private void AddLetterForm_Load(object sender, EventArgs e)
        {
            List<string> originAddressNames = new List<string>();
            List<string> destinationAddressNames = new List<string>();
            foreach(Address addr in currentForm.upvController.AddressList)
            {
                originAddressNames.Add(addr.Name);
                destinationAddressNames.Add(addr.Name);
            }

            originAddress_ComboBox.DataSource = originAddressNames;
            destinationAddress_ComboBox.DataSource = destinationAddressNames;
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's Text property is an empty string.
        //      Error will go away once the Text property contains some sort of text.
        private void OriginAddress_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox originAddressBox = sender as ComboBox;
            if (originAddressBox.Text == String.Empty)
            {
                errorProvider1.SetError(originAddressBox, "The Name field must have a value.");
            }
            else
            {
                errorProvider1.SetError(originAddressBox, "");
            }
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's Text property is an empty string.
        //      Error will go away once the Text property contains some sort of text.
        private void DestinationAddress_ComboBox_Validating(object sender, CancelEventArgs e)
        {
            ComboBox destinationAddressBox = sender as ComboBox;
            if (destinationAddressBox.Text == String.Empty)
            {
                errorProvider1.SetError(destinationAddressBox, "The Name field must have a value.");
            }
            else
            {
                errorProvider1.SetError(destinationAddressBox, "");
            }
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's input is negative or not a decimal.
        //      Error will go away once the Text property contains some sort of non-negative decimal.
        private void FixedCost_Txt_Validating(object sender, CancelEventArgs e)
        {
            decimal cost;
            try
            {
                cost = decimal.Parse(fixedCost_Txt.Text);
                errorProvider1.SetError(fixedCost_Txt, "");
                if (cost < 0)
                {
                    errorProvider1.SetError(fixedCost_Txt, "A valid, non-negative integer must be entered.");
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(fixedCost_Txt, "A valid, non-negative integer must be entered.");
            }
        }

        // Pre-Condition: All fields on the form must contain proper input
        // Post-Condition: A new Letter object will be created with the given input, and it will be added to the ParcelList.
        private void AddLetter_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                originAddress_ComboBox.Focus();
                destinationAddress_ComboBox.Focus();
                fixedCost_Txt.Focus();
                addLetter_Btn.Focus();

                int originAddressIndex = originAddress_ComboBox.SelectedIndex;
                int destinatinoAddressIndex = destinationAddress_ComboBox.SelectedIndex;

                currentForm.upvController.AddLetter(currentForm.upvController.AddressList.ElementAt(originAddressIndex), currentForm.upvController.AddressList.ElementAt(destinatinoAddressIndex), decimal.Parse(fixedCost_Txt.Text));

                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
