using System;
class Pattern
{
    public static void Main(string[] args)
    {
        pattern1();
        pattern2();
        Pattern3();
        Pattern4();
        Pattern5();
        Pattern6();
        Pattern7();
        Pattern pattern=new Pattern();


        pattern.Pattern8();
        pattern.Pattern9();
        pattern.Pattern10();
    }
    public static void pattern1()
    {
        for(int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("1");
            }
            Console.WriteLine();
        }
    }

   
    public static void pattern2()
    {
        int i = 1;
        do
        {
            int j = 1;
            do
            {
                if (j <= i)
                    Console.Write("*");
                else
                    Console.Write(" ");
                j++;
            } while (j <= 5);
            Console.WriteLine();
            i++;
        } while (i <= 5);
    }

    public static void Pattern3()
    {
        int i = 1;
        while (i <= 5)
        {
            int j = 1;
            while (j <= 5)
            {
                if (j <= i)
                    Console.Write("A");
                else
                    Console.Write(" ");
                j++;
            }
            Console.WriteLine();
            i++;
        }
    }


    public static void Pattern4()
    {
        char ch = 'A';
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                if (j <= i)
                    Console.Write(ch);
                else
                    Console.Write(" ");
            }
            ch++;
            Console.WriteLine();
        }
    }


    public static void Pattern5()
    {
        for(int i= 1; i <= 5; i++)
        {
            char c = 'A';
            for (int j= 1; j <= 5; j++)
            {
                if (j <= i)
                {
                    Console.Write(c);
                    c++;
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void Pattern6()
    {
        for(int i = 1; i <= 5; i++)
        {
            int num = 1;
            for (int j = 1; j <= 5; j++)
            {
                if (j <= i)
                {
                    Console.Write(num);
                    num++;
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void Pattern7()
    {
        for(int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                if (j <= 6 - i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

           void Pattern8()
    {
        int num = 1;
        for (int i = 1; i <= 5; i++)
        {
            for(int j = 1; j <= 5; j++)
            {
                if (j <= 6 - i)
                    Console.Write(num);
            }
            num++;
            Console.WriteLine();
        }
    }

    void Pattern9()
    {
        for (int i = 1; i <= 5; i++)
        {
            int num = 1;
            for(int j=1; j <= 5; j++)
            {
                if (j <= 6 - i)
                {
                    Console.Write(num);
                    num++;
                }
            }
            Console.WriteLine();
        }
    }

    void Pattern10()
    {
        for(int i = 1; i <= 5; i++)
        {
            char ch = 'A';
            for(int j = 1; j <= 5; j++)
            {
                if (j <= 6 - i)
                {
                    Console.Write(ch);
                    ch++;
                }
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

}