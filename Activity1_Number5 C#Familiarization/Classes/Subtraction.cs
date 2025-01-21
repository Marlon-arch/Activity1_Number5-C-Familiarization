using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Number5_C_Familiarization.Classes
{
    public class Subtraction : Calculator
    {
        public override string Symbol => "-";

        // tells the Calculate function in base class to perform subtraction
        public override double Calculate()
        {
            return Number1 - Number2;
        }

        // tells DisplayOperation function in base class to show difference calculation
        public override void DisplayOperation()
        {
            Console.WriteLine($"{Number1} {Symbol} {Number2} = {Calculate()}");
        }
    }
}
