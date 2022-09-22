using System;


namespace NewAdvancedCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("-------------------------------------------\n");
                Console.Write("*** WELCOME TO THE ADVANCED CALCULATOR! ***\n");
                Console.Write("-------------------------------------------\n");
                Console.Write("This calculator allows you to perform ");
                Console.Write("operations \nsuch as Addition, Subtraction, ");
                Console.Write("Multiplication, \nDivision and Tip calculations.");
                Console.Write("\n\n");
                Console.Write("Main Menu:\n\n");
                Console.Write("1. Simple Calculations\n");
                Console.Write("Calculates addition, subtraction, ");
                Console.Write("multiplication, or division.\n\n");
                Console.Write("2. Tip Calculations\n");
                Console.Write("Calculates 18%, 20%, or 25% tip percentages. \n\n");
                Console.Write("Which calculation would you like to perform?\n");
                Console.Write("Type 1 or 2 and press enter.\n");
                Console.Write("");

                SimpleCalculations simple = new SimpleCalculations();
                AdvancedCalculations advance = new AdvancedCalculations();
                string menuOption = simple.choiceValidation(Console.ReadLine());
                
                if (menuOption == "1")
                {
                    Console.Write("Please enter the first number and press enter: ");
                        double firstValue = simple.inputValidation(Console.ReadLine());
                    
                    Console.Write("Please enter the second number and press enter: ");
                        double secondValue = simple.inputValidation(Console.ReadLine());
                        
                    Console.Write("Please enter the operator and press enter: ");
                        string symbol = simple.Operator(Console.ReadLine());
                        simple.simpleCalculation(firstValue, secondValue, symbol);
                }
                else if (menuOption == "2")
                {
                    Console.Write("Please enter the bill amount and press enter: ");
                        double billAmount = simple.inputValidation(Console.ReadLine());
                    
                    Console.Write("Please enter the tip rate and press enter: ");
                        string tipRate = advance.TipType(Console.ReadLine());
                        advance.TipCalculation(billAmount, tipRate);
                }
                else
                {
                    Console.Write("Sorry, that's not an option" );
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                
                Console.Write("Do you want to try again? Y/y or N/n ");
                string tryAgain = simple.exitValidation(Console.ReadLine());
                if (tryAgain == "Y" || tryAgain == "y") Console.Clear();
                    else if (tryAgain == "N" || tryAgain == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for using my calculator, Good Bye!!");
                    break;
                }
                else break;
            }
        }
    }
}
