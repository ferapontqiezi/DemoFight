using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DemoFight
{
    [Serializable]
    public abstract class LazyFighter
    {

        public LazyFighter()
        {
            Life = 100;
        }

        #region 事件
        public event OnSkillUsedEventHandler OnSkillUsed;
        #endregion

        #region 属性
        /// <summary>
        /// 生命值
        /// </summary>
        public int Life { get; protected set; }

        /// <summary>
        /// 角色名
        /// </summary>        
        public string Name { get; protected set; }

        /// <summary>
        /// 用户名
        /// </summary>        
        public string UserName { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public Image Photo { get; set; }
        #endregion

        #region 方法
        /// <summary>
        /// 攻击
        /// </summary>
        /// <param name="enemy">对手</param>
        public abstract void Attack(LazyFighter enemy);

        public virtual void Suffer(LazyFighter attacker, int damage)
        {
            Life = Math.Max(0, Life - damage);
        }

        public void Skill()
        {
            if (OnSkillUsed != null)
                OnSkillUsed(this);
        }

        public override string ToString()
        {
            return UserName;
        }
        #endregion
    }
}
