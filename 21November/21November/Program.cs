using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21November
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // task 1
            Console.WriteLine("task 1");



            Console.WriteLine("Enter first number : " );
            int first =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int second = Convert.ToInt32( Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(first);
            }

            //task 2
            Console.WriteLine("task 2");


            Console.WriteLine("Input Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("+");
            }
            else if (num < 0)
            {
                Console.WriteLine("-");
            }


            //task 3
            Console.WriteLine("task 3");


            Console.WriteLine("Enter first number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x > y && x > z && y>z )
            {
                Console.WriteLine(x + " " + y + " " + z);
            }

            else if (y > x && y > z && x>z)
            {
                Console.WriteLine(y + " " + x + " " + z);
            }

            else if (z > x && z>y && x>y)
            {
                Console.WriteLine(z + " " + x + " " + y);

            }
            else if (z > x && z > y && x < y)
            {
                Console.WriteLine(z + " " + y + " " + x);

            }
            else if (y > x && y > z && x < z)
            {
                Console.WriteLine(y + " " + z + " " + x);
            }



            //task 4
            Console.WriteLine("task 4");

            int[] numbers = { 4, 5, 9, -6, 1 };
                     

            if (numbers[0] > numbers[1] && numbers[0] > numbers[2] && numbers[0] > numbers[3] && numbers[0] > numbers[4])
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers[1] > numbers[0] && numbers[1] > numbers[2] && numbers[1] > numbers[3] && numbers[1] > numbers[4])
            {
                Console.WriteLine(numbers[1]);
            }
            else if (numbers[2] > numbers[0] && numbers[2] > numbers[1] && numbers[2] > numbers[3] && numbers[2] > numbers[4])
            {
                Console.WriteLine(numbers[2]);
            }
            else if (numbers[3] > numbers[0] && numbers[3] > numbers[1] && numbers[3] > numbers[2] && numbers[3] > numbers[4])
            {
                Console.WriteLine(numbers[3]);
            }
            else if (numbers[4] > numbers[0] && numbers[4] > numbers[1] && numbers[4] > numbers[3] && numbers[4] > numbers[2])
            {
                Console.WriteLine(numbers[4]);
            }





            // task 5 
            Console.WriteLine("task 5");
            Console.WriteLine("Input kilometers per hou : ");
            int kilometers = Convert.ToInt32(Console.ReadLine());
            double l = (kilometers * 0.621371);

            Console.WriteLine(l);



            //task 6
            Console.WriteLine("task 6");


            Console.WriteLine("Input hours : ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input minutes : ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int sum = (hours * 60)+ minutes;
            Console.WriteLine("Total : " + sum+  "minutes");






            // task 7
            Console.WriteLine("task 7");


            Console.WriteLine("Input minutes : ");
            int theminutes = Convert.ToInt32(Console.ReadLine());
            int h = (theminutes / 60);
            int m = (theminutes % 60) ;

            Console.WriteLine( h + "hours," + m + "minutes");



            //task 8
            Console.WriteLine("task 8");


            string[] names = { "mohammad","nasr","abdallah","mahmoud","abood" };

            Console.WriteLine(names[0].Substring(1,3));
            Console.WriteLine(names[1].Substring(1, 3));
            Console.WriteLine(names[2].Substring(1, 3));
            Console.WriteLine(names[3].Substring(1, 3));
            Console.WriteLine(names[4].Substring(1, 3));

















        }
    }
}
