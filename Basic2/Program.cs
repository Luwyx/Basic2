using System;

namespace Basic2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the AbsoluteValue method and printing the results
            Console.WriteLine(AbsoluteValue(6832));
            Console.WriteLine(AbsoluteValue(-392));

            // Calling the DivisibleBy2Or3 method and printing the results
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));

            // Calling the IfConsistsOfUppercaseLetters method and printing the results
            Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("DOG"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));

            // Calling the IfGreaterThanThirdOne method and printing the results
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -5, -8, 50 }));

            // Calling the IfNumberIsEven method and printing the results
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));

            // Calling the IfSortedAscending method and printing the results
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10 }));
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));

            // Calling the PositiveNegativeOrZero method and printing the results
            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0.0));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));

            // Calling the IfYearIsLeap method and printing the results
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
        }

        // Returns the absolute value of an integer
        static int AbsoluteValue(int num)
        {
            return num < 0 ? -num : num;
        }

        // Returns the multiplication of two integers if both are divisible by 2 or 3,
        // otherwise returns their sum
        static int DivisibleBy2Or3(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)
                return num1 * num2;
            else
                return num1 + num2;
        }

        // Checks if a 3-character string consists only of uppercase letters
        static bool IfConsistsOfUppercaseLetters(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsUpper(c))
                    return false;
            }
            return true;
        }

        // Checks if the multiplication or sum of the first two numbers in an array
        // is greater than the third number
        static bool IfGreaterThanThirdOne(int[] nums)
        {
            int sum = nums[0] + nums[1];
            int product = nums[0] * nums[1];
            return sum > nums[2] || product > nums[2];
        }

        // Checks if an integer is even
        static bool IfNumberIsEven(int num)
        {
            return num % 2 == 0;
        }

        // Checks if an array of three integers is sorted in ascending order
        static bool IfSortedAscending(int[] nums)
        {
            return nums[0] <= nums[1] && nums[1] <= nums[2];
        }

        // Determines if a number is positive, negative, or zero
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0)
                return "positive";
            else if (num < 0)
                return "negative";
            else
                return "zero";
        }

        // Checks if a year is a leap year
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
