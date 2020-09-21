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
        assign dice to "block" [v]
        select relevant dice for a block[v]
        calculate score [v]
        reset game []
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // this is stuff that is at least easier to initialize outside of the eventlisteners and methods, I feel like this is not the way to do this but here we are

        // the random used for all rolls
        Random rand = new Random();

        // these lists are for the buttons that represent the different dice and textboxes
        List<Button> allDice = new List<Button>();
        List<TextBox> allboxes = new List<TextBox>();
        // this keeps the values for a single set of rolls
        List<int> diceValues = new List<int>();
        // totals score for easy addition
        int totalScore = 0;
        // keeping track of amount of blocks that have been filled
        int amountFilled = 0;
        // how often we are allowed to roll for this block
        int rerollsLeft = 3;
        
        //adding the hidden buttons to a list so I can easily connect them to a single roll
        private void Form1_Load(object sender, EventArgs e)
        {
            allboxes.Add(boxOnes);
            allboxes.Add(boxTwos);
            allboxes.Add(s);
            allboxes.Add(boxFours);
            allboxes.Add(boxFives);
            allboxes.Add(boxSixes);
            allboxes.Add(boxThreeEqual);
            allboxes.Add(boxFourEqual);
            allboxes.Add(boxStraight);
            allboxes.Add(boxStraighFlush);
            allboxes.Add(boxFullHouse);
            allboxes.Add(boxChance);
            allboxes.Add(boxYahtzee);
            foreach (var item in allboxes)
            {
                item.Enabled = false;
            }
            addAllButtons();
            diceValues.Add(0);
            diceValues.Add(0);
            diceValues.Add(0);
            diceValues.Add(0);
            diceValues.Add(0);
            foreach (var item in allDice)
            {
                item.Enabled = false;
            }
        }
        // all textboxes and buttons are disabled until a roll has taken place atleast once per block
        
        // when the roll is clicked the list with the values of the previous rolls is cleared, dice are rolled and added to the GUI and the diceValues string
        private void rollDice_Click(object sender, EventArgs e)
        {
            if (rerollsLeft > 0)
            {
                diceValues.Clear();
                foreach (var item in allDice)
                {
                    int roll = Dice();
                    allDice[allDice.IndexOf(item)].Text = roll.ToString();
                    item.Visible = true;
                }
                addAllButtons();
                foreach (var item in allDice)
                {
                    diceValues.Add(Int32.Parse(item.Text));
                }
                if (rerollsLeft == 3)
                {
                    foreach (var item in allboxes)
                    {
                        item.Enabled = true;
                    }
                    foreach (var item in allDice)
                    {
                        item.Enabled = true;
                    }
                }
                allDice.Clear();
                rerollsLeft += -1;
                
            }
            else
            {
                rerollsLeft = 0;
            }
            label15.Text = "rolls: " + rerollsLeft;
        }
// the random generator
        public int Dice()
        {

            int newRoll = rand.Next(1, 7);
            return newRoll;
         }
// transfer dice values to the different blocks
        public void setValues(TextBox chosen, int score)
        {
            chosen.Text = ($"{diceValues[0]}, {diceValues[1]}, {diceValues[2]}, {diceValues[3]}, {diceValues[4]}|  Score: {score}");
            resettings();
            allboxes.Remove(chosen);
            amountFilled += 1;
            if (amountFilled == 13)
            {
                label14.Text = "total: " + totalScore;
                label14.Visible = true;
                reset.Enabled = true;
                reset.Visible = true;
            }

        }
// method that returns an array with frequencys of the different sides

        public int[] getFrequencies()
        {
            int[] frequencies = new int[6];
            int pos = 0;

            for (int i = 1; i < 7; i++)
            {
                int freq = 0;
                foreach (var item in diceValues)
                {
                    if (item == i)
                    {
                        freq += 1;
                    }
                }
                frequencies[pos] = freq;
                pos += 1;
            }
            return frequencies;
        }
// method that calculates the score for a valid three or four of a kind block
        private int ofAScore()
        {
            int score = 0;
            foreach (var item in diceValues)
            {
                score += item;
            }
            return score;
        }

        // upon textbox click a bunch of stuff is reset
        public void resettings()
        {
            rerollsLeft = 3;
            label15.Text = "rolls: 3";
            foreach (var item in allDice)
            {
                item.Enabled = false;
                item.Visible = false;
            }
            foreach (var item in allboxes)
            {
                item.Enabled = false;
            }
        }
// score calculation for left column
        public int scoreOfLeftColumn(int numberType)
        {
            addAllButtons();
            int score = 0;
            foreach (var item in diceValues)
            {
                if (item == numberType)
                {
                    score += numberType;
                }
            }
            totalScore += score;
            return score;
        }
// score for the three and four of a kind, references getFrequencies and ofAScore
        public int ofAKind(int howMany)
        {
            addAllButtons();
            int score = 0;
            int[] frequencies = getFrequencies();
            Array.Sort(frequencies);
            if (frequencies[5] >= howMany)
            {
                if (howMany == 5)
                {
                    score = 50;
                }
                else
                {
                    score = ofAScore();
                }
            }
            totalScore += score;
            return score;
        }


// score for straights
        public int isStraight()
        {
            addAllButtons();
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
            totalScore += score;
            return score;
        }
        // score for straight flush
        public int isStraightFlush()
        {
            addAllButtons();
            int score = 0;
            if (diceValues.Contains(2) && diceValues.Contains(3) && diceValues.Contains(4) && diceValues.Contains(5))
            {
                if (diceValues.Contains(1) || diceValues.Contains(6))
                {
                    score = 40;
                }
            }
            totalScore += score;
            return score;
        }

        // score for full house

        public int isFullHouse()
        {
            addAllButtons();
            int score = 0;
            int[] frequencies = getFrequencies();
            if ((frequencies.Contains(3) && frequencies.Contains(2)) || (frequencies.Contains(5) && boxYahtzee.Visible == false))
            {
                score = 25;
            }
            totalScore += score;
            return score;
        }
        // score for chance
        public int scoreChance()
        {
            addAllButtons();
            int score = 0;
            foreach (var item in diceValues)
            {
                score += item;
            }
            totalScore += score;
            return score;
        }


        // the click events for the different boxes

        private void boxOnes_Click(object sender, EventArgs e)
        {
            int score =  scoreOfLeftColumn(1);
            setValues(boxOnes,score);
        }


        private void boxTwos_Click(object sender, EventArgs e)
        {
            int score = scoreOfLeftColumn(2);
            setValues(boxTwos, score);
        }

        private void s_Click(object sender, EventArgs e)
        {
            int score = scoreOfLeftColumn(3);
            setValues(s, score);
        }

        private void boxFours_Click(object sender, EventArgs e)
        {
            int score = scoreOfLeftColumn(4);
            setValues(boxFours, score);
        }
        private void boxFives_Click(object sender, EventArgs e)
        {
            int score = scoreOfLeftColumn(5);
            setValues(boxFives, score);
        }

        private void boxSixes_Click(object sender, EventArgs e)
        {
            int score = scoreOfLeftColumn(6);
            setValues(boxSixes, score);
        }
 
        private void boxThreeEqual_Click_1(object sender, EventArgs e)
        {
            int score = ofAKind(3);
            setValues(boxThreeEqual, score);
        }

        private void boxFourEqual_Click(object sender, EventArgs e)
        {
            int score = ofAKind(4);
            setValues(boxFourEqual, score);
        }

        private void boxStraight_Click(object sender, EventArgs e)
        {
            int score = isStraight();
            setValues(boxStraight, score);
        }

        private void boxStraighFlush_Click(object sender, EventArgs e)
        {
            int score = isStraightFlush();
            setValues(boxStraighFlush, score);
        }

        private void boxFullHouse_Click(object sender, EventArgs e)
        {
            int score = isFullHouse();
            setValues(boxFullHouse, score);
        }

        private void boxChance_Click(object sender, EventArgs e)
        {
            int score = scoreChance();
            setValues(boxChance, score);
        }

        private void boxYahtzee_Click(object sender, EventArgs e)
        {
            int score = ofAKind(5);
            setValues(boxYahtzee, score);
        }

        // adding all buttons when at the start of a new set of rerolls

        public void addAllButtons()
        {
            allDice.Clear();
            allDice.Add(button1);
            allDice.Add(button2);
            allDice.Add(button3);
            allDice.Add(button4);
            allDice.Add(button5);
            foreach (var item in allDice)
            {
                item.BackColor = Color.Black;
                item.ForeColor = Color.White;
            }
        }
        //
        public void selectAndDeselect(Button chosen)
        {
            if (allDice.Contains(chosen))
            {
                allDice.Remove(chosen);
                chosen.BackColor = Color.Black;
                chosen.ForeColor = Color.White;
            }
            else
            {
                allDice.Add(chosen);
                chosen.BackColor = Color.White;
                chosen.ForeColor = Color.Black;
            }

        }
        // eventisteners to add and remove dice from reroll list
        private void button1_Click(object sender, EventArgs e)
        {
            selectAndDeselect(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectAndDeselect(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectAndDeselect(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectAndDeselect(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectAndDeselect(button5);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            allboxes.Add(boxOnes);
            allboxes.Add(boxTwos);
            allboxes.Add(s);
            allboxes.Add(boxFours);
            allboxes.Add(boxFives);
            allboxes.Add(boxSixes);
            allboxes.Add(boxThreeEqual);
            allboxes.Add(boxFourEqual);
            allboxes.Add(boxStraight);
            allboxes.Add(boxStraighFlush);
            allboxes.Add(boxFullHouse);
            allboxes.Add(boxChance);
            allboxes.Add(boxYahtzee);
            resettings();
            foreach (var item in allboxes)
            {
                item.Text = "";
            }
            amountFilled = 0;
            label14.Text = "";
            label14.Visible = false;
            reset.Visible = false;
            reset.Enabled = false;
            totalScore = 0;
        }
    }

}
