using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Spicer
{
    //This is the subclass of aRandomVariable that allows for the description of a die
    class aDie : aRandomVariable
    {
        public aDie() : base(1, 7) { }      //This sets up a standard six-sided die

        public aDie(int faces_param) : base(1, (faces_param +1)) { } //This sets up a die with user specified
                                                                     //number of faces
    }
}
