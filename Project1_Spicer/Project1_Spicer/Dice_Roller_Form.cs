/* Project 1 - COP4365 Fall 2020
 * 4 Oct 2020
 * Marcus Spicer (U#53007397)
 * This program is intended to simulate a large number of rolls of a six sided dice and show a histogram
 * of the data.  This is meant to serve as proof that whatever random number generator (RNG) being used
 * is as close to "real" randomness as possible.  The first window achieves this for a single six sided
 * die.  The second window pops up when "Double Dice Roll" is selected and it achieves the same function
 * except it represents the sum of two six sided dice.  The graph should be cleared between button clicks
 * or multiple graph will appear side by side (this serves well for checking how the RNG seed changes the
 * data.)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project1_Spicer
{
    public partial class Dice_Roller_Form : Form
    {
        private int roll_count = 6000;  //the default number of rolls is set to 6000, but can change.
        private int rand_seed = 123;    //the default RNG seed is set 123, but can change.
        public Dice_Roller_Form()
        {
            InitializeComponent();      //this initializes the look and feel of the Windows form.
        }

        //This is the main function of the first form.  Clicking the button produces the histogram
        //with the data of a single die rolled N times (N = roll_count).
        private void Button_Roll_Click(object sender, EventArgs e)
        {
            var rand = new Random(rand_seed);   //here we are creating a new random object seeded by
                                                //the variable rand_seed (RNG seed).
                        //https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-3.1

            int ones, twos, threes, fours, fives, sixes = 0;    //initializes the count for the 
                                                                //different possible roll values.

            int[] roll_values = new int[roll_count];    //sets up an array to store all the randomly
                                                        //generated numbers.

            for (int i = 0; i < roll_count; ++i)                //This loop generates the different
            {                                                   //random values between 1 and 6 and 
                roll_values[i] = rand.Next(1, 7);               //populates the array with those values.
            }

            //The next lines use the Enumerable.Count() method to determine the number of times
            //a value shows up in the array. This will be used to populate the histogram.
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=netcore-3.1
            ones = roll_values.Count(n => n == 1);
            twos = roll_values.Count(n => n == 2);
            threes = roll_values.Count(n => n == 3);
            fours = roll_values.Count(n => n == 4);
            fives = roll_values.Count(n => n == 5);
            sixes = roll_values.Count(n => n == 6);

            //The following lines populate the histogram with the data as described above.
            //https://stackoverflow.com/questions/30657907/display-chart-histogram-bars-with-real-time-data
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("1", ones);
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("2", twos);
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("3", threes);
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("4", fours);
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("5", fives);
            this.dice_histo.Series["Dice Roll Values"].Points.AddXY("6", sixes);
        }

        //The next two functions combine as the event handler for when the number of rolls is changed.
        private void Roll_Number_ValueChanged(object sender, EventArgs e)
        {
            int rolls = Convert.ToInt32(Math.Round(Roll_Number.Value, 0)); //ensures the value is an int.
            Set_Roll_Count(rolls);
        }

        private void Set_Roll_Count(int roll_count_param)
        {
            roll_count = roll_count_param;
        }
        //This is the event handler for clearing the graph.
        //https://stackoverflow.com/questions/50902456/clear-data-in-chart-c-sharp
        private void Clear_Button1_Click(object sender, EventArgs e)
        {
            this.dice_histo.Series["Dice Roll Values"].Points.Clear();
        }
        //The next two functions combine as the event handler for when the RNG seed is changed.
        private void Random_Seed_ValueChanged(object sender, EventArgs e)
        {
            int seed = Convert.ToInt32(Math.Round(Random_Seed.Value, 0)); //ensures the value is an int.
            Set_Random_Seed(seed);
        }

        private void Set_Random_Seed(int randomSeed_param)
        {
            rand_seed = randomSeed_param;
        }

        //This is the event handler for when the Double Dice button is selected.  It brings up the second
        //Windows form. 
        //https://www.c-sharpcorner.com/UploadFile/5d065a/how-to-open-a-second-form-using-first-form-in-window-form/
        private void Button_Roll_Double_Click(object sender, EventArgs e)
        {
            Double_Dice_Roller_Form form2 = new Double_Dice_Roller_Form();
            form2.ShowDialog();
        }
    }
}