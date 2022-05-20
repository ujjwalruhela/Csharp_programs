using System;
class RightDiagonalSum
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3,3];
        int sum = 0;
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write("input element at index" + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (i == 0 && j == 2 || i == 1 && j == 1 || i == 2 && j == 0)
                    sum = sum + a[i, j];
            }
        }
        Console.WriteLine("sum of right diagonal:" + sum);
    }
}