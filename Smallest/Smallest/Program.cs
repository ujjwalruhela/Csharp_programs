using System;
namespace Check
{
    class Number
    {
        public static void Main(String[] args)
        {
            int num=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Number" + " " + i + ":");
                num=Convert.ToInt32(Console.ReadLine());
                if (num < 100)
                    Console.WriteLine("Number<100:" + num);
                else 
                    Console.WriteLine("Number>100:" + num);
            }
        }
    }

}