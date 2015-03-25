using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Num2Word numberToword = new Num2Word();
            Console.Write("NUMBERS SPEAK Console Appliccation." + "\n\n");
            Console.Write("Enter the Number to Convert.." + "\n");
            string line;
            int ln1,value;
            do
            {
                Console.Write(" ");
                line = Console.ReadLine();
                if (line == null)
                {
                    Console.WriteLine("Please enter a Number");                  
                }
                else
                {
                    if (int.TryParse(line, out value))
                    {
                        ln1 = int.Parse(line);
                        if (ln1 < 0 || ln1 > 4500)
                        {
                        Console.WriteLine("Please enter a number between 0 and 4500");
                        }
                        else
                        {
                            Console.WriteLine("   " + numberToword.NumberToWords(ln1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please only integer Numbers are allowed..");
                    }
                }
            } 
            while (line != null);  
        }

    }
}
