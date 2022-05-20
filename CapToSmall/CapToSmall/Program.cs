using System;
namespace check
{
    class CapToSmall
    {
        public static void Main(String[] args)
        {
            Console.Write("Input a character:");
            char ch = Console.ReadLine()[0];
            int value = 0;
            if (ch >= 97 && ch <= 122)
                Console.WriteLine("given char is in lowercase");
            else if (ch >= 65 && ch <= 90)
            {
                value = ch + 32;
                Console.WriteLine("conversion into Lowercase:" + Convert.ToChar(value));
            }
            else
                Console.WriteLine("Invalid Input");

        }
    }
}