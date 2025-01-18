using System;

class Program
{
    static void Main()
    {
        // دریافت اعداد از کاربر
        Console.Write("Enter the first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // محاسبه مجموع
        double sum = a + b + c;

        // چاپ نتیجه
        Console.WriteLine("The sum of the three numbers is: " + sum);
    }
}
