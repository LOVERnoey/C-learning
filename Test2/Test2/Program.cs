using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your age: ");
            String age = Console.ReadLine();
            Console.WriteLine("Hello "+name+" your age is "+age+" years old");
            */

            Console.Write("Enter an numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num1+num2);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
