using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoFight.Properties;

namespace DemoFight
{
    /// <summary>
    /// 圣战士类：50%几率闪避
    /// </summary>
    public class LazySaint : LazyFighter
    {
        public LazySaint()
        {
            Name = "圣战士";
            Photo = Resources.Saint;
        }

        public override void Attack(LazyFighter enemy)
        {
            int damage = LazyBase.GetRand(15, 0.2f);
            
            enemy.Suffer(this, damage);
        }

        public override void Suffer(LazyFighter attacker, int damage)
        {
            if (LazyBase.GetRand(0, 100) < 50)
            {
                damage = (int)(damage * 0.7);
                Skill();
            }
            base.Suffer(attacker, damage);
        }
    }
}
