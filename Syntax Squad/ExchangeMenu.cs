﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class ExchangeMenu : AdminMenu
    {
        public override void ShowMenu(User user)
        {
            bool validChoice = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---|| Exchange Menu ||---");
                Console.WriteLine("\t1: Change Exchange Rates \n\t2: Display Exchange Rates");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;
                }


            } while (!validChoice);

        }
    }
}