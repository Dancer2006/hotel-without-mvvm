using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        void func1(double n)
        {
            Console.WriteLine("{0}", n);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.func1(95.4);
        }
    }
}
