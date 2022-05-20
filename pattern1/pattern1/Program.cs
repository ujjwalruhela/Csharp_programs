class Pattern
{
    public static void Main(String[] args)
    {
        for(int i = 0; i < 5; i++)
        {
            int a = 1;
            for(int j = 0; j < 5; j++)
            {
                if (j == 0)
                    Console.Write(a);
                else if(j==1) 
                {
                    a = a + 3;
                    Console.Write(a);
                }
                else
                {
                    a = a + 4;
                    Console.Write(a);
                }
            }
            Console.WriteLine();    
        }
    }
}