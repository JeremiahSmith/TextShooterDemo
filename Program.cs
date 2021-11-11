using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gun glock = new Gun() { GunName = "Glock", AmmoLoaded = 12, AmmoMax = 12, damage = 4 };
            Gun mouser = new Gun() { GunName = "Mouser", AmmoLoaded = 15, AmmoMax = 15, damage = 3};
            Gun bazuka = new Gun() { GunName = "Bazuka", AmmoLoaded = 2, AmmoMax = 2, damage = 5};
            Player player1 = new Player();

            string answer;


            Console.WriteLine("What is your player's name?");
            player1.Name = Console.ReadLine();

            Console.WriteLine("\nYou see something on the ground! Pick it up? Yes/No");
            answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Actions.PickupItem(player1, glock);
            }

            Console.WriteLine("\nYou see something else in the dirt! Pick it up? Yes/No");
            answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Actions.PickupItem(player1, mouser);

            }

            Console.WriteLine("\nYou see a third item on the ground! Pick it up? Yes/No");
            answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Actions.PickupItem(player1, bazuka);

            }

            Console.WriteLine("\nThere's a badguy!  Shoot'm? With what?\n[1] " + player1.Item1.GunName + "\n[2] " + player1.Item2.GunName + "\n[3] Don't shoot!");
            answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("You HIT!\nYou have " + Actions.Shoot(player1.Item1, 1) + " shots left.");
                    break;
                case "2":
                    Console.WriteLine("You HIT!\nYou have " + Actions.Shoot(player1.Item2, 1) + " shots left.");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
