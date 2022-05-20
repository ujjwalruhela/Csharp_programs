using System;
namespace Check
{
    class PositiveNegative
    {
        public static void Main(String[] args)
        {
            int num,pos=0,neg = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Number" + " " + i + ":");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("Positive Number:" + num);
                    pos++;
                }
                else
                {
                    Console.WriteLine("Negative number:" + num);
                    neg++;
                }
            }
            Console.WriteLine("Positive Number Count:" + pos);
            Console.WriteLine("negative number count:" + neg);
        }
    }
}