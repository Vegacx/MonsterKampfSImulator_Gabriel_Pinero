using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.Monsters
{
    internal class Oni : MonsterMain
    {
        public Oni(float health, float damage, float speed) : base(health, damage, speed)
        {

        }



        public override string Name => "Oni";

        public override float Armor => 7;
        public override float ArmyMultiplier => 10;
    }
}
