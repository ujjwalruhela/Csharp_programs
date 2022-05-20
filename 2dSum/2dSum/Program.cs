using System;
class Sum
{
    public static void Main(String[] args)
    {
        Console.Write("Input the base array:");
        int size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input sub array:");
        int size1 = Convert.ToInt32(Console.ReadLine());
        int[,] a = new int[size,size1];
        int sum = 0;
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j <size1; j++)
            {
                Console.Write("element at index" + " " + i + j + ":");
              a[i,j]=Convert.ToInt32(Console.ReadLine());
                sum=sum+a[i,j];
            }
        }
        Console.WriteLine("Sum of all elements:" + sum);
    }
}