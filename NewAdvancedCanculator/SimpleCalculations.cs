using System;

namespace NewAdvancedCalculator;

public class SimpleCalculations
{
    //This method validates the number inputs
    public double inputValidation(string value)
    {
        double j;
        while (!double.TryParse(value, out j))
        {
            Console.Write("Wrong input please try again: ");
            value = Console.ReadLine();
        }
        return j;
    }

    //This method validates the operators
    public string Operator(string calcSymbol)
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
    public string choiceValidation(string choice)
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
    public string exitValidation(string choice)
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
    public double simpleCalculation(double num1, double num2, string calcSymbol)
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
                Console.WriteLine("Incorrect operator");
                break;
        }
        return answer;
    }
}



