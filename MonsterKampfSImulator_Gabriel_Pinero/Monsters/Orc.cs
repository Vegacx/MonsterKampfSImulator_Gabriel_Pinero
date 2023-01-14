using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.Monsters
{
    internal class Orc : MonsterMain
    {
        public Orc(float health, float damage, float speed) : base(health, damage, speed)
        {

        }

        public override string Name => "Orc";

        public override float Armor => 30;
        public override float ArmyMultiplier => 5;
    }
}
