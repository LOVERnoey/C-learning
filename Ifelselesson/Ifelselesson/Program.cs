using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ifelselesson {
    internal class Program {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = true;

            Console.WriteLine(Calculator());
            //Console.WriteLine(GetMax( 31, 33, 34));

            if (isMale && isTall) /* isMale || isTall = or */
            {
                Console.WriteLine("You are a tall male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not male or not tall");
            }
            Console.ReadLine();
        }
        static int GetMax(int num1, int num2, int num3) 
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
        static double Calculator()
        {
            Console.Write("Enter the number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Operator: ");
            String Op = Console.ReadLine();
            Console.Write("Enter the number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            if (Op == "+")
            {
                result = num1 + num2;
            }
            else if(Op == "-") { 
                result = num1 - num2;
            }
            else if(Op == "*") {
                result = num1 * num2;
            }
            else if (Op == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");

            }
            return result;
        }
    }
}
