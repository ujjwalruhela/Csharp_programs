using System;
namespace Set
{
    public class Ascending
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("input size");
            int size=Convert.ToInt32(Console.ReadLine());
            int [] a = new int[size];
            int temp = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("element at index" + " " + i + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
                for (int i = 0; i < size; i++)
                {
                for (int j = i+1; j < size; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                }
            for(int i=0; i < 5; i++)    
                Console.Write(a[i]+"  ");
        }
    }
}