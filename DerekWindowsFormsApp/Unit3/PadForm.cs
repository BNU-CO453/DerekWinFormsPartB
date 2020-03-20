﻿using System;
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
    public partial class PadForm : Form
    {
        public PadForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void setBackgroundColour(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void cutText(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //richTextBox1.Cut();
        }

        private void pasteText(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void changeFont(object sender, EventArgs e)
        {

        }

        private void backColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color;
        }
    }
}
