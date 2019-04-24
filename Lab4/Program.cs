using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Asaw dude! Throw me a digy and I'll send ya back the square and cube of all the other lil digys from one to " +
                    "\nthat number ya sent me a while back. Just like, don't make it all big and that cause I don't feel like doin too much" +
                    "\n work nawmsayin? YEEEEEEWWWW!");

                string uNumber = Console.ReadLine();
                double Number = double.Parse(uNumber);

                Console.WriteLine("Siiiiiiiiick here we go!");

                for (int i = 1; i < Number + 2; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine(AddSpaces("Number") + AddSpaces("Squared") + AddSpaces("Cubed"));
                        continue;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine(AddSpaces("======") + AddSpaces("=======") + AddSpaces("======="));
                        continue;
                    }
                    Console.WriteLine(AddSpaces((i - 1).ToString())
                                    + AddSpaces(SquareIt(i - 1))
                                    + AddSpaces(CubeIt(i - 1)));
                }

                Console.WriteLine("Are you down for another round my man? (Y)ay or (N)ay.");

                string uQuit = Console.ReadLine().ToUpper();
                if(uQuit == "Y" || uQuit == "YAY")
                {
                    Console.WriteLine("Uuuuuugh alright if you insist");
                    Console.ReadKey();
                    continue;
                }
                else
                {

                    Console.WriteLine("Sick nasty I'll catch you on the flip flop my goober");
                    Console.ReadKey();
                    break;
                }

            }
        }

        public static string SquareIt(int num)
        {
            num *= num;
            return num.ToString();
        }

        public static string CubeIt(int num)
        {
            num *= num *= num;
            return num.ToString();
        }

        public static string AddSpaces(string str)
        {
            int leng = 20 - str.Length;
            for (int i = 0; i < leng; i++)
            {
                str += " ";
            }
            return str;
        }
    }
}
