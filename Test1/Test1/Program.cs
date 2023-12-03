using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "john";
            int characterAge;
            characterAge = 25;
            Char grade = 'A';

            Console.WriteLine(characterName.Length);/*หาขนาดข้อความ*/
            Console.WriteLine(characterName.ToUpper()/* ToLower*/);
            Console.WriteLine(characterName.Contains("j"));
            Console.WriteLine(characterName[2]);/*String index*/
            Console.WriteLine(characterName.IndexOf("oh"));/*Find index*/
            Console.WriteLine(characterName.Substring(1, 2));


            Console.WriteLine(characterName + " is a brave man");
            Console.WriteLine(characterName + " is " + characterAge + " years old ");

            characterName = "james";
            Console.WriteLine(characterName + " don't like game");
            Console.WriteLine(characterName + " love\n kid");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine(50);
            Console.WriteLine(50+2*2);
            Console.WriteLine(5 % 2);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);

            Console.ReadLine();
        }
    }
}
