﻿using System.Xml.Schema;

namespace Building_Logics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find Odd or Even Number;

            Console.WriteLine("Please enter a Number");
            int givenNumer = int.Parse(Console.ReadLine());

            if (givenNumer % 2 == 0)
            {
                Console.WriteLine("Your number {0} is an Even Number", givenNumer);
            }
            else
            {
                Console.WriteLine("Your number {0} is an Odd Number", givenNumer);
            }

            //Write a c# program to print factorial of a number.

            Console.WriteLine("Please Enter the Number to get Factorial value");

            int factorialNumber = int.Parse(Console.ReadLine());

            int fact = 1;

            for (int i = 1; i <= factorialNumber; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial number is " + fact);

            //Write a c# program to print fibonacci series

            Console.WriteLine("Please the Number to find Fibonacci series");

            int fibNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------");

            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine(num1);
            Console.WriteLine(num2);

            for (int i = 2; i < fibNumber; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }

            //Write a c# program to check palindrome number.

            Console.WriteLine("Please the Number to Check Palindrome");

            int isPalindromeNumber = int.Parse(Console.ReadLine());
            int reminder;
            int reverse = 0;
            int tempPalindrome = isPalindromeNumber; //Use because in while loop isPalindrome number change to zero

            while (isPalindromeNumber > 0)
            {
                reminder = isPalindromeNumber % 10;

                reverse = (reverse * 10) + reminder;

                isPalindromeNumber = isPalindromeNumber / 10;

            }
            //Console.WriteLine(reverse + " Is Reverse Number");
            //Console.WriteLine(isPalindromeNumber + " Is Pal Number");

            if (reverse == tempPalindrome)
            {
                Console.WriteLine("This is a Palindrome number");
            }
            else
            {
                Console.WriteLine("This is not a Palindrome number");
            }

            //Write a c# program to swap two numbers without using third variable.

            Console.WriteLine("Please the first Number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please the second Number");
            int secondNumber = int.Parse(Console.ReadLine());

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            Console.WriteLine("First Number become = " + firstNumber);
            Console.WriteLine("Second Number become = " + secondNumber);

            //Write a c# program to convert decimal number to binary.
            Console.WriteLine("Please a enter a number to convert it into binary number");

            int givenNumber = int.Parse(Console.ReadLine());
            int modNumber;
            string result = string.Empty;

            while(givenNumber != 0)
            {
                modNumber = givenNumber % 2;
                givenNumber = givenNumber / 2;
                result = modNumber.ToString() + result;
                
            }
            Console.WriteLine("Binary Number = " + result);

            //Reverse the number

            Console.WriteLine("Please enter a number to reverse it");
            int usersNumber = int.Parse(Console.ReadLine());
            int remainderValue = 0;
            int reverseNumber = 0;


            while (usersNumber != 0)
            {
                remainderValue = usersNumber % 10;
                reverseNumber = (reverseNumber * 10) + remainderValue;
                usersNumber = usersNumber / 10;

            }
            Console.WriteLine("Your Reverse number is " + reverseNumber);


            //Sum of digits

            Console.WriteLine("Please enter a number at least 2-digits");
            int sumOfDigit = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int remNumber = 0;

            //while(sumOfDigit != 0)
            //{
            //    remNumber = sumOfDigit % 10;

            //    sumOfDigit = sumOfDigit / 10;

            //    totalSum = totalSum + remNumber;
            //}

            //using for loop

            for(; sumOfDigit != 0; sumOfDigit /= 10)
            {
                remNumber = sumOfDigit % 10;
                totalSum = totalSum + remNumber;
            }
            Console.WriteLine("Your Sum of Digits is " + totalSum);

            //Sum of n Numbers

            Console.WriteLine("Please enter a number to get its sum");
            int givenNumberForSummation = int.Parse(Console.ReadLine());

            int xsum = 0;

            for(int i = 0; i <= givenNumberForSummation; i++)
            {
                xsum += i;
            }
            Console.WriteLine("Sum of your Number is " + xsum);


            //Degree Conversion

            //Degree to Fahrenheit

            Console.WriteLine("Please enter a temparature in degree celsius");
            int isDegreeCelcius = int.Parse(Console.ReadLine());

            //Formula method
            int convertedToFahrenhit = (isDegreeCelcius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit = " + convertedToFahrenhit);

            //Fahrenheit to Degree Celsius

            Console.WriteLine("Please enter a temparature in Fahrenheit celsius");
            int isFahrenheit = int.Parse(Console.ReadLine());

            int convertedToDegreeCelsius = ((isFahrenheit - 32) * 5) / 9;
            Console.WriteLine("Degree Celsius = " + convertedToDegreeCelsius);


            //Find the square root of a positive number

            Console.WriteLine("Please enter a positive number to find it's square root");
            double sqNumber = Convert.ToInt32(Console.ReadLine());
            double sqRootNumber = Math.Sqrt(sqNumber);
            

            if (sqNumber < 0)
            {
                Console.WriteLine("You have entered negative number");
            }
            else
            {
                Console.WriteLine("Square Root is = " + sqRootNumber);
            }


            //Find the Cube root of a positive number

            Console.WriteLine("Please enter a positive number to find it's Cube root");
            double cubeNumber = Convert.ToInt32(Console.ReadLine());
            double cubeRootNumber = Math.Cbrt(cubeNumber);
            Console.WriteLine("Cube Root is = " + cubeRootNumber);


            /*
             Print stars in the below pattern
                *
                **
                ***
                ****
                *****
                ******
                *******
                
             */

            for (int row = 1; row < 8; row++)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();// breaking the lines
            }

            Console.WriteLine("----------------------------------");
            /*
             
            *******
            ******
            *****
            ****
            ***
            **
            *
             
             */
            for (int row = 7; row >=1; row--)
            {
                for(int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //Print Alphabets like stars

            /*
             A
             AB
             ABC
             ABCD... till 10 row
             
             
             */

            //string alphabets = "A";

            //for (int row = 1; row <= 10; row--)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {

            //    }

            //}

            //Checkig alphabets increments


            //char alphaStr;
            //for (char alphaStr = 'A'; i < 5; i++)
            //{

            //    alphaStr++;
            //    Console.Write(alphaStr);
            //}


            

        }
    }
}