using System;
class LeftDiagonalMaxMin
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3, 3];
        int max = -234567899, min = 234567899;
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write("input element at index" + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (i == j)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                    if (a[i, j] < min)
                        min = a[i, j];
                }

            }
        }
        Console.WriteLine("Maximum element of left diagoanl:" + max);
        Console.WriteLine("Minimum element of left diagoanl:" + min);
    }
}