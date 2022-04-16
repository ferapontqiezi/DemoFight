using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DemoFight.Properties;
using System.Threading;
using System.Reflection;

namespace DemoFight
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
            PropertyInfo pi = typeof(TableLayoutPanel).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(TLP_Role1, true, null);
            pi.SetValue(TLP_Role2, true, null);
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        private DateTime startTime = DateTime.Now;

        /// <summary>
        /// 计数器
        /// </summary>
        private int count = 0;        

        /// <summary>
        /// 角色1
        /// </summary>
        public LazyFighter Fighter1 { get; set; }

        /// <summary>
        /// 角色2
        /// </summary>
        public LazyFighter Fighter2 { get; set; }

        private void F_Main_Load(object sender, EventArgs e)
        {            
            L_Role1.Text = string.Format("{0}（{1}）", Fighter1.UserName, Fighter1.Name);
            L_Role2.Text = string.Format("{0}（{1}）", Fighter2.UserName, Fighter2.Name);

            PB_Life1.MaxValue = Fighter1.Life;
            PB_Life2.MaxValue = Fighter2.Life;
            PB_Life1.Value = Fighter1.Life;
            PB_Life2.Value = Fighter2.Life;

            TLP_Role1.BackgroundImage = Fighter1.Photo;
            TLP_Role2.BackgroundImage = Fighter2.Photo;

            Fighter1.OnSkillUsed += new OnSkillUsedEventHandler(Fighter1_OnSkillUsed);
            Fighter2.OnSkillUsed += new OnSkillUsedEventHandler(Fighter2_OnSkillUsed);
            T_Timer.Start();
        }

        private void Fighter2_OnSkillUsed(LazyFighter fighter)
        {
            PB_Skill2.Visible = true;
        }

        private void Fighter1_OnSkillUsed(LazyFighter fighter)
        {
            PB_Skill1.Visible = true;
        }

        private void T_Timer_Tick(object sender, EventArgs e)
        {  
            L_Timer.Text = DateTime.Now.Subtract(startTime).ToString("hh\\:mm\\:ss");
            count++;
            if (count % 2 == 0)
            {
                PB_Skill1.Visible = false;
                PB_Skill2.Visible = false;
                PB_Suffer1.Visible = false;
                PB_Suffer2.Visible = false;
            }
            string msg = string.Empty;
            LazyFighter winner = null;
            LazyFighter loser = null;
            bool gameOver = false;
            if (count % 4 == 1)
            {
                Fighter2.Attack(Fighter1);
                PB_Suffer1.Visible = true;
                
                
                msg = string.Format("{0}攻击，{1}剩余生命：{2}", Fighter2, Fighter1, Fighter1.Life);
                AppendText(msg);
                if (Fighter1.Life == 0)
                {
                    winner = Fighter2;
                    loser = Fighter1;
                    gameOver = true;
                }

            }
            else if (count % 4 == 3)
            {
                Fighter1.Attack(Fighter2);
                PB_Suffer2.Visible = true;
                
                msg = string.Format("{0}攻击，{1}剩余生命：{2}", Fighter1, Fighter2, Fighter2.Life);
                AppendText(msg);
                if (Fighter2.Life == 0)
                {
                    winner = Fighter1;
                    loser = Fighter2;
                    gameOver = true;
                }
            }
            PB_Life1.Value = Fighter1.Life;
            PB_Life2.Value = Fighter2.Life;
            if (gameOver)
            {
                T_Timer.Stop();
                msg = string.Format(Resources.GameOver, DateTime.Now.Subtract(startTime).ToString("hh\\:mm\\:ss"),
                    winner.UserName, loser.UserName);
                MessageBox.Show(this, msg, "游戏结束", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }        

        /// <summary>
        /// 显示文字信息
        /// </summary>
        /// <param name="msg">文字信息</param>
        private void AppendText(string msg)
        {
            //添加时间信息
            msg = string.Format("{0}    {1}\n", DateTime.Now.Subtract(startTime).ToString("hh\\:mm\\:ss"), msg);
            RTB_Message.AppendText(msg);
            //将光标移到文本末尾
            RTB_Message.SelectionStart = RTB_Message.Text.Length;
            RTB_Message.ScrollToCaret();
        }
    }
}
