using System;
namespace Check
{
    class UppToLow_LowToUpp
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("input a char");
            char ch = Console.ReadLine()[0];
            int value=0, value1=0;
            if (ch >= 65 && ch <= 90)
            {
                value = ch + 32;
                Console.WriteLine("conversion to lowercase:" + Convert.ToChar(value));
            }
            else if (ch >= 97 && ch <= 122)
            {
                value1 = ch - 32;
                Console.WriteLine("conversion to uppercase:" + Convert.ToChar(value1));
            }
            else
                Console.WriteLine("Invalid Input");
        }
    }
}