using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using System.Collections.Generic;

namespace Building_Logics
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            //Convert digits to words

            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            //Console.WriteLine(words[0]);
            Console.WriteLine("Please enter the postive number greater than 0 to convert into words: ");
            int numbersToWord = Convert.ToInt32(Console.ReadLine());

            int rem = 0;
            string inWords = string.Empty;
            
            //Reversing the number

            int revRem = 0;
            int sumRev = 0;
            int modRev = 0;

            while(numbersToWord > 0)
            {
                modRev = numbersToWord % 10;

                sumRev = (sumRev * 10) + modRev;

                numbersToWord/= 10;


            }

            numbersToWord = sumRev;
            Console.WriteLine(sumRev);

            while (numbersToWord > 0)
            {
                rem = numbersToWord % 10;
                numbersToWord = numbersToWord / 10;

                for (int i = 0; i <= rem; i++)
                {
                    if (rem == i)
                    {
                        inWords = words[i];
                        Console.Write(inWords + " ");

                    }

                }
            }
            



                //switch (rem)
                ////{
                //    case 0:
                //        Console.WriteLine(words[0]);
                //        break;
                //    case 1:
                //        Console.WriteLine(words[1]);
                //        break;
                //    case 2:
                //        Console.WriteLine(words[2]);
                //        break;
                //    case 3:
                //        Console.WriteLine(words[3]);
                //        break;
                //    case 4:
                //        Console.WriteLine(words[4]);
                //        break;
                //    case 5:
                //        Console.WriteLine(words[5]);
                //        break;
                //    case 6:
                //        Console.WriteLine(words[6]);
                //        break;
                //    case 7:
                //        Console.WriteLine(words[7]);
                //        break;
                //    case 8:
                //        Console.WriteLine(words[8]);
                //        break;
                //    case 9:
                //        Console.WriteLine(words[9]);
                //        break;
                //}

                //numbersToWord = numbersToWord / 10;


            
            //outWords.Reverse<>;
            //Console.WriteLine(outWords);

            Console.WriteLine();
            //Currency Converter

            Console.WriteLine("Please select your currency conversion choice: \n Press 1 - USD to INR \n Press 2 - Euro to INR \n Press 3 - Yen to INR");
            double CurrencyChoice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Amount: ");
            double userInputCurrency = Convert.ToDouble(Console.ReadLine());

            switch (CurrencyChoice)
            {
                case 1:
                    double dollarToIND = userInputCurrency * 83;
                    Console.WriteLine("Total Indian Rupees = " + dollarToIND);
                    break;
                case 2:
                    double euroToIND = userInputCurrency * 89;
                    Console.WriteLine("Total Indian Rupees = " + euroToIND);
                    break;
                case 3:
                    double yenToIND = userInputCurrency * 0.62;
                    Console.WriteLine("Total Indian Rupees = " + yenToIND);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;

            }



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
             ABCD
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


            //-------------------------------------------------------------------------
            




        }//Main() Ends Here ---------------------

        

    }
}