using System;
class IsPrime
{
    public static bool CheckPrime(int a)
    {
        int n = 3;
        bool flag = false;
        if (a == 0 || a == 1)
            flag = false;
        else if (a == 2 || a == 3)
            flag = true;
        else if (a % 2 == 0)
            flag = false;
        else
            while(n<a)
            {
                if (a % n == 0)
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
                n++;
            }
        return flag;
    }
    public static void Main(String[]args)
    {
        int num = 0;
        bool result;
        Console.Write("enter number to check Isprime or not:");
        num=Convert.ToInt32(Console.ReadLine());
        result=CheckPrime(num);
        Console.WriteLine("Is Number Prime:" + result); 
    }
}