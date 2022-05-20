using System;
class PrimeNo
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        int prime = 0;
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("input element at index:" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());

            for (int j = 2; j <= a[i]; j++)
            {
                if (a[i] % 2 == 0) ;
                else if (a[i] != j && a[i] % j == 0)
                    break;
                else if (a[i] == j && a[i] % j == 0)
                {
                    Console.WriteLine("prime element:" + a[i]);
                    prime++;
                }
            }
            
        }
        Console.WriteLine("prime element count" + prime);
    } 
}
