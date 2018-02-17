using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ADayattheRaces
{
    public class Bet
    {
        public int Amount = 0;
        public int Dog = 0;
        public Guy Bettor;
        public int doggie;
        public int Winner;

        public string GetDescription()
        {
            if (Amount >= 0)
            {
                string description = Bettor.Name +  " bets $" + Amount + " on Dog #" + Dog;
                Bettor.mylabel.Text = description;
                return description;
            }
            else
            {
                string description = Bettor.Name + "hasn't placed a bet";
                Bettor.mylabel.Text = description;
                return description;
            }








        }

        public int PayOut(int Winner)
        {
            if (doggie == Dog)
            {
                Bettor.Cash = Amount * 2;
                Bettor.UpdateLabels();
            }
            return Winner;
        }

    }
}
