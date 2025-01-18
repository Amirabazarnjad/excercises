using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // درخواست یک عدد از کاربر
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // بررسی آیا عدد زوج است یا فرد
            if (IsEven(number))
            {
                // چاپ پیام به انگلیسی اگر عدد زوج باشد
                Console.WriteLine("The entered number is even.");
            }
            else
            {
                // چاپ پیام به انگلیسی اگر عدد فرد باشد
                Console.WriteLine("The entered number is odd.");
            }
        }

        // تابعی برای بررسی زوج بودن عدد
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
