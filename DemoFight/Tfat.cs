using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoFight.Properties;

namespace DemoFight
{
    // 胖子：50%可能不攻击以70%的效率双倍回血
    public class Tfat: LazyFighter
    {
        public Tfat()
        {
            Name = "天龙";
            Photo = Resources.Tfat;
        }

        public override void Attack(LazyFighter enemy)
        {
            int damage = LazyBase.GetRand(10, 0.2f);
            if (LazyBase.GetRand(0, 100) < 50)
            {
                this.Life += 2 * LazyBase.GetRand(7, 0.2f);
                if (this.Life > 100) this.Life = 100;
                Skill();
            }
            enemy.Suffer(this, damage);
        }
    }
}
