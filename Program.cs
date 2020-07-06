using System; // using : import
using System.Collections.Generic;
using System.Threading;

namespace cs_dayone // structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("What is your name: ");
            //var name = "Mark"; // var : implicit typing
            string name = Console.ReadLine();
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine($"Hello {name}, how old are you?");
                string ageStr = Console.ReadLine();
                System.Console.WriteLine("");
                if (int.TryParse(ageStr, out int age))
                {
                    valid = true;
                    if (age > 20)
                    {
                        string greeting = "I want to play a game";
                        for (int i = 0; i < greeting.Length; i++)
                        {
                            Console.Write(greeting[i]);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine("\nContinue? (Y/N)");
                        char choice = Console.ReadKey().KeyChar;

                        // String[] vials = new String[3];
                        // vials[0] = "red";

                        // var vials = new List<String>() { "red", "green", "blue" };
                        // vials.Insert(2, "yellow");

                        Dictionary<string, bool> vials = new Dictionary<string, bool>(){
                            {"yellow", true},
                            {"green", true},
                            {"red", true},
                            {"blue", false},
                            {"orange", true},
                        };


                        if (choice == 'y')
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                            Poor Choice you fool!!!!
       ___
       )_(                                            __
       | |                                           [_ ]
     .-'-'-.       _                               .-'. '-.
    /-::_..-\    _[_]_                            /:;/ _.-'\
    )_     _(   /_   _\      [-]                  |:._   .-|
    |;::    |   )_``'_(    .-'-'-.       (-)      |:._     |
    |;::    |   |;:   |    :-...-:     .-'-'-.    |:._     |
    |;::    |   |;:   |    |;:   |     |-...-|    |:._     |
    |;::-.._|   |;:.._|    |;:.._|     |;:.._|    |:._     |
    `-.._..-'   `-...-'    `-...-'     `-...-'    `-.____.-' 
");

                            foreach (KeyValuePair<string, bool> vial in vials)
                            {
                                System.Console.WriteLine(vial.Key + " ");
                            }
                            System.Console.WriteLine("");
                            string vialChoice = Console.ReadLine().ToLower();
                            if (vials.ContainsKey(vialChoice))
                            {
                                var poison = vials[vialChoice];
                                if (!poison)
                                {
                                    System.Console.WriteLine("Good Choice");
                                }
                            }
                            for (int i = 0; i < 10; i++)
                            {
                                if (Console.BackgroundColor == ConsoleColor.White)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.White;
                                }
                                Console.Clear();
                                System.Console.WriteLine("");
                                Thread.Sleep(100);
                            }
                            System.Console.WriteLine("You die");
                            System.Console.WriteLine("play again? (Y/N)");
                            char again = Console.ReadKey().KeyChar;
                            if (again == 'y')
                            {
                                valid = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Goodbye");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You are too young kid");
                    }
                }
                else
                {
                    ConsoleColor foreColor = Console.ForegroundColor;
                    ConsoleColor backColor = Console.BackgroundColor;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    System.Console.WriteLine("Invalid Input");
                    Console.ForegroundColor = foreColor;
                    Console.BackgroundColor = backColor;
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }






            // NUMBERS
            // INT whole numbers (+/-)
            // Double/Float decimals (+/-)
            // Decimal extreme precision
            // TINYINT 1 or 0











        }
    }
}
