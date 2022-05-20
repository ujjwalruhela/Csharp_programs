// largest of 3 no.s

using System;
namespace Check
{
    public class Largest
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("input 3 numbers:");
            int num1, num2, num3;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2 && num1 == num3)
                Console.WriteLine("all 3 no.s are equal");
            else if (num1 >num2 && num1 > num3)
                Console.WriteLine("num1 is greatest");
            if (num2 == num3)
                Console.WriteLine("num2 and num3 are equal");
            else if (num2 > num3)
                Console.WriteLine("num2 is greatest");
            else
                Console.WriteLine("num3 is greatest");

        }
    }
}