/*
Author:Ali.aga
no one can copy or sell this program.
github: https://github.com/AliAgaAbd
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace test
{
    class Program
    {
        public static void Main()
        {
            Console.Write("\n\t╠╣Hello dear user ! Welcome to Crypto and Forex calculator─╬╣");
            Console.Write("\n\t╔──────────────────────────────────────────────────────╗");
            Console.Write("\n\t╟Enter your theme (Light or Dark default is DarkYellow)╢");
            Console.Write("\n\t╚──────────────────────────────────────────────────────╝─────╡");
            string theme = Console.ReadLine();
            switch (theme)
            {
                case "Light":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    }
                case "Dark":
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
                case null:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        break;
                    }
            }
            string select;
            do
            {
                Console.Clear();
                Console.Write("\n\t\t╠╡PIP average = (p) , LOT size = (l) , USDT <─> % benefit or loss = (i) , Fibonacci retracement = (f)╬┤\n\t\t»If you want to exit = (e):");
                select = Console.ReadLine();
                switch (select)
                {
                    case "p":
                    case "P":
                        {
                            Console.Clear();
                            List<double> pip = new List<double>();
                            Console.WriteLine("\n\tEnter your PIPs,at the end enter -1 to show results:");
                            while (true)
                            {
                                pip.Add(Convert.ToDouble(Console.ReadLine()));
                                bool check = pip.Contains(-1);
                                if (check == true) break;
                                if (check == false) continue;
                            }
                            pip.Remove(-1);
                            Console.Write($"\n\tResult is : {(float)pip.Average()} PIP\n\tPIP * 1.5 : {(float)(pip.Average() * 1.5)} PIP");
                            Console.Write("\n\tPress any key to return to home:");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "i":
                    case "I":
                        {
                            Console.Clear();
                            Console.Write("\n\tEnter your Seed Capital (USDT):");
                            double usdt = (Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine("\n\tchanges (%) = a\n\tchanges (USDT) = u");
                            string select2 = Console.ReadLine();
                            switch (select2)
                            {
                                case "a":
                                case "A":
                                    {
                                        Console.Write("\n\tEnter your changes (%):");
                                        double percent = (Convert.ToDouble(Console.ReadLine()));
                                        Console.Clear();
                                        Console.WriteLine($"\n\t\tOveral status:\n\t{(float)(usdt * percent) / 100} USDT spot");
                                        for (int counter = 2; counter < 16; counter++)
                                        {
                                            Console.WriteLine($"\n\t{(float)((usdt * percent) / 100) * counter} USDT Futures leverage {counter}");
                                        }
                                        Console.Write("\n\tPress any key to return to home:");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                case "u":
                                case "U":
                                    {
                                        Console.Write("\n\tEnter Your changes (USDT):");
                                        double changes = (Convert.ToDouble(Console.ReadLine()));
                                        Console.Clear();
                                        Console.WriteLine($"\n\t\tOveral status:\n\t{(float)((float)changes / usdt) * 100}% spot");
                                        for(int counter2 = 2;counter2 < 16; counter2++)
                                        {
                                            Console.WriteLine($"\n\t{(float)((float)(((float)changes / usdt) * 100) * counter2)}% Futures leverage {counter2}");
                                        }
                                        Console.Write("\n\tPress any key to return to home:");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                case null:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                                default:
                                    {
                                        Console.Clear();
                                        break;
                                    }
                            }
                            break;
                        }
                    case "l":
                    case "L":
                        {
                            Console.Write("\n\tEnter your seed capital (USDT):");
                            double seed = (Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\n\tEnter your risk (%):");
                            double risk = (Convert.ToDouble(Console.ReadLine()));
                            Console.Write("\n\tEnter SL (PIP):");
                            double sell = (Convert.ToDouble(Console.ReadLine()));
                            Console.Clear();
                            Console.WriteLine($"\n\t\tResult is:\n\tLOT size = {(float)((float)((float)((float)risk / 10000) / (float)((float)sell / 10)) * seed)}\n\tRisk = {(float)risk}%\n\tSL = -{(float)sell} PIP = -{(float)((float)sell * 10)} PIPET");
                            Console.WriteLine("\n\t\t\t\tYour loss in SL:");
                            for (int lot = 2; lot < 16; lot++)
                            {
                                Console.WriteLine($"\n\t\t\tYour loss = -{(float)(sell * lot)} PIP = -{(float)((float)sell * (float)((float)lot * 10))} PIPET futures Leverage {lot}");
                            }
                            Console.Write("\n\tPress any key to return to home:");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "f":
                    case "F":
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tEnter your Fibo ratio:");
                            double fibo = (Convert.ToDouble(Console.ReadLine()));
                            Console.Write($"\n\tYour TP is:{(float)((float)(1 / fibo) * 100)}");
                            Console.Write("\n\tPress any key to return to home:");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case null:
                        {
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            break;
                        }
                }
            }while (select != "e");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tAuthor: Ali.aga\n\t\tStay tuned with updates at my github: https://github.com/AliAgaAbd\n\t\tPlease report issues at my github\n\t\tThanks for using\n\t\thave a good day!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\t\t\tPress any key to exit:");
            Console.ReadKey();
        }
    }
}