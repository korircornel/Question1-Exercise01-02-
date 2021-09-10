using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertNumericToString
{
    public class NumberToWord
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter the number..");
                int intNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Towards(intNum));
                Console.WriteLine("Do you want to continue ..Y/N?");

            } while (Console.ReadLine().ToLower() == "y");
            Console.ReadLine();
        }

        private static string Towards(int intNum)
        {
            try
            {
                var str1To19 = new string[] { "zero", "one", "two",
                "three", "four", "five", "six",
                "seven", "eight", "nine", "ten",
                "eleven", "twelve",  "thirteen",
                "fourteen", "fifteen", "sixteen",  "seventeen",
                "eighteen", "nineteen"};
                var strMultipleOfTen = new string[] { "twenty", "thirty",
                "forty", "fifty", "sixty", "seventy",
                "eighty", "ninety" };
                //If the Number is zero return null  
                if (intNum == 0)
                    return "zero";
                //check the 100 digit  
                string strResult = "";
                int intDigit;
                if (intNum > 100)
                {
                    intDigit = intNum / 100;
                    intNum = intNum % 100;
                    strResult = str1To19[intDigit] + "hundred";
                }
                if (intNum == 0)
                    return strResult.Trim();
                if (intNum < 20)
                    strResult += " " + str1To19[intNum];
                else
                {
                    //handles 10 digit  
                    intDigit = intNum / 10;
                    intNum = intNum % 10;
                    strResult += " " + strMultipleOfTen[intDigit - 2];
                    if (intNum > 0)
                        strResult += " " + str1To19[intNum];

                }
                return strResult;
            }
            catch
            {
                return "The value you entered is not applicable..";
            }
        }
    }
}