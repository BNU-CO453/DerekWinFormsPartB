using System;
using System.Windows.Forms;

namespace DerekWindowsFormsApp.Unit3
{
    /// <summary>
    /// Tasks 3.3 and 3.4
    /// This form calculates the cost of a posh meal after the
    /// user selects their starter and their desert.
    /// Author: Derek
    /// </summary>
    public partial class PoshNoshForm : Form
    {
        private decimal startCost, mainCost, desertCost, totalCost;

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

        private string[] deserts = new string[]
        {
            "Grand Cru Chocolate",
            "Rice Pudding",
            "Tahitian Ice Cream"
        };

        private decimal[] desertPrices = new decimal[]
        {
            15.50m,
            12.40m,
            10.50m
        };

        public PoshNoshForm()
        {
            InitializeComponent();

            starterListBox.Items.AddRange(starters);
            desertComboBox.Items.AddRange(deserts);
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void selectDesert(object sender, EventArgs e)
        {
            int index = desertComboBox.SelectedIndex;
            desertCost = desertPrices[index];

            displayCost();
        }

        private void selectStarter(object sender, EventArgs e)
        {
            int index = starterListBox.SelectedIndex;
            startCost = starterPrices[index];

            displayCost();
        }

        private void displayCost()
        {
            totalCost = startCost + desertCost;
            costLabel.Text = totalCost.ToString("0.00");
        }
    }
}
