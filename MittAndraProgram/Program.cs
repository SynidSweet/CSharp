using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MittAndraProgram
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Name your hero: ");

            Player hero = new Player(Console.ReadLine());

            string input = "";

            while (hero.IsAlive() && input != "flee")
            {
                BR();
                PY(hero.StatusReport());
                BR();
                PY("What do you want to do: ");

                input = Console.ReadLine();
                input = input.ToLower();

                switch (input)
                {
                    case "fight":
                        Monster monster = new Monster();
                        Fight(hero, monster);
                        break;
                    case "flee":
                        Console.WriteLine("Coward!");
                        break;
                    case "pizza":
                        Console.WriteLine("You feed a skeleton and win!");
                        hero.level--;
                        break;
                    default:
                        Console.WriteLine("You can only fight or flee");
                        break;
                }
            }

            Console.WriteLine("Game Over!");

            Console.ReadKey();

        }

        static void Fight(Player player, Monster monster)
        {
            BR();
            Console.WriteLine($"You fight a {monster.type} named {monster.name}!");

            while (player.IsAlive() && monster.IsAlive())
            {
                Thread.Sleep(2000);

                int playerDamage = player.AttackDamage();
                monster.TakeDamage(playerDamage);

                PW($"{player.name} hits {monster.name} for ");
                PR($"{playerDamage}");
                PW($" damage!");
                BR();

                if (monster.IsAlive())
                {
                    Thread.Sleep(2000);

                    int monsterDamage = monster.AttackDamage();
                    player.TakeDamage(monsterDamage);

                    PW($"{monster.name} hits {player.name} for ");
                    PR($"{monsterDamage}");
                    PW($" damage!");
                    BR();
                }
            }

            if (player.IsAlive())
            {
                Console.WriteLine($"You win!");
                player.level++;
            }
            else
            {
                Console.WriteLine($"You die!");
            }
        }

        static void PG(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PW(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }

        static void PR(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PY(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void BR()
        {
            Console.WriteLine();
        }
    }
}
