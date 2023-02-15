using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dice_Project
{
    public partial class Form1 : Form
    {

        int diceType = 0;
        int diceTotal;
        String resultText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void d4Button_Click(object sender, EventArgs e)
        {
            diceType = 4;
        }

        private void D6button_Click(object sender, EventArgs e)
        {
            diceType = 6;
        }

        private void D10button_Click(object sender, EventArgs e)
        {
            diceType = 10;
        }

        private void D12button_Click(object sender, EventArgs e)
        {
            diceType = 12;
        }

        private void D20button_Click(object sender, EventArgs e)
        {
            diceType = 20;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            diceTotal = 0;
            resultText = "";

            if(DiceCount.Value < 1)
            {
                DiceCount.Value = 1;
            }
            else if(DiceCount.Value > 100)
            {
                DiceCount.Value = 100;
            }

            
            if (diceType == 0)
            {
                diceType = 6;
            }


            Random diceroll = new Random();
            for (int i = 0; i < DiceCount.Value; i++)
            {
                int roll = diceroll.Next(1, diceType + 1);
                diceTotal += roll;
                resultText += roll.ToString() + "+";
            }
            ResultBox.Text = "You rolled " + DiceCount.Value.ToString() + "D" + diceType.ToString() + "! \r\n" + resultText.Remove(resultText.Length-1);
            ResultLabel.Text =  diceTotal.ToString();
        }

        private void DiceCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
