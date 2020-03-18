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
    /// Task 3.5
    /// This form moves a monkey image around and displays a message when
    /// the monkey image is clicked
    /// Author: Derek
    /// </summary>
    public partial class MonkeyBash : Form
    {
        private int x, y;
        private int hits, misses;
        private Random generator = new Random();

        public MonkeyBash()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ouch!");
            hits++;
        }

        private void startTimer(object sender, EventArgs e)
        {
            animationTimer.Enabled = true;
            hits = 0; misses = 0;
        }

        private void stopTimer(object sender, EventArgs e)
        {
            animationTimer.Enabled = false;
        }

        private void MonkeyBash_MouseDown(object sender, MouseEventArgs e)
        {
            messageLabel.Text = "(" + e.X + "," + e.Y + ")";
        }

        private void gamePanel_Click(object sender, EventArgs e)
        {
            misses++;
        }

        private void MonkeyBash_Click(object sender, EventArgs e)
        {
            misses++;
        }

        private void moveMonkey(object sender, EventArgs e)
        {
            x = generator.Next(gamePanel.Width - imagePictureBox.Width);
            y = generator.Next(gamePanel.Height - imagePictureBox.Height);

            imagePictureBox.Left = x;
            imagePictureBox.Top = y;

            hitsLabel.Text = "Hits = " + hits + " Misses = " + misses;

            Refresh();
        }
    }
}
