using System;
namespace Pattern
{
    class Program
    {
        public static void Main(String[]args)
        {

            int a = 'A';
            for(int i = 0; i < 5; i++)
            {
                if (i == 0)
                    a = a + 0;
                else if (i == 1)
                    a = a + 3;
                else
                    a = a + 4;

                for(int j = 0; j < 5; j++)
                {
                        Console.Write((char)a);
                }

                Console.WriteLine();

            }

        }
    }
}