using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System
{
	class Program
	{
		static int health;
		static int damageTaken;
		static int dealtDamage;
		static int healthRegen;
		static int shield;
		static int shieldRegen;
		static int lives = 3;
		static System.Random random = new System.Random();
		static string[] weapon;
		static int[] ammo;
		static string currentWeapon;
		


		static void ShowHUD()
		{
			Console.WriteLine("#################################################");
			Console.WriteLine("health: " + health, "Lives: " + lives, "Shield: " + shield);
			Console.WriteLine("");
			Console.WriteLine("Ammo:" + ammo, "Current weapon: " + currentWeapon);
			Console.WriteLine("#################################################");
		}

		static void Health()
		{
			health = 100;

			if (health <= 0)
			{
				lives = lives - 1;
			}
			if (lives == 0)
			{
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+                                             +");
				Console.WriteLine("+             Game Over You Suck              +");
				Console.WriteLine("+                                             +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
			}
		}

		static void HealRegen()
		{
			if (health >= 20)
			{
				Console.WriteLine("WOuld You Like Some Health? Y/N");
				string userHealth = Console.ReadLine();
				if (userHealth == "Y")
				{
					health = health + 25;
				}
				if (userHealth == "N")
				{
					health = health + 0;
				}
			}
		}

		static void Shield()
		{
			shield = 50;
		}

		static void ShieldRegen()
		{
			if (shield >= 5)
			{
				Console.WriteLine("WOuld You Like A Shield Pot? Y/N");
				string user = Console.ReadLine();
				if (user == "Y")
				{
					shield = shield + 15;
				}
				if (user == "N")
				{
					shield = shield + 0;
				}
			}
		}

		static void TakeDamage()
		{
			damageTaken = random.Next(0, 30);

			shield = shield - damageTaken;

			if (shield >= 0)
			{
				health = health - damageTaken;
			}
		}


		static void DamageDelt()
		{
			damageTaken = random.Next(5, 50);

			
		}


		static void Weapon()
		{
			weapon = new string[3];

			weapon[0] = "Fists";
			weapon[1] = "pistol";
			weapon[2] = "Pump ShotGun";
			weapon[3] = "Ballistic Assault Rifle";

			ammo = new int[3];
			ammo[0] = 999999999;
			ammo[1] = 8;
			ammo[2] = 6;
			ammo[3] = 24;


		}

		static void TestGamePlay()
		{
			


		}

		static void ChangeWeapon()
		{
			Console.WriteLine("Would You Like To Change Weapon?? If So Choose A Number Bwtween 0 and 3");
			string Weapon = Console.ReadLine();

			if (Weapon == "0")
			{
				currentWeapon = "Fists";
			}
			if (Weapon == "1")
			{
				currentWeapon = "Pistol";
			}
			if (Weapon == "2")
			{
				currentWeapon = "Pump ShotGun";
			}
			if (Weapon == "3")
			{
				currentWeapon = "Ballistic Assault Rifle";
			}
		}

		static void Monster()
		{
			
		}

		static void Main(string[] args)
		{

		}
	}
}
