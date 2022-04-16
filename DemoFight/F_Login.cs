using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace DemoFight
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private LazyFighter GetFighter(int idx)
        {
            switch (idx)
            {
                case 0:
                    return new LazyZelot();
                case 1:
                    return new LazySaint();
                case 2:
                    return new LazyGhost();
                default:
                    return null;
            }
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            CB_Role2.SelectedIndex = 0;
            CB_Role1.SelectedIndex = 0;
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            F_Main fm = new F_Main();
            fm.Fighter1 = GetFighter(CB_Role1.SelectedIndex);
            fm.Fighter2 = GetFighter(CB_Role2.SelectedIndex);
            if (fm.Fighter1 != null && fm.Fighter2 != null)
            {
                fm.Fighter1.UserName = TB_User1.Text;
                fm.Fighter2.UserName = TB_User2.Text;
                fm.Show(this);
                Hide();
            }
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
