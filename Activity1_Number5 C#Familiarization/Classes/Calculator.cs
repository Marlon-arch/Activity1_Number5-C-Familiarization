using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1_Number5_C_Familiarization.Classes
{
    // abstract base class rules for all operations
    public abstract class Calculator
    {
        // Private so that no1 no2 are only accessible within this class (encapsulated)
        private double _number1;
        private double _number2;

        // access numbers with validation
        public double Number1 
        {
            get { return _number1; } //read value of _number1
            set { _number1 = value; } //change value of _number1
        }

        public double Number2
        {
            get { return _number2; }
            set { _number2 = value; }
        }

        public virtual string Symbol { get; internal set; }

        // perform the calculation logic
        public abstract double Calculate();

        // display the operation description
        public virtual void DisplayOperation() //virtual so that its function can be changed via the derived classes
        {
            Console.WriteLine("Performing operation...");
        }
    }
} 

