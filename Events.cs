using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Events
    {
        public static void Attack(Player hero, Player badguy)
        {
            Console.WriteLine("\nThere's a " + badguy.Name + "!  Shoot'm? With what?\n[1] " + hero.Item1.GunName + "\n[2] " + hero.Item2.GunName + "\n[3] Don't shoot!");
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "1":
                    Actions.Shoot(hero.Item1, 1, badguy);
                    break;
                case "2":
                    Actions.Shoot(hero.Item2, 1, badguy);
                    break;
                default:
                    Console.WriteLine("You don't shoot.");
                    break;
            }
        }

        public static void PickUpItem(Player hero, Gun gun )
        {
            Console.WriteLine("\nYou see an item on the ground! Pick it up? Yes/No");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Actions.PickupItem(hero, gun);

            }
        }
    }
}
