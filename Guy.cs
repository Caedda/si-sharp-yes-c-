using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayattheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        
        public RadioButton MyRadioButton;
        public Label mylabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name +  " has $" + Cash;
            
            
          
        }
        public void ClearBet()
        {
        }

        

        public void Collect(int winner) { }




    }

}
