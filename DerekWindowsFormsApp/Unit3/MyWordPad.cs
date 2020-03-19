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
    /// Task 3.7 - 3.10
    /// This form uses a rich text box to provide the main functions
    /// of a simple word pad.
    /// Author: Derek
    /// </summary>
    public partial class MyWordPad : Form
    {
        private string fileName = "Document1.rtf";

        public MyWordPad()
        {
            InitializeComponent();
        }

        private void setBackColour(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            mainRichTextBox.BackColor = colorDialog1.Color;
        }
    }
}
