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
    //This form allows the user to set the time interval for chart update
    public partial class Set_Time_Interval_Form : Form
    {
        //Function initializing the form
        public Set_Time_Interval_Form()
        {
            InitializeComponent();
        }

        //The next two functions combine as the event handler for when the time interval is changed.
        private void Time_interval_ValueChanged(object sender, EventArgs e)
        {
            int time_interval = Convert.ToInt32(Math.Round(Time_interval_value.Value, 0)); //ensures the value is an int.
            Set_Time_interval(time_interval);
        }
        private void Set_Time_interval(int time_interval_param)
        {
            Dice_roller_form_v2.time_interval = time_interval_param;
        }

        //Clicking the DONE button
        private void Done_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
