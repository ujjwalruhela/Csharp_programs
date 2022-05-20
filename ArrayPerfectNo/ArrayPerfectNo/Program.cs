using System;
class PerfectNo
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        for (int i = 0; i < 5; i++)
        {
            int temp = 0, sum = 0;
            Console.Write("element at index" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());
            temp = a[i];
          for(int j = 1; j <= temp / 2; j++)
            {
                if (temp % j == 0)
                    sum = sum + j;
            }
            
            if (sum == a[i])
                Console.WriteLine("perfect no:" + a[i] + " ");
        }
        
    }
}