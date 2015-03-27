//This can be done way better/cleaner

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCalculator
{
    public partial class MainDisplay : Form
    {
        double firstFunctionNumber;
        double secondFunctionNumber;
        string selectedMathOperation;
        Boolean mathOperationPerformed = false;
        double memStoredNumber;

        public MainDisplay()
        {
            InitializeComponent();
        }

        private void MainDisplay_Load(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void addNumberToDisplay(String number)
        {
            if (mathOperationPerformed)
            {
                mathOperationPerformed = false;

                Display.Text = number;
            }
            else
            {
                if (Display.Text == "0")
                    Display.Text = number;
                else if (Display.Text == "+" || Display.Text == "-" || Display.Text == "x" || Display.Text == "/")
                    Display.Text = number;
                else
                    Display.Text += number;
            }
        }

        private void mathOperation(String operation)
        {
            if (Display.Text == "+" || Display.Text == "-" || Display.Text == "x" || Display.Text == "/")
            {
                selectedMathOperation = operation;
                Display.Text = operation;
            }
            else
            {
                firstFunctionNumber = Double.Parse(Display.Text);
                selectedMathOperation = operation;
                Display.Text = operation;
            }
        }

        private void performMathOperation(double firstNumber, double secondNumber, string operation)
        {
            double operationResult;

            if(operation == "+")
            {
                operationResult = firstNumber + secondNumber;
                Display.Text = operationResult.ToString();
            }
            else if(operation == "-")
            {
                operationResult = firstNumber - secondNumber;
                Display.Text = operationResult.ToString();
            }
            else if(operation == "x")
            {
                operationResult = firstNumber * secondNumber;
                Display.Text = operationResult.ToString();
            }
            else if(operation == "/")
            {
                operationResult = firstNumber / secondNumber;
                Display.Text = operationResult.ToString();
            }

            mathOperationPerformed = true;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (Display.Text != "0")
                Display.Text += "0";
        }

        private void numberOneButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("1");
        }

        private void numberTwoButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("2");
        }

        private void numberThreeButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("3");
        }

        private void numberFourButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("4");
        }

        private void numberFiveButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("5");
        }

        private void numberSixButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("6");
        }

        private void numberSevenButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("7");
        }

        private void numberEigthButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("8");
        }

        private void numberNineButton_Click(object sender, EventArgs e)
        {
            addNumberToDisplay("9");
        }

        private void positiveNegativeButton_Click(object sender, EventArgs e)
        {
            double textBoxNumber = Double.Parse(Display.Text);

            textBoxNumber = -(textBoxNumber);
            Display.Text = textBoxNumber.ToString();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (Display.Text.Contains("."))
                SystemSounds.Asterisk.Play();
            else
                Display.Text += ".";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            mathOperation("+");
        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            mathOperation("-");
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            mathOperation("x");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            mathOperation("/");
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "+" || Display.Text == "-" || Display.Text == "x" || Display.Text == "/")
                SystemSounds.Asterisk.Play();
            else
            {
                secondFunctionNumber = Double.Parse(Display.Text);

                performMathOperation(firstFunctionNumber, secondFunctionNumber, selectedMathOperation);
            }
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            if (Display.Text == "+" || Display.Text == "-" || Display.Text == "x" || Display.Text == "/")
                SystemSounds.Asterisk.Play();
            else
                Display.Text = "0";
        }

        private void allClearButton_Click(object sender, EventArgs e)
        {
            firstFunctionNumber = 0;
            secondFunctionNumber = 0;
            selectedMathOperation = null;
            memStoredNumber = 0;
            memStoreButton.BackColor = System.Drawing.SystemColors.Control;
            Display.Text = "0";
        }

        private void memStoreButton_Click(object sender, EventArgs e)
        {
            memStoredNumber = Double.Parse(Display.Text);

            memStoreButton.BackColor = System.Drawing.SystemColors.Highlight;
        }

        private void memRecoverButton_Click(object sender, EventArgs e)
        {
            Display.Text = memStoredNumber.ToString();
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double number = Math.Sqrt(Double.Parse(Display.Text));

            Display.Text = number.ToString();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            double number = Math.Pow(Double.Parse(Display.Text), 2);

            Display.Text = number.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
                System.Windows.Forms.Application.Exit();
            else
                System.Environment.Exit(1);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            double number = (Double.Parse(Display.Text)) * .01;
            Display.Text = number.ToString();
        }

        private void oneOverXButton_Click(object sender, EventArgs e)
        {
            double number = 1 / (Double.Parse(Display.Text));

            Display.Text = number.ToString();
        }

        private void piValueButton_Click(object sender, EventArgs e)
        {
            Display.Text = Math.PI.ToString();
        }
    }
}
