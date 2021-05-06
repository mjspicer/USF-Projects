/* This is the form that comes up after the user has chosen to look at the data for the sum of two dice.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Spicer
{
    public partial class Double_Dice_Roller_Form_v2 : Form
    {
        public static int roll_count = 6000;  //the default number of rolls is set to 6000, but can change.
        public static int rand_seed = 123;    //the default RNG seed is set 123, but can change.
        public int twos, threes, fours, fives, sixes = 0; //Sets up the variables for storing the graphable data.
        public int sevens, eights, nines, tens, elevens, twelves = 0; //Remaining variables needed for double dice data
        public int temp_roll_count = roll_count;    //This is the temporary variable for counting down the number of rolls completed
                                                    //per timer tick event
        private aDie D2 = new aDie();         //creates six-sided die object  

        //Function initializes the form
        public Double_Dice_Roller_Form_v2()
        {
            InitializeComponent();
        }

        //This is the function that populates the array with random "Dice Rolls"
        private void GetDiceRolls(int roll_count_param)
        {
            int[] roll_values = new int[roll_count_param];  //sets up an array to store all the
                                                            //dice values generated.
            for (int i = 0; i < roll_count_param; ++i)      //For loop populates the roll_values array with
            {                                               //sum of two dice (D), between 2 and 12    
                roll_values[i] = (D2 + D2);
            }

            //The next lines use the Enumerable.Count() method to determine the number of times
            //a value shows up in the array. This will be used to populate the histogram.
            //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count?view=netcore-3.1
            twos += roll_values.Count(n => n == 2);
            threes += roll_values.Count(n => n == 3);
            fours += roll_values.Count(n => n == 4);
            fives += roll_values.Count(n => n == 5);
            sixes += roll_values.Count(n => n == 6);
            sevens += roll_values.Count(n => n == 7);
            eights += roll_values.Count(n => n == 8);
            nines += roll_values.Count(n => n == 9);
            tens += roll_values.Count(n => n == 10);
            elevens += roll_values.Count(n => n == 11);
            twelves += roll_values.Count(n => n == 12);
        }

        //The following function populates the histogram with the data.
        //https://stackoverflow.com/questions/30657907/display-chart-histogram-bars-with-real-time-data
        private void Update_Histo()
        {
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(0);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(twos);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(threes);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(fours);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(fives);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(sixes);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(sevens);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(eights);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(nines);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(tens);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(elevens);
            Dbl_Dice_Data.Series["Dice Roll Values"].Points.AddY(twelves);
        }

        // Function for clearing the graph
        // https://stackoverflow.com/questions/11019086/net-chart-clear-and-re-add
        protected void Clear_Graph()
        {
            //Clear the graph
            foreach (var series in Dbl_Dice_Data.Series)
            {
                series.Points.Clear();
            }
        }

        //Function for resetting variables
        protected void Reset_Data()
        {
            temp_roll_count = roll_count;
            twos = 0;
            threes = 0;
            fours = 0;
            fives = 0;
            sixes = 0;
            sevens = 0;
            eights = 0;
            nines = 0;
            tens = 0;
            elevens = 0;
            twelves = 0;
            Dice_roller_form_v2.time_interval = 1000;
            Dice_roller_form_v2.rolls_interval = 1000;
            Dice_roller_form_v2.use_time = true;
        }

        //Clicking the button produces the histogram of the double dice values after N rolls (N = roll_count)
        private void Dbl_Roll_button_Click(object sender, EventArgs e)
        {
            //Reset data and clear graph for subsequent usage
            Clear_Graph();
            Reset_Data();
            
            //Creates and opens a popup form asking which type of interval control will be used
            Chart_Control_Form form2 = new Chart_Control_Form();
            form2.ShowDialog();

            if (Dice_roller_form_v2.use_time)   //If the user chooses time interval the tick events will occur at that interval
            {
                timer1.Interval = Dice_roller_form_v2.time_interval;
            }
            else                                //Otherwise, the tick events will be every half second
            {
                timer1.Interval = 500;
            }
            //Start the timer for timer tick event handling
            timer1.Start();
        }

        //Function to update the histogram dynamically based on user defined parameters
        public void Timer1_Tick(object sender, EventArgs e)
        {
            Clear_Graph();              //Clear Graph before each update
            int temp_interval;
            if (Dice_roller_form_v2.use_time)               //set the temporary interval so that each tick event rolls
            {                                               //enough dice during the event to be evenly split between each
                temp_interval = (roll_count / 10);          //event.
            }
            else
            {
                temp_interval = Dice_roller_form_v2.rolls_interval;   //this ensures the roll interval matches the user request
            }
            GetDiceRolls(temp_interval);
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
    }
}
