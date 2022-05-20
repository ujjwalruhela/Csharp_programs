using System;
namespace Check
{
    class SmallToCap
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Input a charcater");
            char ch = Console.ReadLine()[0];
            int value=0;
            if (ch >= 65 && ch <= 90)
                Console.WriteLine("given character is an uppercase letter");
            else if (ch >= 97 && ch <= 122)
            {
                value = ch - 32;
                Console.WriteLine("conversion to uppercase:" + Convert.ToChar(value));
            }
            else
                Console.WriteLine("invalid input");
                
        }
    }
}