using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayattheRaces

{
    public partial class Form1 : Form

    {

        Greyhound[] GreyhoundArray = new Greyhound[4];
        Random Randomizer = new Random();
        Guy[] Guys = new Guy[3];
        Bet[] MyBet = new Bet[3];
        Greyhound winner = new Greyhound();
        
        


        public Form1()
        {
            MyBet[0] = new Bet()
            {
                Bettor = Guys[0]


            };

            MyBet[1] = new Bet()
            {
                Bettor = Guys[1]
            };

            MyBet[2] = new Bet()
            {
                Bettor = Guys[2]
            };

            

            InitializeComponent();
            Guys[0] = new Guy()
            {
                Name = "Joe",
                mylabel = label6,
                MyRadioButton = radioButton1,
                Cash = 100,
               

            };

            Guys[1] = new Guy()
            {
                Name = "Bob",
                MyRadioButton = radioButton2,
                mylabel = label7,
                Cash = 100,
                
            };
            Guys[2] = new Guy()
            {
                Name = "Al",
                mylabel = label8,
                MyRadioButton = radioButton3,
                Cash = 100,
               
            };

            GreyhoundArray[0] = new Greyhound()
            {
                Name = "Dog # 1",
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randomizer = Randomizer,
                doggie = 1

            };
            GreyhoundArray[1] = new Greyhound()
            {
                Name = "Dog # 2",
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randomizer = Randomizer,
                doggie = 2
                

            };
            GreyhoundArray[2] = new Greyhound()
            {
                Name = "Dog # 3",
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randomizer = Randomizer,
                doggie = 3
               

            };
            GreyhoundArray[3] = new Greyhound()
            {
                Name = "Dog # 4",
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randomizer = Randomizer,
                doggie =  4
            };

        }
        
        



    private void button2_Click_2(object sender, EventArgs e)
        {

            timer1.Start();



        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 4; i++)
            {
                
                if (GreyhoundArray[i] != null)
                {
                    GreyhoundArray[i].Run();

                    if (GreyhoundArray[i].MyPictureBox.Left >= 519)
                    {

                        timer1.Stop();

                        MessageBox.Show(GreyhoundArray[i].Name + " has won the race!", "We have a winner!");
                        if (GreyhoundArray[i].doggie == MyBet[0].Dog)
                        {
                            Guys[0].Cash += MyBet[0].Amount * 2;
                            Guys[0].UpdateLabels();
                            MessageBox.Show(Guys[0].Name + " has won $" + MyBet[0].Amount * 2);
                        }
                        if (GreyhoundArray[i].doggie == MyBet[1].Dog)
                        {
                            Guys[1].Cash += MyBet[1].Amount * 2;
                            Guys[1].UpdateLabels();
                            MessageBox.Show(Guys[1].Name + " has won $" + MyBet[1].Amount * 2);

                        }
                        if (GreyhoundArray[i].doggie == MyBet[2].Dog)
                        {
                            Guys[2].Cash += MyBet[2].Amount * 2;
                            Guys[2].UpdateLabels();
                            MessageBox.Show(Guys[2].Name + " has won $" + MyBet[2].Amount * 2);
                        }
                        
                        

                        MyBet[0].Amount = 0;
                        MyBet[1].Amount = 0;
                        MyBet[2].Amount = 0;




                        GreyhoundArray[0].TakeStartingPosition();
                        GreyhoundArray[1].TakeStartingPosition();
                        GreyhoundArray[2].TakeStartingPosition();
                        GreyhoundArray[3].TakeStartingPosition();

                        if (radioButton1.Checked)
                        {
                            
                            if (MyBet[0].Amount == 0)
                            {
                                
                                Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
                            }
                            if (MyBet[1].Amount == 0)
                            {
                                Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
                            }
                            if (MyBet[2].Amount == 0)
                            {
                                Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
                            }
                        }
                        if (radioButton2.Checked)
                        {
                            if (MyBet[0].Amount == 0)
                            {
                                Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
                            }
                            if (MyBet[1].Amount == 0)
                            {
                                Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
                            }
                            if (MyBet[2].Amount == 0)
                            {
                                Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
                            }
                        }
                        if (radioButton3.Checked)
                        {
                            if (MyBet[0].Amount == 0)
                            {
                                Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
                            }
                            if (MyBet[1].Amount == 0)
                            {
                                Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
                            }
                            if (MyBet[2].Amount == 0)
                            {
                                Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
                            }
                        }







                    }
                }
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && numericUpDown1.Value >= 5)
            {
                
                MyBet[0].Amount += (int)numericUpDown1.Value;
                Guys[0].Cash -= (int)numericUpDown1.Value;
                Guys[0].UpdateLabels();
                MyBet[0].Dog = (int)numericUpDown2.Value;
                MyBet[0].Bettor = Guys[0];
                MyBet[0].GetDescription();
                
               
                
                
                
                

                
            }

            if (radioButton2.Checked && numericUpDown1.Value >= 5)
            {
                MyBet[1].Amount += (int)numericUpDown1.Value;
                Guys[1].Cash -= (int)numericUpDown1.Value;
                Guys[1].UpdateLabels();
                MyBet[1].Dog = (int)numericUpDown2.Value;
                MyBet[1].Bettor = Guys[1];
                MyBet[1].GetDescription();
                

            }

            if (radioButton3.Checked && numericUpDown1.Value >= 5 )
            {
                MyBet[2].Amount += (int)numericUpDown1.Value;
                Guys[2].Cash -= (int)numericUpDown1.Value;
                Guys[2].UpdateLabels();
                MyBet[2].Dog = (int)numericUpDown2.Value;
                MyBet[2].Bettor = Guys[2];
                MyBet[2].GetDescription();
            }



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                
                label4.Text = Guys[0].Name;
                if (MyBet[0].Amount == 0)
                {
                    Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
                }
                if (MyBet[1].Amount == 0)
                {
                    Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
                }
                if (MyBet[2].Amount == 0)
                {
                    Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                label4.Text = Guys[1].Name;
            
            if (MyBet[0].Amount == 0)
            {
                Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
            }
            if (MyBet[1].Amount == 0)
            {
                Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
            }
            if (MyBet[2].Amount == 0)
            {
                Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                label4.Text = Guys[2].Name;
                if (MyBet[0].Amount == 0)
                {
                    Guys[0].mylabel.Text = Guys[0].Name + " hasn't placed a bet";
                }
                if (MyBet[1].Amount == 0)
                {
                    Guys[1].mylabel.Text = Guys[1].Name + " hasn't placed a bet";
                }
                if (MyBet[2].Amount == 0)
                {
                    Guys[2].mylabel.Text = Guys[2].Name + " hasn't placed a bet";
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 1)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RULES FOR BETS: \n" + "1. The minumum bet is always $5.\n" + "2. If any person's dog wins the race the betting parlor will reward him with double what he bet. \n" +  "3. Each guy can only bet on 1 dog, if he already bets on one dog and wants to bet on a different dog he must bet what he had on the other dog in addition to the new dog.", "The Betting Parlor");
        }
    }
}
    



