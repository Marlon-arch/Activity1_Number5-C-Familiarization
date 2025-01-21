using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Number5_C_Familiarization.Classes
{
    public class Multiplication : Calculator
    {
        public override string Symbol => "*";

        // tells the Calculate function in base class to perform multiplication
        public override double Calculate()
        {
            double result = Number1 * Number2;

            // prevent -0 answer
            if (result == 0) // if result is 0 or -0
            {
                return 0; // return positive 0
            }
            return result;
        }

        // tells DisplayOperation function in base class to show product calculation
        public override void DisplayOperation()
        {
            Console.WriteLine($"{Number1} {Symbol} {Number2} = {Calculate()}");
        }
    }
}
