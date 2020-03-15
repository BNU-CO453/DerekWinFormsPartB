using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DerekWindowsFormsApp
{
    /// <summary>
    /// This form demonstrates simple data entry using text boxes
    /// and buttons
    /// Author: Derek
    /// </summary>
    public partial class U1_DataEntryForm : Form
    {
        public U1_DataEntryForm()
        {
            InitializeComponent();
        }

        private void showMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameTextBox.Text + " " +
                lastNameTextBox.Text + "\nHappy Programming" + 
                "\n Get to it " + firstNameTextBox.Text;

            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void clearMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void changeMessage(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
            firstNameTextBox.BackColor = Color.LightGreen;
        }
    }
}
