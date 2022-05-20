using System;
namespace Check
{
    class Largest
    {
        public static void Main(String[] args)
        {
            int num,largest=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Number" + " " + i + ":");
                num=Convert.ToInt32(Console.ReadLine());
                if (num > largest)
                    largest = num;
            }
            Console.WriteLine("Largest Number:" + largest);
        }
    }

}