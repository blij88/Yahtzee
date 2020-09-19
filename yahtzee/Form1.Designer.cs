namespace yahtzee
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rollDice = new System.Windows.Forms.Button();
            this.rolls = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.boxOnes = new System.Windows.Forms.TextBox();
            this.boxTwos = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.TextBox();
            this.boxFours = new System.Windows.Forms.TextBox();
            this.boxChance = new System.Windows.Forms.TextBox();
            this.boxFullHouse = new System.Windows.Forms.TextBox();
            this.boxStraighFlush = new System.Windows.Forms.TextBox();
            this.boxStraight = new System.Windows.Forms.TextBox();
            this.boxFourEqual = new System.Windows.Forms.TextBox();
            this.boxThreeEqual = new System.Windows.Forms.TextBox();
            this.boxSixes = new System.Windows.Forms.TextBox();
            this.boxFives = new System.Windows.Forms.TextBox();
            this.boxYahtzee = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rolls.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollDice
            // 
            this.rollDice.Location = new System.Drawing.Point(12, 374);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(152, 40);
            this.rollDice.TabIndex = 0;
            this.rollDice.Text = "roll";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // rolls
            // 
            this.rolls.Controls.Add(this.button5);
            this.rolls.Controls.Add(this.button4);
            this.rolls.Controls.Add(this.button3);
            this.rolls.Controls.Add(this.button2);
            this.rolls.Controls.Add(this.button1);
            this.rolls.Location = new System.Drawing.Point(330, 349);
            this.rolls.Name = "rolls";
            this.rolls.Size = new System.Drawing.Size(406, 89);
            this.rolls.TabIndex = 1;
            this.rolls.TabStop = false;
            this.rolls.Text = "rolls";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.ForestGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(337, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 53);
            this.button5.TabIndex = 4;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(259, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 53);
            this.button4.TabIndex = 3;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.ForestGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(182, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "6";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(104, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "6";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "6";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "3 of a kind";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "4 of a kind";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Full House";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "straight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(690, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "straight flush";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(690, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "chance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(509, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "YAHTZEE";
            // 
            // boxOnes
            // 
            this.boxOnes.Location = new System.Drawing.Point(29, 37);
            this.boxOnes.Name = "boxOnes";
            this.boxOnes.ReadOnly = true;
            this.boxOnes.Size = new System.Drawing.Size(275, 22);
            this.boxOnes.TabIndex = 15;
            this.boxOnes.Click += new System.EventHandler(this.boxOnes_Click);
            // 
            // boxTwos
            // 
            this.boxTwos.Location = new System.Drawing.Point(29, 71);
            this.boxTwos.Name = "boxTwos";
            this.boxTwos.ReadOnly = true;
            this.boxTwos.Size = new System.Drawing.Size(275, 22);
            this.boxTwos.TabIndex = 16;
            this.boxTwos.Click += new System.EventHandler(this.boxTwos_Click);
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(29, 103);
            this.s.Name = "s";
            this.s.ReadOnly = true;
            this.s.Size = new System.Drawing.Size(275, 22);
            this.s.TabIndex = 17;
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // boxFours
            // 
            this.boxFours.Location = new System.Drawing.Point(29, 140);
            this.boxFours.Name = "boxFours";
            this.boxFours.ReadOnly = true;
            this.boxFours.Size = new System.Drawing.Size(275, 22);
            this.boxFours.TabIndex = 18;
            this.boxFours.Click += new System.EventHandler(this.boxFours_Click);
            // 
            // boxChance
            // 
            this.boxChance.Location = new System.Drawing.Point(394, 208);
            this.boxChance.Name = "boxChance";
            this.boxChance.ReadOnly = true;
            this.boxChance.Size = new System.Drawing.Size(275, 22);
            this.boxChance.TabIndex = 19;
            this.boxChance.Click += new System.EventHandler(this.boxChance_Click);
            // 
            // boxFullHouse
            // 
            this.boxFullHouse.Location = new System.Drawing.Point(394, 174);
            this.boxFullHouse.Name = "boxFullHouse";
            this.boxFullHouse.ReadOnly = true;
            this.boxFullHouse.Size = new System.Drawing.Size(275, 22);
            this.boxFullHouse.TabIndex = 20;
            this.boxFullHouse.Click += new System.EventHandler(this.boxFullHouse_Click);
            // 
            // boxStraighFlush
            // 
            this.boxStraighFlush.Location = new System.Drawing.Point(394, 140);
            this.boxStraighFlush.Name = "boxStraighFlush";
            this.boxStraighFlush.ReadOnly = true;
            this.boxStraighFlush.Size = new System.Drawing.Size(275, 22);
            this.boxStraighFlush.TabIndex = 21;
            this.boxStraighFlush.Click += new System.EventHandler(this.boxStraighFlush_Click);
            // 
            // boxStraight
            // 
            this.boxStraight.Location = new System.Drawing.Point(394, 103);
            this.boxStraight.Name = "boxStraight";
            this.boxStraight.ReadOnly = true;
            this.boxStraight.Size = new System.Drawing.Size(275, 22);
            this.boxStraight.TabIndex = 22;
            this.boxStraight.Click += new System.EventHandler(this.boxStraight_Click);
            // 
            // boxFourEqual
            // 
            this.boxFourEqual.Location = new System.Drawing.Point(394, 71);
            this.boxFourEqual.Name = "boxFourEqual";
            this.boxFourEqual.ReadOnly = true;
            this.boxFourEqual.Size = new System.Drawing.Size(275, 22);
            this.boxFourEqual.TabIndex = 23;
            this.boxFourEqual.Click += new System.EventHandler(this.boxFourEqual_Click);
            // 
            // boxThreeEqual
            // 
            this.boxThreeEqual.Location = new System.Drawing.Point(394, 37);
            this.boxThreeEqual.Name = "boxThreeEqual";
            this.boxThreeEqual.ReadOnly = true;
            this.boxThreeEqual.Size = new System.Drawing.Size(275, 22);
            this.boxThreeEqual.TabIndex = 24;
            this.boxThreeEqual.Click += new System.EventHandler(this.boxThreeEqual_Click_1);
            // 
            // boxSixes
            // 
            this.boxSixes.Location = new System.Drawing.Point(29, 208);
            this.boxSixes.Name = "boxSixes";
            this.boxSixes.ReadOnly = true;
            this.boxSixes.Size = new System.Drawing.Size(275, 22);
            this.boxSixes.TabIndex = 25;
            this.boxSixes.Click += new System.EventHandler(this.boxSixes_Click);
            // 
            // boxFives
            // 
            this.boxFives.Location = new System.Drawing.Point(29, 174);
            this.boxFives.Name = "boxFives";
            this.boxFives.ReadOnly = true;
            this.boxFives.Size = new System.Drawing.Size(275, 22);
            this.boxFives.TabIndex = 26;
            this.boxFives.Click += new System.EventHandler(this.boxFives_Click);
            // 
            // boxYahtzee
            // 
            this.boxYahtzee.Location = new System.Drawing.Point(210, 286);
            this.boxYahtzee.Name = "boxYahtzee";
            this.boxYahtzee.ReadOnly = true;
            this.boxYahtzee.Size = new System.Drawing.Size(275, 22);
            this.boxYahtzee.TabIndex = 27;
            this.boxYahtzee.Click += new System.EventHandler(this.boxYahtzee_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 40);
            this.label14.TabIndex = 28;
            this.label14.Text = "score: ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(249, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 40);
            this.label15.TabIndex = 29;
            this.label15.Text = "rolls: 3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.boxYahtzee);
            this.Controls.Add(this.boxFives);
            this.Controls.Add(this.boxSixes);
            this.Controls.Add(this.boxThreeEqual);
            this.Controls.Add(this.boxFourEqual);
            this.Controls.Add(this.boxStraight);
            this.Controls.Add(this.boxStraighFlush);
            this.Controls.Add(this.boxFullHouse);
            this.Controls.Add(this.boxChance);
            this.Controls.Add(this.boxFours);
            this.Controls.Add(this.s);
            this.Controls.Add(this.boxTwos);
            this.Controls.Add(this.boxOnes);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolls);
            this.Controls.Add(this.rollDice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rolls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.GroupBox rolls;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxOnes;
        private System.Windows.Forms.TextBox boxTwos;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.TextBox boxFours;
        private System.Windows.Forms.TextBox boxChance;
        private System.Windows.Forms.TextBox boxFullHouse;
        private System.Windows.Forms.TextBox boxStraighFlush;
        private System.Windows.Forms.TextBox boxStraight;
        private System.Windows.Forms.TextBox boxFourEqual;
        private System.Windows.Forms.TextBox boxThreeEqual;
        private System.Windows.Forms.TextBox boxSixes;
        private System.Windows.Forms.TextBox boxFives;
        private System.Windows.Forms.TextBox boxYahtzee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

