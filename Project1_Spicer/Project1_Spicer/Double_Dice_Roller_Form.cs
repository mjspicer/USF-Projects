/* Project 1 - COP4365 Fall 2020
 * 4 Oct 2020
 * Marcus Spicer (U#53007397)
 * This program is code for the second Windows form.  It accomplishes the same functions as the first window,
 * only it does it by simulating two six sided dice and sums them together.
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

namespace Project1_Spicer
{
    public partial class Double_Dice_Roller_Form : Form
    {
        private int roll_count2 = 6000;     //the default number of rolls is set to 6000, but can change.
        private int rand_seed2 = 123;       //the default RNG seed is set 123, but can change.
        public Double_Dice_Roller_Form()
        {
            InitializeComponent();          //this initializes the look and feel of the Windows form.
        }

        //This is the main function of the second form.  Clicking the button produces the histogram
        //with the data of a double dice rolled and summed, N times (N = roll_count).
        private void Button_Roll2_Click(object sender, EventArgs e)
        {
            var rand2 = new Random(rand_seed2);     //here we are creating a new random object seeded by
                                                    //the variable rand_seed (RNG seed).
                             //https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-3.1
            
            //The next line initializes the count for the different possible roll values.
            int twos, threes, fours, fives, sixes, sevens, eights, nines, tens, elevens, twelves = 0;

            int[] double_roll_values = new int[roll_count2];    //sets up an array to store all the randomly
                                                                //generated numbers.

            for (int i = 0; i < roll_count2; ++i)   //This loops takes the next two random values between 1
            {                                       //and 6 from the Random object and adds them together. It
                double_roll_values[i] = (rand2.Next(1, 7) + rand2.Next(1, 7));  //then stores that value in
            }                                                                   //the array.

            //The next lines use the Enumerable.Count() method to determine the number of times
            //a value shows up in the array. This will be used to populate the histogram.
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=netcore-3.1
            twos = double_roll_values.Count(n => n == 2);
            threes = double_roll_values.Count(n => n == 3);
            fours = double_roll_values.Count(n => n == 4);
            fives = double_roll_values.Count(n => n == 5);
            sixes = double_roll_values.Count(n => n == 6);
            sevens = double_roll_values.Count(n => n == 7);
            eights = double_roll_values.Count(n => n == 8);
            nines = double_roll_values.Count(n => n == 9);
            tens = double_roll_values.Count(n => n == 10);
            elevens = double_roll_values.Count(n => n == 11);
            twelves = double_roll_values.Count(n => n == 12);

            //The following lines populate the histogram with the data as described above.
            //https://stackoverflow.com/questions/30657907/display-chart-histogram-bars-with-real-time-data
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("2", twos);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("3", threes);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("4", fours);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("5", fives);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("6", sixes);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("7", sevens);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("8", eights);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("9", nines);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("10", tens);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("11", elevens);
            this.dice_histo2.Series["Dice Roll Values"].Points.AddXY("12", twelves);

        }

        //The next two functions combine as the event handler for when the number of rolls is changed.
        private void Roll_Number2_ValueChanged(object sender, EventArgs e)
        {
            int rolls = Convert.ToInt32(Math.Round(Roll_Number2.Value, 0)); //ensures the value is an int.
            Set_Roll_Count2(rolls);
        }

        private void Set_Roll_Count2(int roll_count_param)
        {
            roll_count2 = roll_count_param;
        }

        //This is the event handler for clearing the graph.
        //https://stackoverflow.com/questions/50902456/clear-data-in-chart-c-sharp
        private void Clear_Button2_Click(object sender, EventArgs e)
        {
            this.dice_histo2.Series["Dice Roll Values"].Points.Clear();
        }

        //The next two functions combine as the event handler for when the RNG seed is changed.
        private void Random_Seed2_ValueChanged(object sender, EventArgs e)
        {
            int seed = Convert.ToInt32(Math.Round(Random_Seed2.Value, 0)); //ensures the value is an int.
            Set_Random_Seed2(seed);
        }

        private void Set_Random_Seed2(int randomSeed_param)
        {
            rand_seed2 = randomSeed_param;
        }
    }
}
