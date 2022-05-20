using System;
class CountSpaceChar
{
    public static int Count(string st)
    {
        int count = 0;
        for(int i = 0; i < st.Length; i++)
        {
            if(st[i]==' ')
                count++;
        }
        return count;
    }
    public static void Main(string[] args)
    {
        string s;
        int result = 0;
        Console.Write("input a string:");
            s = Console.ReadLine();
        result=Count(s);
        Console.WriteLine("number of space character:" + result);
    }
}