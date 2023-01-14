using MonsterKampfSImulator_Gabriel_Pinero.Monsters;
using MonsterKampfSImulator_Gabriel_Pinero.processes;


namespace MonsterKampfSImulator_Gabriel_Pinero
{
    public class Program
    {
        static void Main()
        {
            MonsterSpawner spawner = new MonsterSpawner();
            List<MonsterMain> playerGeneratedMonsters = spawner.SpawnMonsters();
            List<MonsterMain> cpuGeneratedMonsters = spawner.SpawnMonsters();

            FightingSystem fight = new FightingSystem();

            fight.Fight(playerGeneratedMonsters, cpuGeneratedMonsters);
        }      
    }
}