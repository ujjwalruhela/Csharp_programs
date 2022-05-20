using System;
class RightDiagonalMaxMin
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3, 3];
        int max = -234567899, min = 234567899;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("element at index " + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (i == 0 && j == 2 || i == 1 && j == 1 || i == 2 && j == 0)
                {
                    if(a[i,j]>max)
                        max= a[i,j];
                    if(a[i,j]<min)
                        min= a[i,j];
                }
            }
        }
        Console.WriteLine("max element at right diagonal:" + max);
        Console.WriteLine("min element at right diagonal:" + min);

    }
}