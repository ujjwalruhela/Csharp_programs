using System;
class SortDescending
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        int temp = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("input element at index" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
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
            Console.Write( a[i]+" , ");
        }
    }
}
