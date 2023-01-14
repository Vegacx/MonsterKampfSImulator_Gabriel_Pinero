using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterKampfSImulator_Gabriel_Pinero.Monsters
{
    internal abstract class MonsterMain
    {
        public virtual string Name { get; protected set; }
        public float Health { get; protected set; }
        public float Damage { get; protected set; }
        public float Speed { get; protected set; }
        public virtual float Armor { get; protected set; }

        public virtual float AttackMultiplier { get; protected set; }

        public virtual float CritHit { get; protected set; }

        public virtual float ArmyMultiplier { get; protected set; }

        protected MonsterMain(float health, float damage, float speed)
        {
            this.Health = health;
            this.Damage = damage;
            this.Speed = speed;
        }

        


        //we take damage
        public virtual void TakeDamage(float damage)
        {
            float effectiveDamage = (damage * ArmyMultiplier) - Armor;
            if (Armor >= damage)
            {
                effectiveDamage = 0;
            }
            
            Health -= effectiveDamage;
            Console.WriteLine(Name + " takes " + effectiveDamage + " damage points");

        }


        // Apply damage to target
        public void Attack(MonsterMain target)
        {
            // if target is faster target attacks first
            if (Speed < target.Speed)
            {
                TakeDamage(target.Damage);
                if (IsDead == false)
                {
                    target.TakeDamage(Damage);
                }
                
            }

            //if we are faster we attack first
            if (Speed > target.Speed)
            {
                target.TakeDamage(Damage);
                if (target.IsDead == false)
                {
                    TakeDamage(target.Damage);
                }
            }

            //if we have the same speed, we both hit each other at the same time
            if (Speed == target.Speed)
            {
                target.TakeDamage(Damage);
                TakeDamage(target.Damage);
            }
            

            Console.WriteLine(Name + " has now " + Health + " HP left");
            Console.WriteLine(target.Name + " has " + target.Health + " HP left");
            

        }
        public bool IsDead
        {
            get
            {
                return Health <= 0;
            }
        }
        
    }
}
