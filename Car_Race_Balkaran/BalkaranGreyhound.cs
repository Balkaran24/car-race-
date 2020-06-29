using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race_Balkaran
{
    public class BalkaranGreyhound
    {
        //Class Variables
        public int truckStartingPos; 
        public int trackLength; 
        public PictureBox TruckPic; 
        public Random RandomNumber; 
        public int Locat; 


        public void TruckStartMethod()//This is for reseting the trucks on their position
        {
            Locat = 0;
            TruckPic.Top = truckStartingPos;
        }
        public bool TruckRace()//For the running of random numbers
        {
            Locat += RandomNumber.Next(1, 5);//changing the random numbers
            TruckPic.Top = Locat;//this is for top location where our truck starts the race
            if (TruckPic.Top >= trackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
