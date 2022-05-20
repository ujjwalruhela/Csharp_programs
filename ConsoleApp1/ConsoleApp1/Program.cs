using System;
class Practise
{
    public static void Main(String[] args)
    {
        int i = 0, max = -234567899, min = 234567899, size = 0, num = 0; 
        Console.Write("no of loop iteration:" + size);
        size = Convert.ToInt32(Console.ReadLine());
        while (i < size)
        {
            Console.Write("input number:" + num);
            num = Convert.ToInt32(Console.ReadLine());
            if (num > max)
                max = num;

            else if (num < min)
                num = min;
            i++;
        }
        Console.WriteLine("maximum number:" + max);
        Console.WriteLine("minimum number:" + min);
    }
}