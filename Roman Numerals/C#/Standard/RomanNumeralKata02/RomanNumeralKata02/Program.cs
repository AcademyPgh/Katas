using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralKata02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            RomanConverter converter = new RomanConverter();
            string finalResult = converter.Convert(userNumber);
            Console.WriteLine($"Your result is {finalResult}.");
            Console.ReadLine();
        }
    }
}
