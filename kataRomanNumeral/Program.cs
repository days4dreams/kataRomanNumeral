using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataRomanNumeral
{
    class Program
    {
        

        static void Main(string[] args)
        {
            romanConvert convertNumber = new romanConvert();

            Console.WriteLine("Welcome to Roman Numeral.");
            Console.WriteLine("Enter a number between 1 and 100 to find the numeral value.");

            string givenInput = Console.ReadLine();

            int givenNumber = Convert.ToInt32(givenInput);

            string outputNumeral = convertNumber.convertToNumeral(givenNumber);

            Console.WriteLine("The Roman equavilanet is " + outputNumeral);
            Console.ReadKey();
        }
    }
}
