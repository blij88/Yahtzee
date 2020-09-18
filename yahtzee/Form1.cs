using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yahtzee
{
    /*  roll dice [v]
     *  display dice [v]
        select Dice []
        check amount of rolls []
        reroll selected Dice []
        assign dice to "block" []
        select relevant dice for a block[]
        calculate score []
        reset game []
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        List<Button> allDice = new List<Button>();
        List<int> diceValues = new List<int>();
        int totalScore = 0;
        //adding the hidden buttons to a list so I can easily connect them to a single roll
        private void Form1_Load(object sender, EventArgs e)
        {
            allDice.Add(button1);
            allDice.Add(button2);
            allDice.Add(button3);
            allDice.Add(button4);
            allDice.Add(button5);

        }
        private void rollDice_Click(object sender, EventArgs e)
        {
            diceValues.Clear();
            foreach (var item in allDice)
            {
                int roll = Dice();
                allDice[allDice.IndexOf(item)].Text = roll.ToString();
                diceValues.Add(roll);
                allDice[allDice.IndexOf(item)].Visible = true;
            }
        }
// the random generator
        public int Dice()
        {

            int newRoll = rand.Next(1, 7);
            return newRoll;
         }
// transfer dice values to the different blocks
        public void setValues(TextBox chosen)
        {
            foreach (var item in diceValues)
            {
                
                chosen.Text += item +",";
                chosen.Enabled = false;
            }
        }
        // score calculation for left column
        public void scoreOfLeftColumn(TextBox chosen, int numberType)
        {
            int score = 0;
            foreach (var item in diceValues)
            {
                if (item == numberType)
                {
                    score += numberType;
                }
            }
            chosen.Text += "    score: " + score;
            totalScore += score;
        }
// score for the three and four of a kind
        public void ofAKind(TextBox chosen, int howMany)
        {

            int score = 0;
            for (int i = 1; i < 7; i++)
            {   
                int thisMany = 0;
                foreach (var item in diceValues)
                {
    
                    if (i == item)
                    {
                        thisMany += 1;
                        Console.WriteLine(thisMany.ToString() + "," + item);
                    }
                }
                if (thisMany >= howMany)
                {
                    foreach (var item in diceValues)
                    {
                        score += item;
                    }
                    break;
                }
            }
            chosen.Text += "    score: " + score;

        }
// score for yahtzee
        public void Yahtzee(TextBox chosen)
        {

            int score = 0;
            for (int i = 1; i < 7; i++)
            {
                int thisMany = 0;
                foreach (var item in diceValues)
                {

                    if (i == item)
                    {
                        thisMany += 1;
                        Console.WriteLine(thisMany.ToString() + "," + item);
                    }
                }
                if (thisMany >= 6)
                {
                    foreach (var item in diceValues)
                    {
                        score = 50;
                    }
                    break;
                }
            }
            chosen.Text += "    score: " + score;
       }

// score for straights
        public void isStraight()
        {
            int score = 0;
            if (diceValues.Contains(3) && diceValues.Contains(4))
            {
                if (diceValues.Contains(2))
                {
                    if (diceValues.Contains(1) || diceValues.Contains(5))
                    {
                        score = 30;
                    }
                }
                else if (diceValues.Contains(5) && diceValues.Contains(6))
                {
                    score = 30;
                }
            }
            boxStraight.Text += "   score: " + score;
        }
        // score for straight flush
        public void isStraightFlush()
        {
            int score = 0;
            if (diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5))
            {
                if (diceValues.Contains(1) || diceValues.Contains(6))
                {
                    score = 40;
                }
            }
            boxStraighFlush.Text += "   score: " + score;
        }

        // score for full house


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // the click events for the different boxes

        private void boxOnes_Click(object sender, EventArgs e)
        {
            setValues(boxOnes);
            scoreOfLeftColumn(boxOnes, 1);
        }


        private void boxTwos_Click(object sender, EventArgs e)
        {
            setValues(boxTwos);
            scoreOfLeftColumn(boxTwos, 2);
        }

        private void s_Click(object sender, EventArgs e)
        {
            setValues(s);
            scoreOfLeftColumn(s, 3);
        }

        private void boxFours_Click(object sender, EventArgs e)
        {
            setValues(boxFours);
            scoreOfLeftColumn(boxFours, 4);
        }
        private void boxFives_Click(object sender, EventArgs e)
        {
            setValues(boxFives);
            scoreOfLeftColumn(boxFives, 5);
        }

        private void boxSixes_Click(object sender, EventArgs e)
        {
            setValues(boxSixes);
            scoreOfLeftColumn(boxSixes, 6);
        }
 
        private void boxThreeEqual_Click_1(object sender, EventArgs e)
        {
            setValues(boxThreeEqual);
            ofAKind(boxThreeEqual, 3);
        }

        private void boxFourEqual_Click(object sender, EventArgs e)
        {
            setValues(boxFourEqual);
            ofAKind(boxFourEqual, 4);
        }

        private void boxStraight_Click(object sender, EventArgs e)
        {
            setValues(boxStraight);
            isStraight();
        }

        private void boxStraighFlush_Click(object sender, EventArgs e)
        {
            setValues(boxStraighFlush);
            isStraightFlush();
        }

        private void boxFullHouse_Click(object sender, EventArgs e)
        {
            setValues(boxFullHouse);
        }

        private void boxChance_Click(object sender, EventArgs e)
        {
            setValues(boxChance);
        }

        private void boxYahtzee_Click(object sender, EventArgs e)
        {
            setValues(boxYahtzee);
            Yahtzee(boxYahtzee);
        }


    }

}
