using System;
using System.Windows.Forms;

namespace DerekWindowsFormsApp.Unit3
{
    public partial class PoshNoshForm : Form
    {
        private decimal startCost, mainCost, totalCost;

        private string[] starters = new string[]
        {
            "Lobster Ravioli",
            "Isle of Skye Scallops",
            "Gerome Galis Asparagus",
            "Veal Sweetbread",
            "Pressed foie gras"
        };

        private decimal[] starterPrices = new decimal[]
        {
            24.50m,
            18.95m,
            20.40m,
            15.60m,
            28.50m
        };

        public PoshNoshForm()
        {
            InitializeComponent();
            starterListBox.Items.AddRange(starters);
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void selectStarter(object sender, EventArgs e)
        {
            int index = starterListBox.SelectedIndex;
            startCost = starterPrices[index];
            displayCost();
        }

        private void displayCost()
        {
            costLabel.Text = startCost.ToString("0.00");
        }
    }
}
