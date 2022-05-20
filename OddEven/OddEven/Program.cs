using System;
namespace Check
{
    class EvenOrOdd
    {
        public static void Main(String[] args)
        {
            int num,even=0,odd=0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Number" +" "+ i + ":");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even number:" + num);
                    even++;
                }
                else
                {
                    Console.WriteLine("Odd number:" + num);
                    odd++;
                }
            }
            Console.WriteLine("Even Count:" + even);
            Console.WriteLine("Odd Count:" + odd);
        }
    }
}