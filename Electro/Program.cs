using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite x1");
            bool x1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Vvedite x2");
            bool x2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Vvedite x3");
            bool x3 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("д1 = {0}", !x1);
            Console.WriteLine("д2 = {0}", x2 & !x1);
            Console.WriteLine("д3 = {0}", x2 & !x1 | x2);
            Console.WriteLine("y = {0}", (x2 & !x1 | x2) & x3);
            Console.ReadKey();
        }
    }
}
