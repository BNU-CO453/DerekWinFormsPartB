using System;

namespace DerekWindowsFormsApp.Game
{
    public enum Players
    {
        COMPUTER,
        PLAYER
    }

    /// <summary>
    /// This class plays ...
    /// Author: 
    /// Started: 12/02/2019
    /// </summary>
    public static class RPS_Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";

        public static string PlayerName { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerChoice { get; set; }
        public static string PlayerChoice { get; set; }
        public static string Winner { get; set; }

        public static int PlayerScore { get; set; }
        public static int ComputerScore { get; set; }

        private static Random randomGenerator = new Random();

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void Start()
        {
            PlayerScore = 0;
            ComputerScore = 0;

            PlayerName = "Derek";
            ComputerName = "Computer";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void End()
        {
            if (PlayerScore > ComputerScore)
                Winner = PlayerName;
            else if (PlayerScore < ComputerScore)
                Winner = ComputerName;
            else
                Winner = "IT IS A DRAW";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);  

            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else if(choice == 1)
            {
                ComputerChoice = PAPER;
            }
            else if(choice == 2)
            {
                ComputerChoice = STONE;
            }
        }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "No Winner";
            }
            else if ((PlayerChoice == STONE && ComputerChoice == PAPER) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == STONE) ||
                    (PlayerChoice == PAPER && ComputerChoice == SCISSORS))
            {
                Winner = ComputerName;
                ComputerScore++;
            }
            else if ((PlayerChoice == STONE && ComputerChoice == SCISSORS) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == PAPER) ||
                    (PlayerChoice == PAPER && ComputerChoice == STONE))
            {
                Winner = PlayerName;
                PlayerScore++;
            }
        }
    }
}
