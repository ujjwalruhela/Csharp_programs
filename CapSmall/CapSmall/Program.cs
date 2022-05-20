using System;
namespace Check
{
    class CapSmall
    {
        public static void Main(String[] args)
        {
            char ch;
            int capital = 0, small = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Input character:" + " " + i + ":");
                ch = Console.ReadLine()[0];
                if (ch >= 65 && ch <= 90)
                {
                    Console.WriteLine("Capital letter:" + ch);
                    capital++;
                }
                else if (ch >= 97 && ch <= 122)
                {
                    Console.WriteLine("Small letter:" + ch);
                    small++;
                }
                else
                    Console.WriteLine("invalid input");
            }
            Console.WriteLine("Capital letter counting:" + capital);
            Console.WriteLine("Small letter counting:" + small);
        }
    }
}