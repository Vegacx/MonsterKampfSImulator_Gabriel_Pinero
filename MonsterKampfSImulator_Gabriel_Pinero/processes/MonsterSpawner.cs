using MonsterKampfSImulator_Gabriel_Pinero.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.processes
{
    //Corrections
    // Make number of monster generated a variable instead of single float 

    // turn max and min values into variables and a function 
    // displays monsters values can also be turned into a function 
    //set monster combat dialogue line in monster class as a virtual protected variable 
    internal class MonsterSpawner
    {
        public List<MonsterMain> SpawnMonsters()
        {
            Console.WriteLine("Please select your monster of choice");
            Console.WriteLine("Press 1 for Orc");
            Console.WriteLine("Max health = 90");
            Console.WriteLine("Max damage = 15");
            Console.WriteLine("Max speed = 30");
            Console.WriteLine("Press 2 for Cthulhu");
            Console.WriteLine("Max health = 200");
            Console.WriteLine("Max damage = 200");
            Console.WriteLine("Max speed = 40");
            Console.WriteLine("Press 3 for Goblin");
            Console.WriteLine("Max health = 25");
            Console.WriteLine("Max damage = 5");
            Console.WriteLine("Max speed = 50");
            Console.WriteLine("Press 4 for Oni");
            Console.WriteLine("Max health = 60");
            Console.WriteLine("Max damage = 20");
            Console.WriteLine("Max speed = 40");

            float variation = 50f;
            Random random = new Random();
            List<MonsterMain> monsters = new List<MonsterMain>();

            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                float health;
                float damage;
                float speed;

                switch (key)
                {

                    case ConsoleKey.D1:
                        health = ReadNumberInput(1, 90, "Please choose your monster's HP");
                        damage = ReadNumberInput(1, 15, "Please choose your monster's damage");
                        speed = ReadNumberInput(1, 30, "Please choose your monster's speed");
                        

                        // Monsters will be generated until desired army value is reached
                        for ( int i = 0; i < 5; i++)
                        {
                            monsters.Add(new Orc(health + ((random.NextSingle()) * variation), damage + ((random.NextSingle())* 20), speed + ((random.NextSingle()) * 20)));
                        }

                        // Displays Monster's values(HP,Damage,Speed)
                        for (int i = 0; i < monsters.Count; i++)
                        {
                            Console.WriteLine($"Orc {i} has {monsters[i].Health} Hp {monsters[i].Damage} damage and {monsters[i].Speed} speed");
                        }

                        Console.WriteLine(" You shall perish under our might");

                        break;

                    case ConsoleKey.D2:
                        health = ReadNumberInput(1, 200, "Please choose your monster's HP");
                        damage = ReadNumberInput(1, 200, "Please choose your monster's damage");
                        speed = ReadNumberInput(1, 40, "Please choose your monster's speed");

                        for (int i = 0; i < 1; i++)
                        {
                            monsters.Add(new Cthulhu(health + ((random.NextSingle()) * variation), damage + ((random.NextSingle()) * 20), speed + ((random.NextSingle()) * 20)));
                        }


                        for (int i = 0; i < monsters.Count; i++)
                        {
                            Console.WriteLine($"Cthulhu {i} has {monsters[i].Health} Hp {monsters[i].Damage} damage and {monsters[i].Speed} speed");
                        }


                        Console.WriteLine("Cthulhu makes noises uncomprehensible for the human ear, you are now deaf.");

                        break;

                    case ConsoleKey.D3:
                        health = ReadNumberInput(1, 25, "Please choose your monster's HP");
                        damage = ReadNumberInput(1, 5, "Please choose your monster's damage");
                        speed = ReadNumberInput(1, 50, "Please choose your monster's speed");

                        
                        for (int i = 0; i < 25; i++)
                        {
                            monsters.Add(new Goblin(health + ((random.NextSingle()) * variation), damage + ((random.NextSingle()) * 20), speed + ((random.NextSingle()) * 20)));
                        }

                        for (int i = 0; i < monsters.Count; i++)
                        {
                            Console.WriteLine($"Goblin {i} has {monsters[i].Health} Hp {monsters[i].Damage} damage and {monsters[i].Speed} speed");
                        }
                        Console.WriteLine("We shall stab you... IN YOUR LEGS!");
                        
                        break;

                    case ConsoleKey.D4:
                        health = ReadNumberInput(1, 60, "Please choose your monster's HP");
                        damage = ReadNumberInput(1, 20, "Please choose your monster's damage");
                        speed = ReadNumberInput(1, 40, "Please choose your monster's speed");

                        
                        for (int i = 0; i < 10; i++)
                        {
                            monsters.Add(new Oni(health + ((random.NextSingle()) * variation), damage + ((random.NextSingle()) * 20), speed + ((random.NextSingle()) * 20)));
                        }

                        for (int i = 0; i < monsters.Count; i++)
                        {
                            Console.WriteLine($"Oni {i} has {monsters[i].Health} Hp {monsters[i].Damage} damage and {monsters[i].Speed} speed");
                        }
                        Console.WriteLine("I hate onions >:(");
                        break;

                        default:
                        continue;
                }
                break;
            }
            return monsters;

        }

        public float ReadNumberInput(float minValue, float maxValue, string message)
        {
            Console.WriteLine(message);
            while (true)
            {
                float value;
                if (float.TryParse(Console.ReadLine(), out value))
                {
                    if (value >= minValue && value <= maxValue)
                        return value;
                    else
                        Console.WriteLine("Please enter a number within range");
                }
                else
                    Console.WriteLine("Please write in a NUMBER");
            }
        }


    }
}
