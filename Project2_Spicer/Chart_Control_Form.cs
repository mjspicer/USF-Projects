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
    //This is the form that determines if the chart will be based on number of rolls or time interval
    public partial class Chart_Control_Form : Form
    {
        //Function initializes the form
        public Chart_Control_Form()
        {
            InitializeComponent();
        }

        //If the user chooses time interval
        private void Time_button_Click(object sender, EventArgs e)
        {
            Dice_roller_form_v2.use_time = true;
            Set_Time_Interval_Form form2 = new Set_Time_Interval_Form();
            form2.ShowDialog();
            this.Close();
        }

        //If the user chooses number of rolls
        private void Rolls_button_Click(object sender, EventArgs e)
        {
            Dice_roller_form_v2.use_time = false;
            Set_Rolls_Interval_Form form3 = new Set_Rolls_Interval_Form();
            form3.ShowDialog();
            this.Close();
        }
    }
}
