using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.Monsters
{
    internal class Cthulhu : MonsterMain
    {
        public Cthulhu(float health, float damage, float speed) : base(health, damage, speed)
        {

        }


        public override string Name => "Cthulhu";

        public override float Armor => 0;

        public override float AttackMultiplier => 0;

        public override float CritHit => 0;
        public override float ArmyMultiplier => 1;
    }
}
