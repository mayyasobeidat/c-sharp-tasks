using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // task 1

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Your Name Is " + name);


            // task 2

            int age = 26;
            double num = 6.9909;
            char letter = 'm';
            bool result = true;
            string text = "mayyas";
            const int x = 90;

            Console.WriteLine(age);
            Console.WriteLine(num);
            Console.WriteLine(letter);
            Console.WriteLine(result);
            Console.WriteLine(text);
            Console.WriteLine(x);


            // task 3


            string [] cars = { "Honda", "BMW", "Ford", "Mazda" , "Volvo" , "Nisan" };

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine(cars[4]);
            Console.WriteLine(cars[5]);
            Console.WriteLine(cars.Length);


            // task 4



            Console.WriteLine("Input your firstname: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Input your lastname: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Input your year of birth: ");
            string bd = Console.ReadLine();


            Console.WriteLine(fname +" "+ lname+ " " + bd );


            //task 5


            int[] numbers = { 1,1,2,3,4,5,6,7,8,9 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);
            Console.WriteLine(numbers[7]);
            Console.WriteLine(numbers[8]);
            Console.WriteLine(numbers[9]);


            // task 6


            int[] numbers2 = { 4, 1, 6, 8, 4, 9};
            int sum = numbers2[0] + numbers2[1] + numbers2[2] + numbers2[3] + numbers2[4] + numbers2[5];

            Console.WriteLine(sum);
















        }
    }
}
