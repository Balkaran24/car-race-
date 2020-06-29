using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Race_Balkaran
{
    public class BalkaranBetClass
    {
        //Variables
        public int Amt;
        public int Trk;
        public BalkaranPunterClass Punter;

        public string Description()//This is for updating the descriptions
        {
            string description = "";
            description = this.Punter.ClientName + " bets " + this.Amt + " dollars on Truck #" + Trk;
            return description;
        }

        public int PayOut(int winPerson)//This function is for updating payout
        {
            if (Trk == winPerson)
            {
                return this.Amt;
            }
            else
            {
                return -this.Amt;
            }
        }
    }
}
