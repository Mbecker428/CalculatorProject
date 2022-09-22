using System;


namespace NewAdvancedCalculator;

public class AdvancedCalculations : SimpleCalculations
{
    //This method is to have the user type the tip rate
    public string TipType(string tipRate)
    {
        bool mContinue = true;
        while (mContinue)
        {
            if (tipRate == "18%" || tipRate == "20%" || tipRate == "25%")
            {
                mContinue = false;
            }
            else
            {
                Console.WriteLine("That's not a valid tip rate. Try again    ");
                Console.WriteLine("Please type your tip rate and press enter.");
                Console.WriteLine("your rates are 18%, 20%, and 25%:         ");

                tipRate = Convert.ToString(Console.ReadLine());
                mContinue = true;
            }
        }
        return tipRate;
    }
    
    //This method is to calculate the tip amount
    public double TipCalculation(double amount1, string tipRate)
    {
        double tipAmount = 0;
        switch (tipRate)
        {
            case "18%":
                tipAmount = amount1 * .18;
                Console.WriteLine($"Your tip amount is: {tipAmount}");
                break;
            case "20%":
                tipAmount = amount1 * .20;
                Console.WriteLine($"Your tip amount is: {tipAmount}");
                break;
            case "25%":
                tipAmount = amount1 * .25;
                Console.WriteLine($"Your tip amount is: {tipAmount}");
                break;
            default:
                Console.WriteLine("Incorrect percentage number");
                break;
        }
        return tipAmount;
    }
}