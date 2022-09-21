using System;

namespace NewAdvancedCalculator;

public class SimpleCalculations
{
    public double FirstNumber(string firstNumber)
    {
        double a;
        while (double.TryParse(firstNumber, out a))
        {
            Console.WriteLine(a);
            break;
        }

        return a;
    }

    public double SecondNumber(string secondNumber)
    {
        double b;
        while (double.TryParse(secondNumber, out b))
        {
            Console.WriteLine(b);
            break;
        }

        return b;
    }

    public string Operator(string calcSymbol)
    {
        bool dContinue = true;
        while (dContinue)
        {
            Console.Write("Please enter the operator and press enter: ");
            calcSymbol = Convert.ToString(Console.ReadLine());
            if (calcSymbol == "+" || calcSymbol == "-" || calcSymbol == "*" || calcSymbol == "/")
            {
                Console.WriteLine("your operator symbol is" + calcSymbol);
                dContinue = false;

            }
            else
            {
                Console.WriteLine("That's not an operator. Try again");
            }
        }

        return calcSymbol;
    }

    public double Calculation(double num1, double num2, string calcSymbol)
    {
        double answer = 0;
        switch (calcSymbol)
        {
            case "-":
                answer = (num1 - num2);
                Console.WriteLine($"Your Subtraction result is: {answer}");
                break;
            case "+":
                answer = num1 + num2;
                Console.WriteLine($"Your Addition result is: {answer}");
                break;
            case "/":
                answer = num1 / num2;
                Console.WriteLine($"Your division result is: {answer}");
                break;
            case "*":
                answer = num1 * num2;
                Console.WriteLine($"Your Multiplication result is: {answer}");
                break;
            default:
                Console.WriteLine("Incorrect operator");
                break;
        }
        return answer;
    }

    //FOR OPTION ONLY 2 -this method is to make the user enter the tip percentage they want
    public string TipType(string tipRate)
    {
        bool mContinue = true;
        while (mContinue)
        {
            Console.Write("Please type your tip rate and press enter. Your rates are 18%, 20% and 25%");
            tipRate = Convert.ToString(Console.ReadLine());
            if (tipRate == "18%" || tipRate == "20%" || tipRate == "25%")
            {
                mContinue = false;
            }
            else
            {
                Console.WriteLine("That's not a valid tip rate. Try again");
            }
        }

        return tipRate;
    }

    //FOR OPTION 2 ONLY -this method calculates the tip amount
    public double TipCalculation(double amount1, string tipRate)
    {
        double tipAmount = 0;
        switch (tipRate)
        {
            case "18%":
                tipAmount = amount1 * .18;
                Console.WriteLine($"Your tip amoount is: {tipAmount}");
                break;
            case "20%":
                tipAmount = amount1 * .20;
                Console.WriteLine($"Your tip amoount is: {tipAmount}");
                break;
            case "25%":
                tipAmount = amount1 * .25;
                Console.WriteLine($"Your tip amoount is: {tipAmount}");
                break;
            default:
                Console.WriteLine("Incorrect percentage number");
                break;
        }
        return tipAmount;
    }
}



