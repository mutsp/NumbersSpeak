using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToWords
{
   public class Num2Word
    {

        public  string NumberToWords(int number)
        {
            string words = System.String.Empty;

            string[] onesMap = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

            string[] tensMap = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
          
            if (number == 0)
            {
                return "Zero";
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";
     

                if (number < 20)
                {
                    words += onesMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "-" + onesMap[number % 10];
                    }
                }
            }

            return words;
        }
    }
}
