using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23November
{
    internal class Program
    {

        static void sumAndAvgTask1()
        {
            Console.WriteLine("~~~~ Task 1 ~~~~");

            double x;
            double number;
            double sum;
            sum = 0;
            double avg;

            Console.WriteLine("Input the 10 numbers : ");

            for (x = 1; x <= 10; x++)
            {
                Console.Write("Your Number :");

                number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }

            avg = sum / 10.0;

            Console.WriteLine("The sum of numbers is :" + " " + sum);
            Console.WriteLine("The Average is :" + " " + avg);
        }


        static void cubeTask2()
        {
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 2 ~~~~");

            int c;
            int i;
            Console.WriteLine("The cube of the number");
            Console.WriteLine("Input number of terms : ");
            c = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= c; i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is :" + i + " " + "cube of the number is " + cube);

            }
        }


        static void getYearsTask3()
        {
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 3 ~~~~");

            Console.WriteLine("Years greater than (1950)");

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            for (int k = 0; k < years.Length; k++)
                {
                    if (years[k] > 1950)
                    {
                        Console.Write(years[k] + "  ");
                    }
                }
                Console.WriteLine(" ");   
        }


        static void AgeTask4()
        {

            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 4 ~~~~");


            Console.WriteLine("Enter your age in year");
            int year = Convert.ToInt32(Console.ReadLine());

            int days = (year * 365);
            Console.WriteLine("The age in days is :" + days);      
        }


        static void animalsTask5()
        {

            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 5 ~~~~");


            Console.WriteLine("Number of the first animal ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of the second animal ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of the third animal ");
            int z = Convert.ToInt32(Console.ReadLine());

            int legs = ((x * 2) + (y * 4) + (z * 4));

            Console.WriteLine("Number of legs of animals in the farm" +" "+ legs);
        }


        static void logInTask6()
        {
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 6 ~~~~");



            Console.Write("Eenter your name : ");
            string user = Console.ReadLine();
            Console.Write("Enter your password : ");
            string pass = Console.ReadLine();

            string[] users = { "mayyas", "ahmad", "mohammad", "obeidat" };
            string[] passwords = { "0000", "3210", "6666", "1111" };
            bool result = false;

            for (int i = 0; i < users.Length; i++)
            {
                if ((user == users[i]) && (pass == passwords[i]))
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("failed");
            }
        }

      
        static void powerTask7()

        {

            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 7 ~~~~");


            Console.WriteLine("Enter The Number : ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Power : ");
            double y = Convert.ToInt32(Console.ReadLine());

            double end = Math.Pow(x, y);
    
            Console.WriteLine("The Answer = " + " "+ end);
        }


        static void leapYearTask8()
        {
            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 8 ~~~~");


            Console.Write("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
                   
            if (year % 4 == 0 )
            { 
               Console.WriteLine("Leap year");
            }

           else
            {
               Console.WriteLine("Normal Year");
            }
        }


        static void primeNumbersTask9()
        {

            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 9 ~~~~");


            Console.Write("Enter Number: ");
            int number = Convert.ToInt32( Console.ReadLine());

            for (int i = 2; i < number; i++)
            {
                if (number % i ==0)
                {
                    Console.WriteLine("This Number Is Not Prime ");
                    return;
                }
            }
            Console.WriteLine("This Number Is Prime ");
        }


        static void SentenceTask10()
        {

            Console.WriteLine(" ");
            Console.WriteLine("~~~~ Task 10 ~~~~");


            Console.WriteLine("Write a sentence: ");
            string words = Console.ReadLine();
            string[] wordsArray= words.Split(' ');
            Console.WriteLine(wordsArray.Length);
        }


        static void Main(string[] args)
            {

           


        }
    }
}
