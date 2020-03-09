using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekWindowsFormsApp
{
    public partial class U1_DataEntryForm : Form
    {
        public U1_DataEntryForm()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameTextBox.Text + " " +
                lastNameTextBox.Text + "\nHappy Programming";

            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
