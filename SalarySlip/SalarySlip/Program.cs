using System;
namespace Calculate
{
    class salary
    {
        public static void Main(String[] args)
        {
            string emp_name, dept;
            int emp_no, basic, ta, da, hra, it, gross;
            Console.Write("Employee Name:");
            emp_name = Console.ReadLine();
            Console.Write("Employee number:");
            emp_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee Department:");
            dept = Console.ReadLine();
            if (dept.Equals("sales") || dept.Equals("coding") || dept.Equals("account"))
            {


                if (dept.Equals("sales"))
                {
                    basic = 1000;
                    Console.WriteLine("Baic pay:" + basic);
                    ta = (int)(1000 * 2.5 / 100);
                    Console.WriteLine("Travelling Allowance:" + ta);
                    da = (int)(1000 * 1.5 / 100);
                    Console.WriteLine("Dearness Allowance:" + da);
                    hra = (int)(1000 * 1 / 100);
                    Console.WriteLine("House Rent Allowance:" + hra);
                    it = (int)((basic + ta + da + hra) * 1 / 100);
                    Console.WriteLine("Income Tax:" + it);
                    gross = (int)(basic + ta + da + hra) - it;
                    Console.WriteLine("Gross Salary:" + gross);
                }
                else if (dept.Equals("coding"))
                {
                    basic = 3000;
                    Console.WriteLine("Basic Pay:" + basic);
                    ta = 3000 * 3 / 100;
                    Console.WriteLine("Travelling Allowance:" + ta);
                    da = 3000 * 2 / 100;
                    Console.WriteLine("Dearness Allowance:" + da);
                    hra = 3000 * 2 / 100;
                    Console.WriteLine("House Rent Allowance:" + hra);
                    it = (basic + ta + da + hra) * 1 / 100;
                    Console.WriteLine("Income Tax:" + it);
                    gross = (basic + ta + da + hra) - it;
                    Console.WriteLine("Gross Salary:" + gross);
                }
                else if (dept.Equals("account"))
                {


                    basic = 4000;
                    Console.WriteLine("Basic Pay:" + basic);
                    ta = 3000 * 3 / 100;
                    Console.WriteLine("Travelling Allowance:" + ta);
                    da = 3000 * 2 / 100;
                    Console.WriteLine("Dearness Allowance:" + da);
                    hra = 3000 * 2 / 100;
                    Console.WriteLine("House Rent Allowance:" + hra);
                    it = (basic + ta + da + hra) * 1 / 100;
                    Console.WriteLine("Income Tax:" + it);
                    gross = (basic + ta + da + hra) - it;
                    Console.WriteLine("Gross Salary:" + gross);
                }
            }
            else
                Console.WriteLine("Invalid Input ");
        }
    }
}