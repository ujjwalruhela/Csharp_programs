using System;
class PerfectNo
{
    public static void Main(string[] args)
    {
        int[] a = new int[5];
        int i = 0,count=0;
        
        do
        {
            Console.Write("input array:");
            a[i] = Convert.ToInt32(Console.ReadLine());
            int j = 1, sum = 0;
            int num = a[i];
            while (j<num)
            {
                if (num % j == 0)
                    sum = sum + j;
                j++;
            }
            if (sum == a[i])
            {
                Console.WriteLine("perfect no:" + a[i] + " ");
                count++;
            }
            else
                Console.WriteLine("not perfect");
            i++;
        } while (i < 5);
        Console.WriteLine("perfect number count:" + count);
    }
}