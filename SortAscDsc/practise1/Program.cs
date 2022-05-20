using System;
class Sorting
{
    public static void Main(String[] args)
    {
        int[] b = new int[5];
        int[] c = new int[5];
        int choice1 = 0;
        Console.Write("Enter choice as (1 for Asc sorting and 2 for Dsc sorting):: ");
        choice1 = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            Console.Write("input element at index" + " " + i + ":");
            b[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Original array:");
        foreach (int i in b)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();

        Console.Write("Sorted Array:");

        c = SortingAscDsc(choice1, b);
        foreach (int i in c)
        {
            Console.Write(i + " ");
        }


    }
    public static int[] SortingAscDsc(int choice, int[] a)
    {
        int[] d = new int[5];
        if (choice == 1)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    int temp = 0;
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                d[i] = a[i];
            }
            return d;
        }
        else if (choice == 2)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    int temp = 0;
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                d[i] = a[i];
            }
            return d;
        }
    }
}