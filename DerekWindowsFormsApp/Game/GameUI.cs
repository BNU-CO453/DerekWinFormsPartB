using System;
using System.Drawing;
using System.Windows.Forms;

namespace DerekWindowsFormsApp.Game
{
    /// <summary>
    /// This class forms a user interface for the 
    /// Rock-Paper-Scissors Game
    /// Author: Derek Peacock
    /// </summary>
    public partial class GameUI : Form
    {
        public GameUI()
        {
            InitializeComponent();
            RPS_Game.Start();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Close();
        }

        private void loadRockImage(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Rock.jpg");
        }

        private void loadPaperImage(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Paper.jpg");
        }

        private void loadScissorsImage(object sender, EventArgs e)
        {
            userPictureBox.Image = Image.FromFile("Scissors.jpg");
        }

        private void getPlayerChoice(object sender, EventArgs e)
        {

            if (rockRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.STONE;
            }
            else if (paperRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.PAPER;
            }
            else if(scissorsRadioButton.Checked)
            {
                RPS_Game.PlayerChoice = RPS_Game.SCISSORS;
            }

            if (!choiceMade())
            {
                MessageBox.Show("Please make a selection!");
            }
            else
            {
                getComputerChoice();
            }

        }

        private void clear()
        {
            paperRadioButton.Checked = false;
            scissorsRadioButton.Checked = false;
            rockRadioButton.Checked = false;
        }

        private bool choiceMade()
        {
            return (paperRadioButton.Checked || 
                    scissorsRadioButton.Checked || 
                    rockRadioButton.Checked);
        }

        private void getComputerChoice()
        {
            RPS_Game.GetComputerChoice();

            if (RPS_Game.ComputerChoice == RPS_Game.PAPER)
                computerPictureBox.Image = Image.FromFile("Paper.jpg");

            else if (RPS_Game.ComputerChoice == RPS_Game.STONE)
                computerPictureBox.Image = Image.FromFile("Rock.jpg");

            else if (RPS_Game.ComputerChoice == RPS_Game.SCISSORS)
                computerPictureBox.Image = Image.FromFile("Scissors.jpg");

            RPS_Game.WorkoutWinner();
            showWinner();
        }

        private void showWinner()
        {
            string message = "You chose " + RPS_Game.PlayerChoice;
            message = message + "\nComputer Chose " + RPS_Game.ComputerChoice;

            message = message + "\n\n The Winner is " + RPS_Game.Winner;
            
            messageLabel.Text = message;
            
            clear();
        }
    }
}
