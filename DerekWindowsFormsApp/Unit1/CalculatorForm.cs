using System;
using System.Windows.Forms;

namespace DerekWindowsFormsApp
{
    /// <summary>
    /// Task 1.5
    /// This form offers simple arithmetic operations between two numbers
    /// Author: Derek
    /// </summary>
    public partial class CalculatorForm : Form
    {
        private double number1;
        private double number2;
        private double result;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void closeForm(object sender, EventArgs e)
        {
            Close();
        }

        private void Calculate(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            getNumbers();

            switch (button.Tag)
            {
                case "+":
                    result = number1 + number2;
                    break;
                
                case "-":
                    result = number1 - number2;
                    break;

                case "*":
                    result = number1 * number2;
                    break;

                case "/":
                    
                    if(number2 == 0)
                        MessageBox.Show("You cannot divide by 0!!!");
                    else 
                        result = number1 / number2;
                    
                    break;

                default:
                    break;
            }

            showResult();
        }

        private void getNumbers()
        {
            number1 = Convert.ToDouble(firstNumberTextBox.Text);
            number2 = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void showResult()
        {
            resultTextBox.Text = result.ToString();
        }


        private void showSplashForm(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splash.Close();
        }
    }
}
