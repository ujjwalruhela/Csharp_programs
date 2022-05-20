using System;
class LeftDiagonalSum
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
                if (i == j)
                    sum = sum + a[i, j];
            }
        }
        Console.WriteLine("left diagonal sum:" + sum);
    }
}