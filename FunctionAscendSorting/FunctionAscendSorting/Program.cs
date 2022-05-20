using System;
class SortingAscending
{
    public static void Main(string[] args)
    {
        int[] a = new int[5];
        int[] d = new int[5];
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write("input array at index" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Original array:");
        foreach (int i in a)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("Sorted array:");
        d=SortAsc(a);
        for(int i = 0; i < 5; i++)
        {
            Console.Write(d[i]+" ");
        }
    }
       public static int[] SortAsc(int[]c)
    {
        int[] b = new int[5];
        for (int i = 0; i < 5; i++)
        {
            
            int temp = 0;
            for(int j = i + 1; j < 5; j++)
            {
                if (c[i] > c[j])
                {
                    temp = c[i];
                    c[i] = c[j];
                    c[j] = temp;
                }
            }
        }
       for(int i = 0; i < 5; i++)
        {
            b[i] = c[i];
        }
        return b;
    }
}


