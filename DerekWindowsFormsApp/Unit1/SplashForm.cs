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
    /// <summary>
    /// Task 1.6
    /// This shows an image to introduce an application
    /// Author: Derek
    /// </summary>
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }
    }
}
