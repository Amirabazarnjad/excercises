using System;

class Program
{
    static void Main()
    {
        // تعداد اعداد را از کاربر دریافت کن
        Console.Write("Enter the number of values: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // محاسبه جمع اعداد وارد شده
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number {i}: ");
            double number = Convert.ToDouble(Console.ReadLine());
            sum += number;
        }

        // محاسبه میانگین
        double average = sum / n;

        // چاپ میانگین
        Console.WriteLine("The average of the entered numbers is: " + average);
    }
}
