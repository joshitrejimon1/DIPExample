using System;

namespace DIPViolation.Model
{
    internal class TaxCalculator
    {
        public static void CalculateTax(int amount, int rate)
        {
            try
            {
                int tax = amount / rate;
                Console.WriteLine(tax);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
