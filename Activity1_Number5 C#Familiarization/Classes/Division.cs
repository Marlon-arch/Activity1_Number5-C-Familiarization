using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Number5_C_Familiarization.Classes
{
    public class Division : Calculator
    {
        public override string Symbol => "/";

        // tells the Calculate function in base class to perform division
        public override double Calculate()
        {
            if (Number2 == 0) //check for division by 0
                throw new DivideByZeroException("Cannot divide by zero."); //throw is used to prevent program from ending randomly
            
            double result = Number1 / Number2;

            if (result == 0)
            {
                return 0;
            }
            return result;
        }

        // tells DisplayOperation function in base class to show the division operation
        public override void DisplayOperation()
        {
            try
            {
                Console.WriteLine($"{Number1} {Symbol} {Number2} = {Calculate()}");
            }
            catch (DivideByZeroException ex) //executed when try block fails due to DivideByZeroExeption to prevent crash
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
