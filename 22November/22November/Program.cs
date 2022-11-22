using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22November
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //task 1
            Console.WriteLine("task 1");


            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            //tasks 2
            Console.WriteLine("task 2");


            String[] fruits = { "Tomato", "Banana", "Watermelon" };

            for (int x = 0; x < fruits.Length; x++)
            {
                if (fruits[x] == "Tomato")
                {
                    Console.WriteLine(x);
                }

                else if (fruits[x] == "Banana")
                {
                    Console.WriteLine(x);
                }
            }

            // task 3
            Console.WriteLine("task 3");


            string[] food = { "Fish", "Pizza", "Potato", "Chicken", "Donuts" };
            string[] sport = { "Basketball", "Tennis", "Football", "Baseball" };
            string[] movie = { "Boys don't cry", "Rivo", "The Rock" };

            Console.WriteLine("My Favorite Food : ");
            foreach (string i in food)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("My Favorite Sport : ");
            foreach (string r in sport)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("My Favorite Movie : ");
            foreach (string u in movie)
            {
                Console.WriteLine(u);
            }

            // task 4
            Console.WriteLine("task 4");

            string[] numbers = Console.ReadLine().Split(',');

            int[] sums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                sums[i] = Convert.ToInt32(numbers[i]);

            }

            Console.WriteLine(sums[0] + sums[1] + sums[2]);




            //// task 5
            Console.WriteLine("task 5");

            int sum = 0;
            int b;
            for (b = 1; b <= 100; b++)
            {
                if (b % 2 != 0)
                {
                    sum += b;
                }
            }
            Console.WriteLine(sum);



            //task 6
            Console.WriteLine("task 6");


            for (int i = 0; i < 5; i++)
            {
                for (int j = 4 - i; j > 0; j--)
                {

                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }








            //task 7
            Console.WriteLine("task 7");
            int ass = 1;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 4 - i; j > 0; j--)
                {

                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write(ass + " ");
                    ass++;
                }



                Console.WriteLine();

            }










        }
    }
}
