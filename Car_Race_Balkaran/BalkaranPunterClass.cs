using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Race_Balkaran
{
    public class BalkaranPunterClass
    {
        //variables
        public string ClientName;
        public BalkaranBetClass bet;
        public int Cashes;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()//This is for upadating the labels
        {
            MyRadioButton.Text = ClientName + " has " + Cashes + " dollars";
            MyLabel.Text = ClientName + " hasn't place a bet";

            if (Cashes == 0)//Code When bettor has no money to bet then it gets destroy
            {
                MyLabel.Text = String.Format("BUSTED");
                MyLabel.ForeColor = System.Drawing.Color.Red;
                MyRadioButton.Enabled = false;
            }

        }

        public void ClearTheBet()//This function is for clearing the bet
        {
            bet.Amt = 0;
            bet.Trk = 0;
            bet.Punter = this;
        }

        public bool PlaceBet(int BetAmount, int TruckToWin)//This function is for placing the bet
        {
            if (Cashes >= BetAmount)
            {
                bet.Amt = BetAmount;
                bet.Trk = TruckToWin;
                bet.Punter = this;
                return true;
            }
            else return false;
        }

        public void Collect(int winner)//This function is for collecting the cash
        {
            Cashes += bet.PayOut(winner);
            this.UpdateLabels();
        }
    }
}
