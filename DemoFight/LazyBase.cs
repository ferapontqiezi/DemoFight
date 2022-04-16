using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoFight
{
    /// <summary>
    /// 特技使用事件句柄
    /// </summary>
    /// <param name="winner"></param>
    /// <param name="loser"></param>
    public delegate void OnSkillUsedEventHandler(LazyFighter fighter);

    public class LazyBase
    {
        private static Random rand = new Random(DateTime.Now.Millisecond);

        public static int GetRand(int min, int max)
        {
            return rand.Next(min, max);
        }

        public static float GetRand(float min, float max)
        {
            return min + (float)rand.NextDouble() * (max - min);
        }

        public static int GetRand(int value, float range)
        {
            double ratio = GetRand(1 - range, 1 + range);
            return (int)(value * ratio);
        }
    }
}
