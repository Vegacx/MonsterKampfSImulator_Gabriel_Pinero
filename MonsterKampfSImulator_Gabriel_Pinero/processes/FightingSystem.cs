using MonsterKampfSImulator_Gabriel_Pinero.Monsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.processes
{
    internal class FightingSystem
    {
      public void Fight(List<MonsterMain> playerMonsters, List<MonsterMain> cpuMonsters)
      {
            int currentPlayerMonsterNumber = 0;
            int currentCpuMonsterNumber = 0;

            while (true)
            {
                MonsterMain playerMonster = playerMonsters[currentPlayerMonsterNumber];
                MonsterMain cpuMonster = cpuMonsters[currentCpuMonsterNumber];

                Console.WriteLine("========= Fighting Begins! =========");
                Console.WriteLine($"{playerMonster.Name} {currentPlayerMonsterNumber} vs. {cpuMonster.Name} {currentCpuMonsterNumber}");
                Console.WriteLine("====================================");

                playerMonsters[currentPlayerMonsterNumber].Attack(cpuMonsters[currentCpuMonsterNumber]);

                if (playerMonster.IsDead)
                {

                    Console.WriteLine($"{playerMonster.Name} has been defeated");
                    currentPlayerMonsterNumber++;
                }

                if (cpuMonster.IsDead)
                {
                    Console.WriteLine($"{cpuMonster.Name} has been defeated");
                    currentCpuMonsterNumber++;
                }

                if (currentPlayerMonsterNumber >= playerMonsters.Count)
                {
                    Console.WriteLine("CPU wins");
                    break;
                }

                if (currentCpuMonsterNumber >= cpuMonsters.Count)
                {
                    Console.WriteLine("Player wins");
                    break;
                }
            }

      }
    }
}
