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
    public partial class AddAddressForm : Form
    {
        Prog2Form initialForm; // This variable is the parent form of the AddAddressForm. It is set to whatever form called the AddAddressForm.

        // Pre-Condition: _initialForm must be a Prog2Form object
        // Post-Condition: A new AddAddressForm object will be created.
        public AddAddressForm(Prog2Form _initialForm)
        {
            initialForm = _initialForm;
            InitializeComponent();
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's Text property is an empty string.
        //      Error will go away once the Text property contains some sort of text.
        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox sentTextBox = sender as TextBox;
            if(sentTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(sentTextBox, "The Name field must have a value.");
            }
            else
            {
                errorProvider1.SetError(sentTextBox, "");
            }
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's Text property is an empty string.
        //      Error will go away once the Text property contains some sort of text.
        private void StateSelector_Validating(object sender, CancelEventArgs e)
        {
            if (stateSelector_ComboBox.Text == String.Empty)
            {
                errorProvider1.SetError(stateSelector_ComboBox, "You must select a state.");
            }
            else
            {
                errorProvider1.SetError(stateSelector_ComboBox, "");
            }
        }

        // Pre-Condition: None
        // Post-Condition: Error Providor will show up with an error if the passed object's Text property is not a non-negative integer
        //      Error will go away once the Text property contains some sort of non-negative integer.
        private void ZipCode_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int zipCode = int.Parse(zipCode_Txt.Text);
                errorProvider1.SetError(zipCode_Txt, "");
                if (zipCode < 0)
                {
                    errorProvider1.SetError(zipCode_Txt, "You must provide a positive intiger between 0 and 999999");
                }
            }
            catch(Exception ex)
            {
                errorProvider1.SetError(zipCode_Txt, "You must provide a positive intiger between 0 and 999999");
            }
        }

        // Pre-Condition: All fields on the form must contain proper input
        // Post-Condition: A new Address object will be created with the given input, and it will be added to the AddressList.
        private void AddAddress_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                addressLine1_Txt.Focus();
                city_Txt.Focus();
                zipCode_Txt.Focus();
                stateSelector_ComboBox.Focus();
                addAddress_Btn.Focus();

                if (addressLine2_Txt.Text == String.Empty)
                {
                    initialForm.upvController.AddAddress(name_Txt.Text, addressLine1_Txt.Text, city_Txt.Text, stateSelector_ComboBox.Text, int.Parse(zipCode_Txt.Text));
                    Console.WriteLine("Address item added.");
                    this.Close();
                }
                else if (addressLine2_Txt.Text != String.Empty)
                {
                    initialForm.upvController.AddAddress(name_Txt.Text, addressLine1_Txt.Text, addressLine2_Txt.Text, city_Txt.Text, stateSelector_ComboBox.Text, int.Parse(zipCode_Txt.Text));
                    MessageBox.Show("Submitted.");
                    this.Close();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
