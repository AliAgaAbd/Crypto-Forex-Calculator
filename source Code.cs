/*
Author:Ali.aga
no one can copy or sell this program.
github: https://github.com/AliAgaAbd
*/
using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
namespace main
{
    class Program
    {
        public static void Main()
        {
            double seed, risk, sell, usdt, percent, changes, fibo;
            Console.Write("\n\t\t╠╣Hello dear user ! Welcome to Crypto and Forex calculator─╬╣");
            Console.Write("\n\t\t╔──────────────────────────────────────────────────────╗");
            Console.Write("\n\t\t╟Enter your theme (Light or Dark default is DarkYellow)╢");
            Console.Write("\n\t\t╚──────────────────────────────────────────────────────╝─────╡");
            theme(Console.ReadLine());
            string select;
            do
            {
                Console.Clear();
                Console.Write("\n\t\t╠╡PIP average = (p) , LOT size = (l) , USDT <─> % benefit or loss = (i) , Fibonacci retracement = (f)╬┤\n\t\t»If you want to exit = (e)\n\t\t»If you want to change theme = (t):\n\t\t»If you want to exit = (e)\n\t\t»If you want help = (h)\n\t\t~~Select your choice:");
                select = Console.ReadLine();
                switch (select)
                {
                    case "p":
                    case "P":
                        {
                            Console.Clear();
                            List<double> pips = new List<double>();
                            Console.WriteLine("\n\tEnter your PIPs,at the end enter -1 to show results, enter 1 to return to home:");
                            while (true)
                            {
                                try
                                {
                                    pips.Add((Convert.ToDouble(double.Parse(Console.ReadLine()))));
                                    if (pips.Contains(-1)) break;
                                    if (pips.Contains(1)) break;
                                }
                                catch { Console.WriteLine("\n\tInvalid input!"); continue; }
                            }
                            pips.Remove(-1);
                            if (pips.Contains(1) || pips.Count == 0) break;
                            Console.Write($"\n\tResult is : {(float)pips.Average()} PIP\n\tPIP * 1.5 : {(float)((float)pips.Average() * 1.5)} PIP");
                            Console.Write("\n\tPress any key to return to home:");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "l":
                    case "L":
                        {
                            Console.Clear();
                            Console.Write("\n\tEnter your seed capital (USDT):");
                            try
                            {
                                seed = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                            }
                            catch { break; }
                            Console.Write("\n\tEnter your risk (%):");
                            try
                            {
                                risk = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                            }
                            catch { break; }
                            Console.Write("\n\tEnter SL (PIP):");
                            try
                            {
                                sell = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                            }
                            catch { break; }
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
                    case "i":
                    case "I":
                        {
                            Console.Clear();
                            Console.Write("\n\tEnter your Seed Capital (USDT), enter 1 to return to home:");
                            try
                            {
                                usdt = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                            }
                            catch { break; }
                            if (usdt == 1) break;
                            Console.WriteLine("\n\tchanges (%) = a\n\tchanges (USDT) = u");
                            string select2 = Console.ReadLine();
                            switch (select2)
                            {
                                case "a":
                                case "A":
                                    {
                                        Console.Write("\n\tEnter your changes (%), enter 1 to return to home:");
                                        try
                                        {
                                            percent = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                                        }
                                        catch { break; }
                                        if (percent == 1) break;
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
                                        Console.Write("\n\tEnter Your changes (USDT), enter 1 to return to home:");
                                        try
                                        {
                                            changes = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                                        }
                                        catch { break; }
                                        if (changes == 1) break;
                                        Console.Clear();
                                        Console.WriteLine($"\n\t\tOveral status:\n\t{(float)((float)changes / usdt) * 100}% spot");
                                        for (int counter2 = 2; counter2 < 16; counter2++)
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
                    case "f":
                    case "F":
                        {
                            Console.Clear();
                            Console.WriteLine("\n\tEnter your Fibo ratio, enter 10 to return to home:");
                            try
                            {
                                fibo = (Convert.ToDouble(double.Parse(Console.ReadLine())));
                            }
                            catch { break; }
                            if (fibo == 10) break;
                            Console.Write($"\n\tYour TP is:{(float)((float)(1 / fibo) * 100)}");
                            Console.Write("\n\tPress any key to return to home:");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "t":
                    case "T":
                        {
                            Console.Clear();
                            Console.Write("\n\t\t╔──────────────────────────────────────────────────────╗");
                            Console.Write("\n\t\t╟Enter your theme (Light or Dark default is DarkYellow)╢");
                            Console.Write("\n\t\t╚──────────────────────────────────────────────────────╝─────╡");
                            theme(Console.ReadLine());
                            break;
                        }
                    case "h":
                    case "H":
                        {
                            Console.Clear();
                            Console.WriteLine("\n\t1: The function (p)(PIP average) can help you calculate average PIP of candls.\n\t2: The function (l)(LOT size) helps you to manage risk of your orders.\n\t3: The function (i)(USDT <-> % benefit or loss) helps you calculate\n\t   benefit or loss of your orders in spot or futures.\n\t4: The function (f)(Fibonacci retracement) can help you\n\t   with fibonacci section of tradingview to find your TP in orders.\n\t5: You can re-change your theme in main menu by selecting (t)\n\t6: !!Important!!: you should use the characters in the parentheses to select functions.\n");
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
            } while (select != "e" && select != "E");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\tAuthor: Ali.aga\n\t\tStay tuned with updates at my github: https://github.com/AliAgaAbd\n\t\tPlease report issues at my github\n\t\tThanks for using\n\t\thave a good day!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n\t\t\tPress any key to exit:");
            Console.ReadKey();
        }
        public static void theme(string theme)
        {
            switch (theme)
            {
                case "Light":
                case "light":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        break;
                    }
                case "Dark":
                case "dark":
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
        }
    }
}
