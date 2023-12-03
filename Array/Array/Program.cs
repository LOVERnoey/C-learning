using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] luckyNumber = { 1, 2, 3, 4, 5};
            String[] name = new string[10];

            Console.WriteLine(ageSum());

            /*InsertArray(name);
            PrintNameArray(name);*/
            Console.ReadLine();
        }
        static void PrintNameArray(String [] name) 
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i]+", ");

            }
        }

        static void InsertArray(String[] name)
        {
            
            Console.Write("Enter class name: ");
            for (int i = 0;i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }

        }

        static int ageSum()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int result = age +age;
            return  result;
        }
    }
}
