using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //random generator
        Random randGen = new Random();

        //variable for the computer's number
        int cpuNumber;

        public Form1()
        {
            InitializeComponent();
            cpuNumber = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int playerGuess = Convert.ToInt32(numberInput.Text);

            if (cpuNumber == playerGuess)
            {
                outputLabel.Text = "You got it!";
            }
            else if (cpuNumber > playerGuess)
            {
                outputLabel.Text = "Too low!";
            }
            else if (cpuNumber < playerGuess)
            {
                outputLabel.Text = "Too high!";
            }
        }
    }
}
