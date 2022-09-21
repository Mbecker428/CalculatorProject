using System;

namespace NewAdvancedCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num1 = 0,
                   num2 = 0;
            //amount1 = 0;
            //int opt1 = 0;

            string? calcSymbol = "";
            //tipRate = "";
            //string? calcSymbol = "";
            //string calcSymbol;

            ConsoleKeyInfo status;

            while (true)
            {
                //double answer;
                //double tipAmount;

                Console.Write("*** WELCOME TO THE ADVANCED CALCULATOR! ***\n\n");
                Console.Write("Main Menu:\n");
                Console.Write("1. Calculates operations such as addition,");
                Console.Write("subtraction, multiplication, and division.\n");
                Console.Write("2. Calculates tips.\n");
                Console.Write("Which calculation would you like to perform?\n");
                Console.Write("Type 1 or 2 and press enter.\n");
                Console.Write("");

                int option_1 = Convert.ToInt32(Console.ReadLine());
                int option_2 = Convert.ToInt32(Console.ReadLine());
                //Input validation
                if (option_1 == 1 && option_1 < 3 && option_1 > 0)
                {

                    Console.Write("Please enter the first number and press enter: ");
                    string number1 = Console.ReadLine();
                    
                    Console.Write("Please enter the second number and press enter: ");
                    string number2 = Console.ReadLine();

                    SimpleCalculations calculate = new SimpleCalculations();
                    double firstValue = calculate.FirstNumber(number1);
                    double secondValue = calculate.SecondNumber(number2);
                    string symbol = calculate.Operator(calcSymbol);
                    calculate.Calculation(firstValue, secondValue, symbol);
                }
                //I'm using option 2 for the second option on the menu
                else if (option_2 == 2 && option_2 < 3 && option_2 > 0)
                {
                    SimpleCalculations calculate2 = new SimpleCalculations();
                    double amount = calculate2.FirstNumber(number1);
                    string rate = calculate2.TipType(tipRate);
                    calculate2.TipCalculation(amount, rate);
                }
                else
                {
                    Console.Write("Sorry, that's not an option ");
                }
                
                //I need to fix this Y or N choice
                Console.Write("Do You Want To Try Again? Y/y or N/n: ");
                status = Console.ReadKey();
                if (status.Key != ConsoleKey.Y) break;
                Console.WriteLine(status.Key);

                Console.Clear();
            }
        }
    }
}
