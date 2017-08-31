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
            RomanConvert convertNumber = new RomanConvert();

            Console.WriteLine("Welcome to Roman Numeral.");
            Console.WriteLine("Enter a number between 1 and 100 to find the numeral value.");

            string givenInput = Console.ReadLine();

            int givenNumber = Convert.ToInt32(givenInput);

            try
            {
                string outputNumeral = convertNumber.ConvertToNumeral(givenNumber);
                Console.WriteLine("The Roman equavilanet is " + outputNumeral);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
