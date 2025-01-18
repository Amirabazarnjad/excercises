using System;

class Program
{
    static void Main()
    {
        // دریافت عدد تک رقمی از کاربر
        Console.Write("Enter a single-digit number: ");
        int digit = Convert.ToInt32(Console.ReadLine());

        // معادل لاتین عدد تک رقمی
        string[] latinDigits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        if (digit >= 0 && digit <= 9)
        {
            // چاپ معادل لاتین عدد تک رقمی
            Console.WriteLine("The Latin equivalent is: " + latinDigits[digit]);
        }
        else
        {
            Console.WriteLine("Please enter a single-digit number between 0 and 9.");
        }
    }
}

