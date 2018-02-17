using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayattheRaces
{
    public class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is
        public PictureBox MyPictureBox = null; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random
        public int doggie;
        public string Name;
        public Random MyRandomizer;
        
        

        public bool Run()
        {


            
                if (Location < RacetrackLength)
                {
                
                int Location = Randomizer.Next(1, 8);
                
                MyPictureBox.Left += Location;

                






            }





            //Move forward either 1, 2, 3 or 4 spaces at random
            //Update the position of my PictureBox on the form like this:
            // MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won the race

            return true;
            
            
        }


        public void TakeStartingPosition()
        {
            MyPictureBox.Left = 51;
        }
    }
}
   


