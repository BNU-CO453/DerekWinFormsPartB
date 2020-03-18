using System;
using System.Windows.Forms;

namespace DerekWindowsFormsApp
{
    /// <summary>
    /// Tasks 1.1 - 1.3
    /// Shows a welcome message and which is the best computer
    /// and best software
    /// Author: Derek
    /// </summary>
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void exitForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowBestComputer(object sender, EventArgs e)
        {
            bragLabel.Text = "Super Dupa Computer\nSelling for £456";
        }

        private void showBestSoftware(object sender, EventArgs e)
        {
            bragLabel.Text = "C# .NET Step by Step\nBargain @ £29.95";
        }
    }
}
