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
    public partial class Set_Rolls_Interval_Form : Form
    {
        //Function to initialize the form
        public Set_Rolls_Interval_Form()
        {
            InitializeComponent();
        }
        //The next two functions combine as the event handler for when the roll interval number is changed.
        private void Rolls_interval_ValueChanged(object sender, EventArgs e)
        {
            int rolls_interval = Convert.ToInt32(Math.Round(Rolls_interval_value.Value, 0)); //ensures the value is an int.
            Set_Rolls_interval(rolls_interval);
        }
        private void Set_Rolls_interval(int rolls_interval_param)
        {
            Dice_roller_form_v2.rolls_interval = rolls_interval_param;
        }
        //Clicking the DONE button
        private void Done_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
