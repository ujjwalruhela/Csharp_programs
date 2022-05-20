using System;
namespace Calculate
{
    class Marksheet
    {
        public static void Main(String[] args)
        {
            int roll_no, hindi, eng, math, total=0;
            string name;
            double percent;
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Roll No:");
            roll_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hindi Marks:");
            hindi = Convert.ToInt32(Console.ReadLine());
            Console.Write("English Marks:");
            eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math Marks:");
            math = Convert.ToInt32(Console.ReadLine());
            total = hindi + eng + math;
            Console.WriteLine("Total Marks:"+ total);
            percent = total / 3;
            Console.WriteLine("Percentage:"+percent);
            
            if (hindi == 0 || eng == 0 || math == 0)
                Console.WriteLine("you failed the exam");
            else if (percent < 33)
                Console.WriteLine("your fail");
            else if (percent >= 33 && percent < 50)
                Console.WriteLine("Division:3rd Division");
            else if (percent >= 50 && percent < 60)
                Console.WriteLine("Division: 2nd Division");
            else if (percent >= 60 && percent < 75)
                Console.WriteLine("Division: 1st Division");
            else
                Console.WriteLine("Division: Distinction");
        }
    }
}