using System;
namespace Check
{
    class CharDigitSpecial
    {
        public static void Main(String[] args)
        {
            Console.Write("Input a character");
            char ch = Console.ReadLine()[0];
            if (ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
                Console.Write("given character is a letter");
            else if (ch >= 48 && ch <= 57)
                Console.WriteLine("given charcater is a digit");
            else
                Console.WriteLine("given charcater is a special character"); 
        }
    }
}