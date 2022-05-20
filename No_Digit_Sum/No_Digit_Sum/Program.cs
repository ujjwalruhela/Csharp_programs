using System;
class NoDigitSum
{
    public static int DigitSum(int a)
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
    public static void Main(String[] args)
    {
        int num,result=0;
        Console.Write("input number:");
        num = Convert.ToInt32(Console.ReadLine());
       result= DigitSum(num);
        Console.WriteLine("sum of digit of number:"+result);
    }
}