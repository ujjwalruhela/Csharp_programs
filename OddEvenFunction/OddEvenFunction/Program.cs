using System;
class CheckOddEven
{
    public static string OddEven(int a)
    {
        string s;
        if (a % 2 == 0)
            s = "even no.";
        else
            s = "odd no.";
        return s;
    }
    public static void Main(string[] args)
    {
        int num=0;
        string st;
        Console.Write("input a number:");
        num = Convert.ToInt32(Console.ReadLine());
        st=OddEven(num);
        Console.WriteLine("result:"+st);

    }
}