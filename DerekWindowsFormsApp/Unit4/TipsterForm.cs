using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerekWindowsFormsApp.Unit4
{
    public partial class TipsterForm : Form
    {
        public TipsterForm()
        {
            InitializeComponent();
        }

        private void quitApplication(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateBill(object sender, EventArgs e)
        {
            TipsterResults results = new TipsterResults();

            results.billTextBox.Text = billTextBox.Text;
            results.peopleTextBox.Text = peopleNumericUpDown.Value.ToString();

            if(noneRadioButton.Checked)
            {
                results.Tip = 0;
            }
            else if(normalRadioButton.Checked)
            {
                results.Tip = 0.10m;
            }
            else if(generousRadioButton.Checked)
            {
                results.Tip = 0.20m;
            }
            else if(madRadioButton.Checked)
            {
                results.Tip = 0.50m;
            }

            results.Show();
            results.calculateBill();
        }
    }
}
