using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28November
{

    class Car
    {
        private string carsMake; 
        public string CarsMake
        {
            get { return carsMake; }
            set { carsMake = value; }
        }
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        private int palletNo;
        public int PalletNo
        {
            get { return palletNo; }
            set { palletNo = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private double solar;

        public double Solar
        {
            get { return solar; }
            set { solar = value; }
        }

        public Car(string CARSMAKE , int YEARS, string TYPE , int PRICE , string MODEL , int PALLETNO , string COLOR, double Solar  ) 
        {
            carsMake = CARSMAKE;
            year = YEARS;
            type = TYPE;
            price = PRICE;
            model = MODEL;
            palletNo= PALLETNO;
            color = COLOR;
            solar = Solar;
        }

        public void Start() 
        {
            Console.WriteLine("Your Car Is Start");
        }

        public void Stop()
        {
            Console.WriteLine("Your Car Is Stoped");
        }

        public void SolarCar()
        {
            Console.WriteLine(Solar*15 + "Km");
        }


        public void Print()
        {
            Console.WriteLine(carsMake);
            Console.WriteLine( year);
            Console.WriteLine(type);
            Console.WriteLine(price);
            Console.WriteLine(model);
            Console.WriteLine(palletNo);
            Console.WriteLine(color);
        }



    }

    class BMW : Car
    {
        public BMW(string CARSMAKE, int YEARS, string TYPE, int PRICE, string MODEL, int PALLETNO, string COLOR , double Solar) : base(CARSMAKE, YEARS, TYPE, PRICE, MODEL, PALLETNO, COLOR , Solar)
        {
        
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Car details = new Car("German" , 1999 , "BMW", 10000 , "BMW", 47386 , "yellow" , 15 );
            //details.CarsMake = "non";
            //details.StartAndStop();
            details.Print();
            details.Start();
            details.Stop();
            details.SolarCar();

        }
    }
}

