using System;
class FibonaciSeries
{
    public static int Fib(int n)
    {
        int a = 0, b = 1, c = 0;
        for (int i = 0; i < n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return a;
    }
    public static void Main(string[] args)
    {
        int range = 0;
        Console.Write("input range to print the fibonaci series:");
        range = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonaci series of "+range+" numbers is:");
        for( int i = 0; i< range ;i++)
        {
            Console.Write(Fib(i)+" ");
        }
    }
}