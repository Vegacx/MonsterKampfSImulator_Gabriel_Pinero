using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.Monsters
{
    internal class Goblin : MonsterMain
    {
        public Goblin(float health, float damage, float speed) : base(health, damage, speed)
        {

        }

        public override string Name => "Goblin";


        public override float Armor => 0;
        public override float CritHit => 0;
        public override float AttackMultiplier => 0;
        public override float ArmyMultiplier => 25f;
    }
}
