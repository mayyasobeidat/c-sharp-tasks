using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _29November
{
    class Employee
    {
        public string Name { get;  }
        public int birthOfDate { get; }
        public string Id { get; }

        public Employee(string _Name, int _birthOfDate, string _Id)
        {
            Name = _Name;
            birthOfDate = _birthOfDate;
            Id = _Id;

        }

        public void BD (int year)
        {int v=Convert.ToInt32(DateTime.Now.Year);
            int birth = v - year; 
            Console.WriteLine("Your Age : "+birth);
        }

        public void BD()
        {
            string month = Console.ReadLine();
            Console.WriteLine(month);
        }

        public virtual void print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(birthOfDate);
            Console.WriteLine(Id);
        }
    
    }



    class Manager : Employee
    {
        public Manager(string _Name, int _birthOfDate, string _Id) : base(_Name, _birthOfDate, _Id)
        {

        }

        public override void print()
        {
            Console.WriteLine("welcome "+Name);
            Console.WriteLine("Your ID : "+Id);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager details = new Manager("Mayyas", 1996, "785416");
     
            details.print();
            details.BD(1996);
            details.BD();


        }
    }
}
