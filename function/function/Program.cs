using System;
class SumNumberDigit
{
    public static int SumDigit(int a)
    {
        int sum = 0, rem = 0;
        while (a > 0)
        {
            rem = a % 10;
            sum = sum + rem;
            a = a / 10;
        }
        return sum;
    }
    public static void Main(string[] args)
    {
        int num = 0,result=0;
        Console.WriteLine("input a number:");
        num = Convert.ToInt32(Console.ReadLine());
        result=SumDigit(num);
        Console.WriteLine("sum of digit of the number:"+result);
    }
}