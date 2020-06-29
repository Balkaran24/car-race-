using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race_Balkaran
{
    public partial class Form1 : Form
    {
        BalkaranGreyhound[] TruckArray = new BalkaranGreyhound[4]; // this is instance of greyhound class
        BalkaranPunterClass[] PuntersArray = new BalkaranPunterClass[3]; // this is instance of punter class
        Random RandomNumbers = new Random();
        public Form1()
        {
            InitializeComponent();
            TrackSetting();
        }

        private void TrackSetting()//setting of race track here assign the starting values of the variables
        {
            radioButtonBalkaran.Checked = true;
            minimumBetLabel.Text = "Minimum Bet : " + numericUpDownNumber.Minimum.ToString() + " dollars";
            TruckArray[0] = new BalkaranGreyhound()
            {
                TruckPic = trk1,//initialize picture 1 to first array
                truckStartingPos = trk1.Top,//initialize to starting position
                trackLength = pictureBox1.Height - trk1.Height,//initialize track length
                RandomNumber = RandomNumbers//initialize random numbers
            };

            TruckArray[1] = new BalkaranGreyhound()//this is for second array of truck class initialization
            {
                TruckPic = trk2,
                truckStartingPos = trk2.Top,
                trackLength = pictureBox1.Height - trk2.Height,
                RandomNumber = RandomNumbers
            };

            TruckArray[2] = new BalkaranGreyhound()
            {
                TruckPic = trk3,
                truckStartingPos = trk3.Top,
                trackLength = pictureBox1.Height - trk3.Height,
                RandomNumber = RandomNumbers
            };

            TruckArray[3] = new BalkaranGreyhound()
            {
                TruckPic = trk4,
                truckStartingPos = trk4.Top,
                trackLength = pictureBox1.Height - trk4.Height,
                RandomNumber = RandomNumbers
            };


            PuntersArray[0] = new BalkaranPunterClass()//This array for the punter class Initialization
            {
                ClientName = "Balkaran",//Here i define the name of client
                bet = null,//Set the bet null
                Cashes = 70,//set cash 70
                MyRadioButton = radioButtonBalkaran,//assign radio buuton
                MyLabel = balkaranBetLabel//assign the labe to punter class
            };

            PuntersArray[1] = new BalkaranPunterClass()
            {
                ClientName = "Rajdeep",
                bet = null,
                Cashes = 95,
                MyRadioButton = radioButtonRajdeep,
                MyLabel = rajdeepBetLabel
            };

            PuntersArray[2] = new BalkaranPunterClass()
            {
                ClientName = "Samsher",
                bet = null,
                Cashes = 65,
                MyRadioButton = radioButtonSamsher,
                MyLabel = samsherBetLabel
            };

            for (int i = 0; i <= 2; i++)
            {
                PuntersArray[i].UpdateLabels();
                PuntersArray[i].bet = new BalkaranBetClass();
            }
        }

        private void raceBttn_Click(object sender, EventArgs e)
        {
            //reset trucks
            TruckArray[0].TruckStartMethod();
            TruckArray[1].TruckStartMethod();
            TruckArray[2].TruckStartMethod();
            TruckArray[3].TruckStartMethod();

            //disable race button till the end of the race
            bettingParlor.Enabled = false;

            //start timer
            timer1.Start();
        }


        private void betBttn_Click(object sender, EventArgs e)
        {
            if (radioButtonBalkaran.Checked)//Here bets are placed in this module
            {
                if (PuntersArray[0].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    balkaranBetLabel.Text = PuntersArray[0].bet.Description();//Here updation of labels from punter class
                }
            }
            else if (radioButtonRajdeep.Checked)
            {
                if (PuntersArray[1].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    rajdeepBetLabel.Text = PuntersArray[1].bet.Description();
                }
            }
            else if (radioButtonSamsher.Checked)
            {
                if (PuntersArray[2].PlaceBet((int)numericUpDownForBet.Value, (int)numericUpDownNumber.Value))
                {
                    samsherBetLabel.Text = PuntersArray[2].bet.Description();
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                if (TruckArray[i].TruckRace())
                {
                    timer1.Stop();
                    bettingParlor.Enabled = true;
                    i++;
                    MessageBox.Show("Truck " + i + " won the race");
                    for (int j = 0; j <= 2; j++)
                    {
                        PuntersArray[j].Collect(i);
                        PuntersArray[j].ClearTheBet();
                    }

                    foreach (BalkaranGreyhound Truck in TruckArray)
                    {
                        Truck.TruckStartMethod();
                    }
                    break;
                }

            }
        }
    }
}
