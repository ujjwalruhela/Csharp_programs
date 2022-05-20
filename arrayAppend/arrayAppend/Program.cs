using System;
class Calculator
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Lets make a Calculator:");
        int num1 = 0, num2 = 0,res=0;
        char choice;
        Console.Write("num1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("num2:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Choose a operator:+,-,*,/");
        choice = Console.ReadLine()[0];               //Choice=Convert.ToChar(Console.ReadLine());
        switch (choice)
        {
            case '+':
                res = num1 + num2;
                break;
            case '_':
                res = num1 - num2;
                break;
            case '*':
                res = num1 * num2;
                break;
            case '/':
                res = num1 / num2;
                break;
            default:Console.WriteLine("invalid operator choice");
                break;
        }
        Console.WriteLine("Result:" + res);
    }
}