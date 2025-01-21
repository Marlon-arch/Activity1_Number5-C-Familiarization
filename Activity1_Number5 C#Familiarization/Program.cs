using Activity1_Number5_C_Familiarization.Additional;
using Activity1_Number5_C_Familiarization.Classes;

namespace Activity1_Number5_C_Familiarization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> history = new List<string>();  // list named history and stores strings
            
            bool continueCalculating = true; // initialize as true to keep program running

            while (continueCalculating)
            {
                Console.Clear();  // to refresh program after a calculation
                Console.WriteLine("CALCULATOR APP");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Power");
                Console.WriteLine("7. View History");
                Console.WriteLine("8. Exit");
                Console.Write("Select an operation. Type (1-8): ");

                int choice;
                bool validChoice = int.TryParse(Console.ReadLine(), out choice);

                // int.TryParse converts input to an int
                // after conversion, int stored in choice then validChoice set to true
                // if not converted, validChoice set to false

                if (!validChoice || choice < 1 || choice > 8) // invalid conditions
                {
                    Console.WriteLine("Invalid choice. Please choose among the given options only.");
                    continue; // skip next codes and start from top
                }

                if (choice == 8)
                {
                    continueCalculating = false;
                    break; // break out of loop
                }

                if (choice == 7)
                {
                    // redirect to history list
                    Console.WriteLine("\nYour Calculation History:");

                    foreach (string record in history) // print all calculations stored
                    {
                        Console.WriteLine(record);
                    }
                    Console.WriteLine("\nPress any key to return to the menu.");
                    Console.ReadKey(); // pause program and wait for any key
                    continue; // skip next codes and return to top if a key is pressed
                }

                Console.Write("Enter the first number: ");
                double number1 = GetValidNumber(); // call function GetValidNumber to verify
                Console.Write("Enter the second number: ");
                double number2 = GetValidNumber();

                Calculator calculator = null; // object "calculator" declared and initialized as null

                switch (choice) // creates new object of chosen class for each choice
                {
                    case 1:
                        calculator = new Addition();
                        break;
                    case 2:
                        calculator = new Subtraction();
                        break;
                    case 3:
                        calculator = new Multiplication();
                        break;
                    case 4:
                        calculator = new Division();
                        break;
                    case 5:
                        calculator = new Modulus();
                        break;
                    case 6:
                        calculator = new Power();
                        break;
                }

                // set Number1 Number2 as properties of "calculator"
                calculator.Number1 = number1;
                calculator.Number2 = number2;

                // display and store the operation and result
                calculator.DisplayOperation();
                history.Add($"{number1} {calculator.Symbol} {number2} = {calculator.Calculate()}");

                Console.WriteLine("Do you want to perform another calculation? (y/n): ");
                if (Console.ReadLine().ToLower() != "y") // if input is a character other than y, exit program
                // ToLower() added to convert uppercase input to lowercase
                {
                    continueCalculating = false;
                }
            }
        }

        // function to constantly ask and verify user inputs until a valid one is entered
        static double GetValidNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number)) // converts Console.Readline string value to a double type
                // TryParse returns true if valid
                // TryParse returns false if invalid
                // loop prints invalid message as long as condition is true (TryParse returns false) because of negation
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }
    }
}
