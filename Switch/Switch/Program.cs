using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch {
    internal class Program {
        static void Main(string[] args)
        {

            Rnd();

            Console.ReadLine();
        }
        static string GetGames(int gameName)
        {
            string game = "";

            switch (gameName)
            {
                case 0:
                    game = "FNAF";
                    break;
                case 1:
                    game = "Call of duty";
                    break;
                case 2:
                    game = "Dota 2";
                    break;
                case 3:
                    game = "lol";
                    break;
                case 4:
                    game = "Need for speed";
                    break;
                default:
                    Console.WriteLine("Invalid Game");
                    break;
            }

            return game;
        }
        static void NumForWhile(int id, int amount)
        {
            while (id <= amount)
            {
                Console.WriteLine(id);
                id++;
            }
        }
        static void NumForWhile2(int id, int amount)
        {
            do
            {
                Console.WriteLine(id);
                id++;
            } while (id <= amount);
        }
        static void GuessName()
        {
            string name = "Bass";
            string guess = "";
            int gameCount = 0;
            int gameLimit = 3;
            bool outofGuess = false;

            while(guess != name && !outofGuess)
            {
                if (gameCount < gameLimit)
                {
                    Console.Write("Enter a guess: ");
                    guess = Console.ReadLine();
                    gameCount++;
                }
                else
                {
                    outofGuess = true;
                }
            }
            if (outofGuess)
            {
                Console.WriteLine("You Lose!!");
            }
            else
            {
                Console.WriteLine("You Win!!");
            }
        }
        static void ForLoop()
        {
            int [] a = new int [7];
            for (int i = 0; i<a.Length; i++)
            {
                try
                {
                    Console.Write("Enter num: ");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("index " + i + " is ");
                    Console.WriteLine(a[i]);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
        static int Exponent(int num, int ep)
        {
            int result = 1;

            for (int i = 1; i <= ep; i++)
            {
                result = result * num;
            }

            return result;
        }
        static void PrintArray(int [] array, string mass)
        {
            foreach (int i in array)
            {
                Console.Write("{0} {1}", mass, i);
            }
        }
        static void Rnd()
        {
            Random rnm = new Random();
            int numGuess = rnm.Next(1, 5);
            int numUserEnter = 0;

            do
            {
                Console.Write("Enter your num : ");
                numUserEnter = Convert.ToInt32(Console.ReadLine());


            } while (numGuess != numUserEnter);
            Console.WriteLine(numGuess);
            Console.WriteLine("You are right!!!");
        }
    }
}
