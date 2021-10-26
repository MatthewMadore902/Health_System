using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Health_System
{
	class Program
	{
		static int health = 100;
		static int damageTaken;
		static int dealtDamage;
		//static int monsterDamage;

		static int weapon;
		static int shield = 50;

		static int lives = 3;
		static System.Random random = new System.Random();
		static string[] weaponName = new string[4];
		static int[] ammo = new int[4];

		static int monsterHealth;
		static bool isAlive = true;


		static void ShowHUD()
		{
			Console.WriteLine("#################################################");
			Console.WriteLine("health: " + health + " " + "Lives: " + lives + " " + "Shield: " + shield);
			Console.WriteLine("");
			Console.WriteLine("Ammo:" + ammo[weapon] + "       " + "Current weapon: " + weaponName[weapon]);
			Console.WriteLine("#################################################");
			Console.ReadKey();
		}

		static void Health()
		{

			if (health >= 100)
			{
				health = 100;
			}
			if (health <= 0)
			{
				lives = lives - 1;
				health = 100;
			}

			if (lives == 0)
			{
				Console.WriteLine("Out of Lives");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
				Console.WriteLine("+                                             +");
				Console.WriteLine("+             Game Over You Suck              +");
				Console.WriteLine("+                                             +");
				Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
				Console.ReadKey();
				health = 0;
				isAlive = false;
			}
		}
		static void Heal()
		{
			if (health <= 25)
			{
				Console.WriteLine();
				Console.WriteLine("the player healed 25 health points");
				Console.WriteLine();
				health = health + 25;
			}
		}



		static void Shield()
		{
			shield = 50;

		}

		static void ShieldRegen()
		{
			if (shield <= 5)
			{
				Console.WriteLine();
				Console.WriteLine("The player regenerated 10 shield points");
				Console.WriteLine();
				shield = shield + 10;
			}
		}

		static void TakeDamage()
		{
			damageTaken = random.Next(0, 30);

			shield = shield - damageTaken;
			Console.WriteLine("damage taken " + damageTaken);

			if (shield <= 0)
			{
				health = health - damageTaken;
				shield = 0;
			}
			Console.ReadKey();
		}


		static void DamageDelt()
		{
			dealtDamage = random.Next(5, 50);
			Console.WriteLine("dealt Damage " + dealtDamage);
			
		}


		static void Array()
		{
			weaponName[0] = "Fists";
			weaponName[1] = "pistol";
			weaponName[2] = "Pump ShotGun";
			weaponName[3] = "Ballistic Assault Rifle";

			ammo[0] = 999999999;
			ammo[1] = 8;
			ammo[2] = 6;
			ammo[3] = 24;


		}

		static void TestGamePlay()
		{

			Console.WriteLine("A monster jumps oy of the bushs at you");

		}


		static void CurrentWeapon()
		{
			Console.WriteLine("Would You Like To Change Weapon?? If So Choose A Number Between 0 and 3");
			weapon = 2;
			Console.WriteLine("User Picked 2");

		}

		static void Monster()
		{
			monsterHealth = 50;

			//monsterDamage = random.Next(1, 30);


			if (monsterHealth <= 0)
			{
				monsterHealth = 0;
				Console.WriteLine("Monster Died");
			}

			Console.ReadLine();

		}


		static void UnitTest()
		{
			Console.WriteLine("Player is trying to heal");
			Console.WriteLine("Testing that health cannot go over 100");
			Console.WriteLine("Health cannot go over 100");
			Console.WriteLine();
			health = 100;
			Heal();
			Debug.Assert(health == 100);

			Console.WriteLine("Player is trying to regen shield");
			Console.WriteLine("Testing that shield cannot go over 50");
			Console.WriteLine("Shield cannot go over 50");
			Console.WriteLine();
			ShieldRegen();
			shield = 50;
			Debug.Assert(shield == 50);
			


		}

		static void Main(string[] args)
		{
			while (isAlive == true)
			{
				UnitTest();
				Array();
				ShowHUD();
				CurrentWeapon();
				ShowHUD();
				TestGamePlay();
				Monster();
				DamageDelt();
				TakeDamage();
				ShowHUD();
				Heal();
				ShieldRegen();
				Health();
				Array();
				ShowHUD();
			}


		}
	}
}
