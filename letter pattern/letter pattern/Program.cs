using System;
namespace Pattern
{
    class Program
    {
        public static void Main(String[] args)
        {
              for(int i = 0; i < 5; i++)
            {
                int a = 'A';
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                        Console.Write((char)(a));
                    else if (j == 1)
                    {
                        a = a + 3;
                        Console.Write((char)a);
                    }
                    else
                    {
                        a = a + 4;
                        Console.Write((char)a);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}