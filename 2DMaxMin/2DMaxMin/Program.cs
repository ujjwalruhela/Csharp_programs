using System;
class MinMax
{
    public static void Main(String[] args)
    {
        int[,] a = new int[3, 3];
        int min = 234567899,max=-234567899;
        for( int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write("input element at" + " " + i + j + ":");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                if (a[i, j] > max)
                    max = a[i, j];
                else if (a[i, j] < min)
                    min = a[i, j];
            }
        }
        Console.WriteLine("maximum element:" + max);
        Console.WriteLine("minimum element:" + min);
    }
}