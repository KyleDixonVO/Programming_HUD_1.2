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
        static string giantString = "Big Friendly Giant";
        static int weaponPickedUp = 0;
        static string currentWeapon = pistolString;
        static int damage;
        static int bandage = 15;
        static int painkiller = 35;
        static int medkit = 50;
        static int hp;
        static bool gameOver = false;

        static void ChangeWeapon(int weaponPickedUp)
        {

   
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
                currentWeapon = giantString;
            }
        }



        static void TakeDamage(int damage)
        {
            Random rd = new Random();
            damage = rd.Next(5, 30);

            health = health - damage;
            Console.WriteLine("> You take " + damage + " damage.");
            if (health < 0)
            {
                health = 0;
                gameOver = true;
            }
        }

        static void Heal(int hp)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            health = health + hp;
            if (health > 100)
            {
                health = 100;
            }
            Console.ResetColor();
        }

        static void HealthRange()
        {
            if (health > 0 && health < 10)
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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("> Health: " + health);
            HealthRange();
            Console.WriteLine("> Status: " + howBloodied);
            Console.WriteLine("> Current Weapon: " + currentWeapon);
            Console.WriteLine("");
            Console.ReadKey(true);
            Console.ResetColor();

        }

      

        static void Main(string[] args)
        {
            while (!gameOver)
            {
                ShowHUD();

                Console.WriteLine("> You unhook from the rappel rope as the chopper flies away.");
                Console.ReadKey(true);
                Console.WriteLine("> You secure your " + launcherString + "on your back and check the slide on your sidearm as you hear the sound of footsteps fast approaching.");
                Console.ReadKey(true);
                Console.WriteLine("> A shotgun blast rings out behind you and you wince as you're peppered with buckshot.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("> You fire back, killing your assailant in a few shots.");
                Console.ReadKey(true);
                Console.WriteLine("> You grab his " + shottyString + " off the ground and rack it.");
                weaponPickedUp = shotty;
                ChangeWeapon(weaponPickedUp);
                ShowHUD();
                Console.WriteLine("> You crouch behind a concrete barricade and wait as the footsteps draw near.");
                Console.ReadKey(true);
                Console.WriteLine("> You wait until the gunmen are almost upon, then rise out of cover and fire.");
                Console.ReadKey(true);
                Console.WriteLine("> Two of the gunmen fall and the other three return fire.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("> You use a bandage and then change cover, grabbing an " + uziString + " as you run.");
                weaponPickedUp = uzi;
                ChangeWeapon(weaponPickedUp);
                hp = bandage;
                Heal(hp);
                ShowHUD();
                Console.WriteLine("> You empty the magazine of the " + uziString + " into the three gunmen, felling them. You take a few rounds in the process.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("> You run across the street and into a hotel. You take the elevator to the meeting point on the roof.");
                Console.ReadKey(true);
                Console.WriteLine("> As the doors open you're met by a gunman on the other side.");
                Console.ReadKey(true);
                Console.WriteLine("> He draws a knife and you grapple for a short moment. He gets a deep cut on you before you wrestle the knife from him and end him.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("> You grab his " + sniperString + " as you step over his body.");
                weaponPickedUp = sniper;
                ChangeWeapon(weaponPickedUp);
                ShowHUD();
                Console.WriteLine("> You sight in the sniper scope on the top floor of the apartment building next to you.");
                Console.ReadKey(true);
                Console.WriteLine("> You spot him: Baron Mc'Evil. You follow him with your crosshair, and after a moment you take your shot.");
                Console.ReadKey(true);
                Console.WriteLine("> The Baron drops to the ground with the impact");
                Console.ReadKey(true);
                Console.WriteLine("> You take the stairs to the ground floor of the hotel, and on arrival you hear the rumbling of an approaching tank");
                Console.ReadKey(true);
                Console.WriteLine("> You unsling the rotary " + launcherString + "from your back, spin the drum, and wait.");
                weaponPickedUp = nadeLauncher;
                ChangeWeapon(weaponPickedUp);
                ShowHUD();
                Console.WriteLine("> The tank pulls into view and you fire, the first nade ruins the treads, the second hits the pivot of the main cannon.");
                Console.ReadKey(true);
                Console.WriteLine("> You fire your third grenade as the cannon fires with a deafening boom, you are thrown as the shell goes off behind you.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("> You open your eyes, your ears are ringing, the tank is a twisted funeral pyre.");
                Console.ReadKey(true);
                Console.WriteLine("> You limp to the exfil point down the block. You're losing blood.");
                TakeDamage(damage);
                ShowHUD();
                Console.WriteLine("You see the chopper in the distance, you take a knee by the clearing.");
                Console.ReadKey(true);
                Console.WriteLine("The helecopter is nearly overhead when the Baron's voice rings out.");
                Console.ReadKey(true);
                Console.WriteLine("'You thought I would be so easily dealt with?' he taunts from his mech suit");
                Console.ReadKey(true);
                Console.WriteLine("The chopper hovers overhead, something is dropped from it.");
                Console.ReadKey(true);
                Console.WriteLine("You catch the object: The " + giantString + ". You watch The Baron's face lose color as you charge the weapon.");
                weaponPickedUp = bigFriendlyGiant;
                ChangeWeapon(weaponPickedUp);
                ShowHUD();
                Console.WriteLine("The " +giantString + " looses a massive blast of plasma, obliterating The Baron and his mech.");
                Console.ReadKey(true);
                Console.WriteLine("The rappel rope descends, you hook up and light up a cigar, another sucessful mission.");
                Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("YOU WIN!");

                Console.ReadKey(true);
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("YOU DIED!!!");
            Console.WriteLine("Game Over!");
            Console.ReadKey(true);
        }
    }
}
