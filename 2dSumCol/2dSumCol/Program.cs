using System;
class SumColumn
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3,3];
        int sum = 0,sum1=0,sum2 = 0;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write("input element at index" + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (j == 0)
                    sum = sum + a[i, j];
                if (j == 1)
                    sum1 = sum1 + a[i, j];
                if (j == 2)
                    sum2 = sum2 + a[i, j];

            }
        }
        Console.WriteLine("sum of 1 column:" + sum);
        Console.WriteLine("sum of 2 column:" + sum1);
        Console.WriteLine("sum of 3 column:" + sum2);
    }
}