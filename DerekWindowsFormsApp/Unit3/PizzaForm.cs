using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekWindowsFormsApp.Unit3
{
    /// <summary>
    /// Task 3.2
    /// This class..
    /// Derek
    /// </summary>
    public partial class PizzaForm : Form
    {
        public const decimal LARGE_COST = 12.00m;
        public const decimal MEDIUM_COST = 8.00m;
        public const decimal SMALL_COST = 6.00m;

        public const decimal TOPPING_COST = 2.50m;

        private decimal baseCost = 0;
        private decimal toppingCost = 0;
        private decimal totalCost = 0;

        public PizzaForm()
        {
            InitializeComponent();
            calculateBaseCost(null, null);
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This method is called when a radio button is clicked
        /// </summary>
        private void calculateBaseCost(object sender, EventArgs e)
        {
            baseCost = 0;

            if(largeRadioButton.Checked)
            {
                baseCost = LARGE_COST;
            }
            else if(mediumRadioButton.Checked)
            {
                baseCost = MEDIUM_COST;
            }
            else if (smallRadioButton.Checked)
            {
                baseCost = SMALL_COST;
            }

            displayCost();
        }


        private void calculateToppingCost(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;  // Type Cast

            if(box.Checked)
            {
                toppingCost = toppingCost + TOPPING_COST;
            }
            else
            {
                toppingCost = toppingCost - TOPPING_COST;
            }

            displayCost();
        }

        private void displayCost()
        {
            totalCost = toppingCost + baseCost;
            costLabel.Text = totalCost.ToString("£0.00");
        }
    }
}
