using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoFight.Properties;

namespace DemoFight
{
    /// <summary>
    /// 狂战士类：50%可能性双倍攻击
    /// </summary>
    public class LazyZelot : LazyFighter
    {
        public LazyZelot()
        {
            Name = "狂战士";
            Photo = Resources.Zelot;
        }

        public override void Attack(LazyFighter enemy)
        {
            int damage = LazyBase.GetRand(10, 0.2f);
            if (LazyBase.GetRand(0, 100) < 50)
            {
                damage += LazyBase.GetRand(10, 0.2f);
                Skill();
            }
            enemy.Suffer(this, damage);
        }
    }
}
