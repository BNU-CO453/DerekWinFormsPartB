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
    public partial class U1_WelcomeForm : Form
    {
        public U1_WelcomeForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void computerButton_Click(object sender, EventArgs e)
        {
            bragLabel.Text = "Super Dupa Computer\nSelling for £456";
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            bragLabel.Text = "C# .NET Step by Step\nBargain @ £29.95";
        }
    }
}
