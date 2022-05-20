using System;
namespace Check
{
    class MaxMin
    {
        public static void Main(String[] args)
        {
            int size, min = 234567899, max = -123456789;
            Console.Write("input the size of the array:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("element at Index" + " " + i + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (max < a[i])
                    max = a[i];
                else if (min > a[i])
                    min = a[i];
            }
            Console.WriteLine("maximun element:" + max);
            Console.WriteLine("minimun element:" + min);

        }
    }
}