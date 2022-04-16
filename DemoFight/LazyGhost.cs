using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoFight.Properties;

namespace DemoFight
{
    /// <summary>
    /// 幽灵战士类：20%可能性致命一击
    /// </summary>
    public class LazyGhost : LazyFighter
    {
        public LazyGhost()
        {
            Name = "幽灵战士";
            Photo = Resources.Ghost;
        }

        public override void Attack(LazyFighter enemy)
        {
            int damage = LazyBase.GetRand(10, 0.2f);
            if (LazyBase.GetRand(0, 100) < 20)
            {
                damage += (int)(enemy.Life * 0.3);
                Skill();
            }
            enemy.Suffer(this, damage);
        }
    }
}
