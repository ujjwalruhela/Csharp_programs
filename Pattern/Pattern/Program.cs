using System;
namespace pattern
{
    class program
    {
        public static void Main(String[] args)
        {
           
            for (int i = 0; i < 5; i++)
            {
                char a = 'A';
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(a);
                    a++;
                }
                Console.WriteLine();
            }
             
            System.Console.WriteLine();

            char b = 'A';
            for (int i = 0; i < 5; i++)
            {
                
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
                b++;
            }
        }
    }
}






  
     
        