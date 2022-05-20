using System;
class Armstrong
{
    public static void Main(String[] args)
    {
        int[] a = { 9, 7, 153, 371, 370, 153, 333, 8, 56, 88, 34, 35 };
        int armstrong = 0;
        


        for (int i = 0; i < 1; i++)
        {
            int num = a[i];
            string s = num.ToString();
            Console.WriteLine(s);
            int len = s.Length;
            Console.WriteLine(len);
            double sum1 = 0;
            for(int j = 0; j < len; j++)
            {
                int con = (int)(s[j]);
                Console.WriteLine(con);
                sum1 = sum1 + Math.Pow(con, len);

            }
            Console.WriteLine(sum1);
            if (sum1 == num)
            {
                armstrong++;
            }

        }
        Console.WriteLine("armstrong element count:" + armstrong);

    }
}
