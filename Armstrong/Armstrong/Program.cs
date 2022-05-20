/*using System;
class Armstrong
{
    public static void Main(String[] args)
    {
        int[] a = { 9, 7, 153, 371, 370, 153, 333, 8,56,88,34,35 };
        int rem, armstrong = 0, digit = 0;
        double sum = 0;


        for (int i = 0; i < 12; i++)
        {
            int num=a[i];
            int temp = num;
            while(temp > 0)
            {
                digit++;
                temp = temp / 10;
            }
            temp = num;
            while (temp > 0)
            {

                rem = temp % 10;
                sum = sum + Math.Pow(rem, digit);
                temp = temp / 10;
            }
            if (num == sum)
                armstrong++;
        }
        Console.WriteLine("armstrong element count:" + armstrong);
    }
}*/

using System;
class armstrong
{
    public static void Main(String[] args)
    {
        int[] a = new int[5];
        int armstrong = 0;
        for (int i = 0; i < 5; i++)
        {
            int digit = 0, sum = 0, rem = 0,temp=0;
            Console.Write("input element at index" + " " + i + ":");
            a[i] = Convert.ToInt32(Console.ReadLine());
            temp = a[i];

            do
            {
                temp = temp / 10;
                digit++;
            }
            while (temp > 0);
            temp = a[i];
            while (temp > 0)
            {
                rem = temp % 10;
                sum = (int)(sum + Math.Pow(rem, digit));
                temp = temp / 10;
            }
            if (sum == a[i])
                armstrong++;
        }
        Console.WriteLine("Count of armstrong number:" + armstrong);

    }
}
