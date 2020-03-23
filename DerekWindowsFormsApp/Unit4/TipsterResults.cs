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
    public partial class TipsterResults : Form
    {
        private decimal billTotal, tip, perPerson;

        private int noPeople;

        public TipsterResults()
        {
            InitializeComponent();
        }

        public void calculateBill()
        {
            try
            {
                billTotal = Convert.ToDecimal(billTextBox.Text);
                noPeople = Convert.ToInt32(peopleTextBox.Text);
                perPerson = billTotal / noPeople;
                personTextBox.Text = perPerson.ToString("£0.00");
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid number!");
            };   
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
