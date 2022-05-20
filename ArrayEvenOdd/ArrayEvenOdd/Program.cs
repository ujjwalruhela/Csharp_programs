using System;
class EvenOdd
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        int even = 0, odd = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element at index" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());
            if (a[i] % 2 == 0)
            {
                even++;
                Console.WriteLine("even no:" + a[i]);
            }
            else
            {
                odd++;
                Console.WriteLine("odd no:" + a[i]);
            }
        }
        Console.WriteLine("even no count:" + even);
        Console.WriteLine("odd no count:" + odd);
    }
}