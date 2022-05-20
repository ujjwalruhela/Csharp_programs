using System;
class Leapyear
{
    public static bool Leap(int a)
    {
        bool flag = true;
        if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            flag = true;
        else
            flag= false;
        return flag;
    }
    public static void Main(String[] args)
    {
        int num = 0;
        bool result;
        Console.WriteLine("num:");
        num = Convert.ToInt32(Console.ReadLine());
           result=Leap(num);
        if (result == true)
            Console.WriteLine("leap year");
        else if(result== false)
            Console.WriteLine("not a leap year");
    }
}