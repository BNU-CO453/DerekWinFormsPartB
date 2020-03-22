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

            results.Show();
        }
    }
}
