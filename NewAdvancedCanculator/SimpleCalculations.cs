using System;
using System.ComponentModel.Design;

namespace NewAdvancedCalculator;

public class SimpleCalculations
{
    //This method validates the number inputs for the basic calculation & takes negative numbers
     public double BasicInputValidation(string value)
     {
         double j;
         while (!double.TryParse(value, out j))
         {
             Console.Write("Wrong input please try again: ");
             value = Console.ReadLine();
         }
         return j;
     }

    //This method validates the bill amount that can't be a negative number
     public double TipInputValidation(string inputNumber)
    {
        double number = 0;
        bool bContinue = true;
        while (bContinue)
        {
            if (double.TryParse(inputNumber, out number) && number > 0) bContinue = false;
            else
            {
                bContinue = true;
                Console.WriteLine("Please enter a number greater than 0. Try again");
                inputNumber = Console.ReadLine();
            }
        }
        return number;
    }

    //This method validates the operators
    public string OperatorValidation(string calcSymbol)
    {
        bool dContinue = true;
        while (dContinue)
        {
            if (calcSymbol == "+" || calcSymbol == "-" || calcSymbol == "*" || calcSymbol == "/")
                dContinue = false;
            else
            {
                dContinue = true;
                Console.WriteLine(("That's not an operator. Try again: "));
                calcSymbol = Convert.ToString((Console.ReadLine()));
            }
        }
        return calcSymbol;
    }
    
    //This method validates the menu choices
    public string MenuChoiceValidation(string choice)
     {
         bool fContinue = true;
         while (fContinue)
         {
             if (choice == "1" || choice == "2")
                 fContinue = false;
             else
             {
                 fContinue = true;
                 Console.WriteLine(("That's not a correct option. Try again: "));
                 choice = Convert.ToString((Console.ReadLine()));
             }
         }
         return choice;
     }
    
    //This method validates the exit answer
    public string ExitValidation(string choice)
    {
        bool gContinue = true;
        while (gContinue)
        {
            if (choice == "Y" || choice == "y" || choice == "N" || choice == "n")
                gContinue = false;
            else
            {
                gContinue = true;
                Console.WriteLine(("That's not a correct option. Try again: "));
                choice = Convert.ToString((Console.ReadLine()));
            }
        }
        return choice;
    }

    //This method calculates the simple operations
    public double SimpleCalculation(double num1, double num2, string calcSymbol)
    {
        double answer = 0;
        switch (calcSymbol)
        {
            case "-":
                answer = Math.Round((num1 - num2), 2);
                Console.WriteLine($"Your Subtraction result is: {answer}");
                break;
            case "+":
                answer = Math.Round((num1 + num2), 2);
                Console.WriteLine($"Your Addition result is: {answer}");
                break;
            case "/":
                while (num2 == 0)
                {
                    Console.WriteLine("Please enter a non-zero number");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                answer = Math.Round((num1 / num2), 2);
                Console.WriteLine($"Your division result is: {answer}");
                break;
            case "*":
                answer = Math.Round((num1 * num2), 2);
                Console.WriteLine($"Your Multiplication result is: {answer}");
                break;
            default:
                Console.WriteLine("That's not a correct option. Try again: ");
                break;
        }
        return answer;
    }
}



