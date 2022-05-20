using System;
namespace Check
{
    class ConsonatOrVowel
    {
        public static void Main(String[] args)
        {
            Console.Write("Input a letter character:");
            char ch = Console.ReadLine()[0];
            if (ch >= 65 && ch <= 90 || ch >= 90 && ch <= 122)
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                    ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    Console.WriteLine("Given charcatre is a vowel");
                else
                    Console.WriteLine("Given character is a consonant");
            else
                Console.WriteLine("Invalid Input");


        }
    }
}