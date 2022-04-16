using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoFight.Properties;

namespace DemoFight
{
    // 瘦子：每过一轮伤害系数加10%
    public class Thin : LazyFighter
    {
        public double c = 1.0;

        public Thin()
        {
            Name = "地虎";
            Photo = Resources.Thin;
        }

        public override void Attack(LazyFighter enemy)
        {
            int damage = LazyBase.GetRand(10, 0.2f);
            c += 0.1;
            if (LazyBase.GetRand(0, 100) < 50)
            {
                damage += (int)c * LazyBase.GetRand(10, 0.2f);
                Skill();
            }
            enemy.Suffer(this, damage);
        }
    }
}
