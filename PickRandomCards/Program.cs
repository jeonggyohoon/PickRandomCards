using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the number of cards to pick : ");
                string line = Console.ReadLine();

                int numberOfCards;

                if (int.TryParse(line, out numberOfCards))
                {
                    foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                    {
                        Console.WriteLine(card);
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                Console.Write("Do you want restart? : (R/E) ");
                string stopLine = Console.ReadLine();
                if (stopLine == "R")
                {
                    continue;
                }
                if (stopLine == "E")
                {
                    break;
                }
            }
        }
    }
}
