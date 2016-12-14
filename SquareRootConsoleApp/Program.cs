using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to square : ");
            long input = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Square is" + input * input);
            Console.Read();  
        }
    }
}
