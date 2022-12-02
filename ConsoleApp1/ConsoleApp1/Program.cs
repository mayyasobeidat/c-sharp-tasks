using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a = 8;
            int b = 10;
            x = a++;
            x= b++;
            b += ++a;
            x = a++ + b++;
            int y = 0;
            y += x;
            --y;
            a = --x;
        }
    }
}
