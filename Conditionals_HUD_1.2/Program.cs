using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_HUD_1._2
{
    class Program
    {
        static int health = 100;
        static string howBloodied;
        static int weapon = 0;
        static int pistol = 0;
        static string pistolString = "pistol";
        static int shotty = 1;
        static string shottyString = "shotty";
        static int uzi = 2;
        static string uziString = "uzi";
        static int sniper = 3;
        static string sniperString = "sniper";
        static int nadeLauncher = 4;
        static string launcherString = "nade launcher";
        static int bigFriendlyGiant = 5;
        static string giantSting = "big friendly giant";
        static int weaponPickedUp = 0;
        static string currentWeapon = pistolString;
        static int damage;
        static int hp;

        static void ChangeWeapon(int weaponPickedUp)
        {

            weaponPickedUp = weaponPickedUp++;
            if (weaponPickedUp == 1)
            {
                currentWeapon = shottyString;

            }
            else if (weaponPickedUp == 2)
            {
                currentWeapon = uziString;
            }
            else if (weaponPickedUp == 3)
            {
                currentWeapon = sniperString;
            }
            else if (weaponPickedUp == 4)
            {
                currentWeapon = launcherString;
            }
            else if (weaponPickedUp == 5)
            {
                currentWeapon = giantSting;
            }
        }
        
       

        static void TakeDamage(int damage)
        {
            Random rd = new Random();
            damage = rd.Next(5, 30);

            health = health - damage;
            if (health < 0)
            {
                health = 0;
            }
        }

        static void Heal(int hp)
        {
            health = health + 50;
            if (health > 100)
            {
                health = 100;
            }
        }

        static void HealthRange()
        {
            if (health >0 && health <10)
            {
                howBloodied = "Death's Door";
            }
            else if (health >= 10 && health < 50)
            {
                howBloodied = "That's a Lot of Blood";
            }
            else if (health >= 50 && health < 75)
            {
                howBloodied = "Only a Flesh Wound";
            }
            else if (health >= 75 && health < 100)
            {
                howBloodied = "Tis But a Scratch";
            }
            else if (health >= 100)
            {
                health = 100;
                howBloodied = "Flawless Health";
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("Health: " + health);
            HealthRange();
            Console.WriteLine(howBloodied);
            Console.WriteLine("Current Weapon: " + currentWeapon);
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
        }
    }
}
