using System;
namespace Check
{
    class LetDigSpec
    {
        public static void Main(String[] args)
        {
            int let = 0, dig = 0, spec = 0;
            char ch;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("number" + " " + i + ":");
                ch = Console.ReadLine()[0];
                if (ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
                {
                    Console.WriteLine("Input character is letter:" + ch);
                    let++;
                }
                else if (ch >= 48 && ch <= 57)
                {
                    Console.WriteLine("Input character is Digit" + ch);
                }
                else
                {
                    Console.WriteLine("Input character is Special character:" + ch);
                    spec++;
                }
                  
            }
            Console.WriteLine("No. of letter:" + let);
            Console.WriteLine("No. of Digit:" + dig);
            Console.WriteLine("No. of Special character:" + spec);
        }
    }
}