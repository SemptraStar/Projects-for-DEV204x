using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    class Program
    {
        static void Main(string[] args)
        {
            printChessBoard(userInput());
        }

        static void printChessBoard(bool start)
        {
            string line1 = "XOXOXOXO",
                   line2 = "OXOXOXOX";

            Console.Clear();

            if (start)
            {
                for (int i = 0; i < 4; i++)
                {
                   Console.WriteLine(line1);
                   Console.WriteLine(line2);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(line2);
                    Console.WriteLine(line1);
                }
            }
        }

        static bool userInput()
        {
            string uI = "";

            do
            {
                Console.Clear();
                Console.WriteLine("Chose the color of top-left square (black or white)");
                Console.WriteLine("X - black, O - white");
                uI = Console.ReadLine();
            } while (uI.ToLower() != "black" && uI.ToLower() != "white");

            return (uI.ToLower() == "black") ? true : false;
        }
    }
}
