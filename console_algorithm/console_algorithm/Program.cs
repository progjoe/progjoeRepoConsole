using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int currency = 123;
            Console.WriteLine(ConvertToWords(currency).ToString());
            Console.ReadLine();
        }

        public static string ConvertToWords(int number)
        {
            string words = "";

            if (number == 0) return "zero";

            if (number < 0) return " minus " + ConvertToWords(Math.Abs(number));

            if ((number / 1000000) > 0)
            {
                words += ConvertToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += ConvertToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ConvertToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "") words += " and ";

                var UnitMaps = new[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten","eleven","twelve","thirteen",
                                      "fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
                var TenMaps = new[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20) words += UnitMaps[number];
                else
                {
                    words += TenMaps[number / 10];
                    if ((number % 10) > 0) words += "-" + UnitMaps[number % 10];
                }
            }


            return words;
        }
    }
}
