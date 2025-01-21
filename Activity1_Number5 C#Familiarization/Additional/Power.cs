using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity1_Number5_C_Familiarization.Classes;

namespace Activity1_Number5_C_Familiarization.Additional
{
    public class Power : Calculator
    {
        public override string Symbol => "^";

        // tells the Calculate function in base class to raise a number by a number
        public override double Calculate()
        {
            return Math.Pow(Number1, Number2);
        }

        // tells DisplayOperation function in base class to show the power calculation
        public override void DisplayOperation()
        {
            Console.WriteLine($"{Number1} {Symbol} {Number2} = {Calculate()}");
        }
    }
}
