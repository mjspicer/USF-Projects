using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_Spicer
{
    //This is a subclass from the Random class that allows for the next random number in the sequence to be 
    //called each time the object is referenced
    abstract class aRandomVariable : Random
    {
        private int seed = Dice_roller_form_v2.rand_seed;
        private static int min, max;
        public aRandomVariable() : base(Dice_roller_form_v2.rand_seed) { } //Default constructor

        //Constructor allows for min and max values to be passed to the random number generator ensuring
        //numbers within the range
        public aRandomVariable(int minValue_param, int maxValue_param) : base(Dice_roller_form_v2.rand_seed)
        {
            min = minValue_param;
            max = maxValue_param;
        }

        //This ensures the next number in the psuedorandom number sequence is called when the object is refernced
        public static implicit operator int(aRandomVariable a) => a.Next(min, max);
    }
}
