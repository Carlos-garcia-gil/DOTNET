using System;

namespace VarConsForF3
{
    class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 1973;

            const int leap = 4;

            bool isLeapYear;
            string messageOut1 = "is Leap year";
            string messageOut2 = "isn't Leap year"; ;
            string messageOut;

            for (var year = 1948; year < birthYear+1; year++)
            {
                if(year%leap == 0)
                {
                    isLeapYear = true;
                }
                else
                {
                    isLeapYear = false;
                }

                if (isLeapYear) 
                {
                    messageOut = messageOut1;
                }
                else
                {
                    messageOut = messageOut2;
                }
                Console.WriteLine($"{year} {messageOut}");
            }
        }
    }
}