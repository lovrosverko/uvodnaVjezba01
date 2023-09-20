using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodni01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            a = 100;
            b = 3;
            x = a / b;
            y = a % b;

            Console.WriteLine(a + " dijeljeno sa " + b +
                " je " + x + " s ostatkom " + y);


            Console.ReadKey();
        }
    }
}
