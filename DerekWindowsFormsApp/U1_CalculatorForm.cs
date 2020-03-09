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
    public partial class U1_CalculatorForm : Form
    {
        private double number1;
        private double number2;
        private double result;

        public U1_CalculatorForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
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


        private void U1_CalculatorForm_Load(object sender, EventArgs e)
        {
            U1_SplashForm splash = new U1_SplashForm();
            splash.ShowDialog();
            System.Threading.Thread.Sleep(2000);
            splash.Close();
        }
    }
}
