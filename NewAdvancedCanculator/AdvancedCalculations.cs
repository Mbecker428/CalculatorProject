using System;


namespace NewAdvancedCalculator;

public class AdvancedCalculations
{
    public static double DollarAmount(double amount1)
    {
        bool eContinue = true;
        while (eContinue)
        {
            Console.Write("Please enter the dollar amount and press enter: ");
            string amount = Console.ReadLine();
            if (double.TryParse(amount, out amount1))
            {

                eContinue = false;
            }
            else
            {
                Console.WriteLine("That's not a number. Try again");
            }
        }

        return amount1;
    }
    
    public static string TipType(string tipRate)
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
    
    public static double TipCalculation(double amount1, string tipRate)
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