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
 ************ VERSION 2 *****************************************
 * This version 2 of the project with new features.  They include chart updates over time to more
 * accurately show the way the psuedo-random numbers are generated.  This can be done by either time inter-
 * vals or by number of roll intervals (user decides).  It also utilizes the concept of inheritance by 
 * creating an object of the class aDie which is a subclass of aRandomVariable which is a subclass of Random.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Project2_Spicer
{
    public partial class Dice_roller_form_v2 : Form
    {
        public static int roll_count = 6000;  //the default number of rolls is set to 6000, but can change.
        public static int rand_seed = 123;    //the default RNG seed is set 123, but can change.
        public static bool use_time = true;    //boolean for which interval control will be used.
        public static int time_interval = 1000; //user defined time interval, or default (if user chooses roll interval)
        public static int rolls_interval = 1000; //user defined roll interval, or default (if user chooses time interval).
                                                 //This variable is crucial in determining the number of die rolls per timer
                                                 //tick event.
        public int ones, twos, threes, fours, fives, sixes = 0; //Sets up the variables for storing the graphable data.
        public int temp_roll_count = roll_count; //This is the temporary variable for counting down the number of rolls completed
                                                 //per timer tick event
        private aDie D = new aDie();   //Create a standard six-sided die object

        // Function initializes the form
        public Dice_roller_form_v2()
        {
            InitializeComponent();
        }

        //This is the function that populates the array with random "Die Rolls"
        private void GetDieRolls(int roll_count_param)
        {
            int[] roll_values = new int[roll_count_param];  //sets up an array to store all the die
                                                            //values generated.
            for (int i = 0; i < roll_count_param; ++i)      //For loop populates the roll_values array with
            {                                               //random die values between 1 and 6.
                roll_values[i] = D;
            }  
            
            //The next lines use the Enumerable.Count() method to determine the number of times
            //a value shows up in the array. This will be used to populate the histogram.
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=netcore-3.1
            ones += roll_values.Count(n => n == 1);
            twos += roll_values.Count(n => n == 2);
            threes += roll_values.Count(n => n == 3);
            fours += roll_values.Count(n => n == 4);
            fives += roll_values.Count(n => n == 5);
            sixes += roll_values.Count(n => n == 6);           
        }

        //The following function populates the histogram with the data.
        //https://stackoverflow.com/questions/30657907/display-chart-histogram-bars-with-real-time-data
        protected void Update_Histo()
        {
            Dice_Data.Series["Dice Roll Values"].Points.AddY(ones);
            Dice_Data.Series["Dice Roll Values"].Points.AddY(twos);
            Dice_Data.Series["Dice Roll Values"].Points.AddY(threes);
            Dice_Data.Series["Dice Roll Values"].Points.AddY(fours);
            Dice_Data.Series["Dice Roll Values"].Points.AddY(fives);
            Dice_Data.Series["Dice Roll Values"].Points.AddY(sixes);
        }

        // Function for clearing the graph
        // https://stackoverflow.com/questions/11019086/net-chart-clear-and-re-add
        protected void Clear_Graph()
        {
            //Clear the graph
            foreach (var series in Dice_Data.Series)
            {
                series.Points.Clear();
            }
        }

        //Function for resetting variables
        protected void Reset_Data()
        {
            temp_roll_count = roll_count;
            ones = 0;
            twos = 0;
            threes = 0;
            fours = 0;
            fives = 0;
            sixes = 0;
            time_interval = 1000;
            rolls_interval = 1000;
            use_time = true;
        }

        //Clicking the button produces the histogram with the data of a single die rolled N times (N = roll_count).
        private void Roll_button_Click(object sender, EventArgs e)
        {
            //Reset data and clear graph for subsequent usage
            Clear_Graph();
            Reset_Data();
            
            //Creates and opens a popup form asking which type of interval control will be used
            Chart_Control_Form form2 = new Chart_Control_Form();
            form2.ShowDialog();

            if (use_time)   //If the user chooses time interval the tick events will occur at that interval
            {
                timer1.Interval = time_interval;
            }
            else            //Otherwise, the tick events will be every half second
            {
                timer1.Interval = 500;
            }
            //Start the timer for timer tick event handling
            timer1.Start();            
        }

        //Function to update the histogram dynamically based on user defined parameters
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Clear_Graph();              //Clear Graph before each update
            int temp_interval;
            if (use_time)                           //set the temporary interval so that each tick event rolls
            {                                       //enough dice during the event to be evenly split between each
                temp_interval = (roll_count / 10);  //event.
            }
            else
            {
                temp_interval = rolls_interval;     //this ensures the roll interval matches the user request
            }
            GetDieRolls(temp_interval);
            Update_Histo();             //update the histogram

            temp_roll_count -= temp_interval; //decrement the temporary interval

            if (temp_roll_count <= 0)
            {
                timer1.Stop();              //Stop the timer
            }
        }


        //The next two functions combine as the event handler for when the number of rolls is changed.
        protected void Roll_Number_ValueChanged(object sender, EventArgs e)
        {
            int rolls = Convert.ToInt32(Math.Round(Roll_Number.Value, 0)); //ensures the value is an int.
            Set_Roll_Count(rolls);
        }
        protected void Set_Roll_Count(int roll_count_param)
        {
            roll_count = roll_count_param;
        }

        //The next two functions combine as the event handler for when the RNG seed is changed.
        protected void Seed_value_ValueChanged(object sender, EventArgs e)
        {
            int seed = Convert.ToInt32(Math.Round(Seed_value.Value, 0)); //ensures the value is an int.
            Set_Random_Seed(seed);
        }
        protected void Set_Random_Seed(int randomSeed_param)
        {
            rand_seed = randomSeed_param;
        }

        //This is the event handler for when the Double Dice button is selected.  It brings up the second
        //Windows form. 
        //https://www.c-sharpcorner.com/UploadFile/5d065a/how-to-open-a-second-form-using-first-form-in-window-form/
        protected void Dbl_Roll_button_Click(object sender, EventArgs e)
        {
            Double_Dice_Roller_Form_v2 form3 = new Double_Dice_Roller_Form_v2();
            form3.ShowDialog();
        }
    }
}
