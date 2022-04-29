using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Enter first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The 1st number is the largest");
            }
            else if(num2>num3&&num2>num1)
            {
                Console.WriteLine("The 2nd number is the largest");
            }
            else
            {
                Console.WriteLine("The 3rd number is the largest");
            }
        }
    }
}
