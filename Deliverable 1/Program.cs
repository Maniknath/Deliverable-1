using System;
using System.Globalization;
namespace Deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number 1: ");
            String s1 = Console.ReadLine();

            Console.Write("Enter Number 2: ");
            String s2 = Console.ReadLine();

            Console.Write("Enter Number 3: ");
            String s3 = Console.ReadLine();

            double num1 = Convert.ToDouble(s1);
            double num2 = Convert.ToDouble(s2);
            double num3 = Convert.ToDouble(s3);

            double total = num1 + num2 + num3;
            double average = total / 3.0;
            double max = num1;
            double min = num1;

            if (num2 > max) max = num2;
            if (num3 > max) max = num3;

            if (num2 < min) min = num2;
            if (num3 < min) min = num3;

            Console.WriteLine("The Average: {0} ", average);
            Console.WriteLine("The Smallest Amount: {0} ", min);
            Console.WriteLine("The Largest Amount: {0} ", max);

            Console.WriteLine();
            Console.WriteLine("US: {0} ", total.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("Swedish: {0} ", total.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE")));
            Console.WriteLine("Japanese: {0} ", total.ToString("C2", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: {0} ", total.ToString("C2", CultureInfo.CreateSpecificCulture("th-TH")));
            Console.ReadLine();



        }
    }
}
