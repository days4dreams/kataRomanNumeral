﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kataRomanNumeral
{
    class romanConvert
    {
        public string numeralResult = "";

        public string convertToNumeral (int number)
        {
            if (number < 1 || number > 100)
            {
                numeralResult = "Please enter a value between 1 and 100";
            }

            else
            {

                while (number >= 100)
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
                }
            }
            return numeralResult;

        }
    }
}
