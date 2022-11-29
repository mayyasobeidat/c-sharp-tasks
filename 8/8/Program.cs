using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{

    class person
    {
        private string age;
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string hope;
        public string Hope
        {
            get { return hope; }
            set { hope = value; }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public person(string AGE, string NAME, string HOPE , string COUNTRY) 
        { 
            age = AGE;
            name = NAME;
            hope= HOPE;
            country= COUNTRY;

        }

        public void wellcomeing()
        {
            Console.WriteLine("Welcome " + name);
        }

        public void print()

        {
            Console.WriteLine(age);
            Console.WriteLine(name);
            Console.WriteLine(hope);
            Console.WriteLine(country);
        } 
      
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            person info = new person("26","Mayyas","Photography","Jordan");
            info.wellcomeing();
            Console.WriteLine(" ");
            info.print();
            Console.WriteLine(" ");
            Console.WriteLine("-------");



            person info2 = new person("54", "mohammad", "learning", "egept");
            info2.wellcomeing();
            Console.WriteLine(" ");
            info2.print();
            Console.WriteLine(" ");
            Console.WriteLine("-------");



            person info3 = new person("21", "sara", "fashin", "sauodi");
            info3.wellcomeing();
            Console.WriteLine(" ");
            info3.print();
            Console.WriteLine(" ");
            Console.WriteLine("-------");



            person info4 = new person("60", "laila", "loving", "libanon");
            info4.wellcomeing();
            Console.WriteLine(" ");
            info4.print();

        }
    }
}
