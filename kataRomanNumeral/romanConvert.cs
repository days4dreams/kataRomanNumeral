using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataRomanNumeral
{
    class RomanConvert
    {
        public string numeralResult = "";

        public string ConvertToNumeral (int number)
        {
            if (number < 0 || number > 100)
            {
                throw new ArgumentOutOfRangeException("number", "Number must be between 1 and 100.");
            }

            Dictionary<int, string> NumeralDictionary = new Dictionary<int, string>();

            NumeralDictionary.Add(100, "C");
            NumeralDictionary.Add(90, "XC");
            NumeralDictionary.Add(60, "LX");
            NumeralDictionary.Add(50, "L");
            NumeralDictionary.Add(40, "XL");
            NumeralDictionary.Add(30, "XXX");
            NumeralDictionary.Add(20, "XX");
            NumeralDictionary.Add(10, "X");
            NumeralDictionary.Add(9, "IX");
            NumeralDictionary.Add(5, "V");
            NumeralDictionary.Add(4, "IV");
            NumeralDictionary.Add(3, "III");
            NumeralDictionary.Add(2, "II");
            NumeralDictionary.Add(1, "I");

            foreach (int key in NumeralDictionary.Keys)
            {
                if (number >= key) {

                    string output = NumeralDictionary[key];
                    numeralResult = numeralResult + output;
                    number = number - key;
                }
            }

               /* while (number >= 100)
                {
                    numeralResult = numeralResult + "C";
                    number = number - number;
                    //when the value number exists this loop, it will be less 100
                }

                while (number >= 90)
                {
                    numeralResult = numeralResult + "XC";
                    number = number - 90;
                    //when the value number exists this loop, it will be less 90
                }

                while (number >= 60)
                {
                    numeralResult = numeralResult + "LX";
                    number = number - 60;
                    //when the value number exists this loop, it will be less 60
                }

                while (number >= 50)
                {
                    numeralResult = numeralResult + "L";
                    number = number - 50;
                    //when the value number exists this loop, it will be less 50
                }

                while (number >= 40)
                {
                    numeralResult = numeralResult + "XL";
                    number = number - 40;
                    //when the value number exists this loop, it will be less 50
                }

                while (number >= 10)
                {
                    numeralResult = numeralResult + "X";
                    number = number - 10;
                    //when the value number exists this loop, it will be less 30
                }

                while (number >= 9)
                {
                    numeralResult = numeralResult + "IX";
                    number = number - 9;
                    //when the value number exists this loop, it will be less 9
                }

                while (number >= 5)
                {
                    numeralResult = numeralResult + "V";
                    number = number - 5;
                    //when the value number exists this loop, it will be less 5
                }

                while (number >= 4)
                {
                    numeralResult = numeralResult + "IV";
                    number = number - 4;
                    //when the value number exists this loop, it will be less 3
                }

                while (number >= 3)
                {
                    numeralResult = numeralResult + "I";
                    number = number - 1;
                    //when the value number exists this loop, it will be less 2
                } */
            return numeralResult;
        }
    }
}
