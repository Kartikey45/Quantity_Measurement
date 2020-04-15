using System;

namespace Quantity_Measurement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quantity Measurement Problem");
            AddTwoLengthsInInches addTwoLengths = new AddTwoLengthsInInches();
            double result = addTwoLengths.CentimeterPlusInch(2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
