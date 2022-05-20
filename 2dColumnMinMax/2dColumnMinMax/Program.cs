using System;
class ColumnMaxMin
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3, 3];
        int min = 234567899, max = -234567899, min1 = 234567899, max1 = -234567899, min2 = 234567899, max2 = -234567899;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("input element at " + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (j == 0)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                    if (a[i, j] < min)
                        min = a[i, j];
                }
                if (j == 1)
                {
                    if (a[i, j] > max1)
                        max1 = a[i, j];
                    if (a[i, j] < min1)
                        min1 = a[i, j];
                }
                if (j == 2)
                {
                    if (a[i, j] > max2)
                        max2 = a[i, j];
                    if (a[i, j] < min2)
                        min2 = a[i, j];
                }
            }
        }
        Console.WriteLine("minimun and maximum element at column(1):" + min + " , " + max);
        Console.WriteLine("minimun and maximum element at column(2):" + min1 + " , " + max1);
        Console.WriteLine("minimun and maximum element at column(3):" + min2 + " , " + max2);
    }
}