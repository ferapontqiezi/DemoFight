namespace DemoFight
{
    partial class F_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.TLP_Base = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_Role2 = new System.Windows.Forms.TableLayoutPanel();
            this.PB_Skill2 = new System.Windows.Forms.PictureBox();
            this.PB_Suffer2 = new System.Windows.Forms.PictureBox();
            this.L_Role1 = new System.Windows.Forms.Label();
            this.L_VS = new System.Windows.Forms.Label();
            this.L_Role2 = new System.Windows.Forms.Label();
            this.L_Timer = new System.Windows.Forms.Label();
            this.RTB_Message = new System.Windows.Forms.RichTextBox();
            this.TLP_Role1 = new System.Windows.Forms.TableLayoutPanel();
            this.PB_Skill1 = new System.Windows.Forms.PictureBox();
            this.PB_Suffer1 = new System.Windows.Forms.PictureBox();
            this.PB_Life2 = new DemoFight.LazyLifeBox();
            this.PB_Life1 = new DemoFight.LazyLifeBox();
            this.T_Timer = new System.Windows.Forms.Timer(this.components);
            this.TLP_Base.SuspendLayout();
            this.TLP_Role2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Skill2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Suffer2)).BeginInit();
            this.TLP_Role1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Skill1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Suffer1)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP_Base
            // 
            this.TLP_Base.ColumnCount = 4;
            this.TLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.TLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Base.Controls.Add(this.TLP_Role2, 2, 2);
            this.TLP_Base.Controls.Add(this.L_Role1, 0, 0);
            this.TLP_Base.Controls.Add(this.L_VS, 1, 0);
            this.TLP_Base.Controls.Add(this.L_Role2, 2, 0);
            this.TLP_Base.Controls.Add(this.L_Timer, 3, 0);
            this.TLP_Base.Controls.Add(this.RTB_Message, 3, 2);
            this.TLP_Base.Controls.Add(this.TLP_Role1, 0, 2);
            this.TLP_Base.Controls.Add(this.PB_Life2, 2, 1);
            this.TLP_Base.Controls.Add(this.PB_Life1, 0, 1);
            this.TLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Base.Location = new System.Drawing.Point(0, 0);
            this.TLP_Base.Name = "TLP_Base";
            this.TLP_Base.RowCount = 3;
            this.TLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Base.Size = new System.Drawing.Size(1327, 529);
            this.TLP_Base.TabIndex = 0;
            // 
            // TLP_Role2
            // 
            this.TLP_Role2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_Role2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TLP_Role2.ColumnCount = 2;
            this.TLP_Role2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Role2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Role2.Controls.Add(this.PB_Skill2, 0, 0);
            this.TLP_Role2.Controls.Add(this.PB_Suffer2, 0, 1);
            this.TLP_Role2.Location = new System.Drawing.Point(424, 83);
            this.TLP_Role2.Name = "TLP_Role2";
            this.TLP_Role2.RowCount = 3;
            this.TLP_Role2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Role2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role2.Size = new System.Drawing.Size(295, 443);
            this.TLP_Role2.TabIndex = 8;
            // 
            // PB_Skill2
            // 
            this.PB_Skill2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Skill2.BackColor = System.Drawing.Color.Transparent;
            this.PB_Skill2.Image = global::DemoFight.Properties.Resources.Skill;
            this.PB_Skill2.Location = new System.Drawing.Point(0, 0);
            this.PB_Skill2.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Skill2.Name = "PB_Skill2";
            this.PB_Skill2.Size = new System.Drawing.Size(100, 100);
            this.PB_Skill2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Skill2.TabIndex = 5;
            this.PB_Skill2.TabStop = false;
            this.PB_Skill2.Visible = false;
            // 
            // PB_Suffer2
            // 
            this.PB_Suffer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Suffer2.BackColor = System.Drawing.Color.Transparent;
            this.TLP_Role2.SetColumnSpan(this.PB_Suffer2, 2);
            this.PB_Suffer2.Image = global::DemoFight.Properties.Resources.Suffer;
            this.PB_Suffer2.Location = new System.Drawing.Point(0, 100);
            this.PB_Suffer2.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Suffer2.Name = "PB_Suffer2";
            this.PB_Suffer2.Size = new System.Drawing.Size(295, 243);
            this.PB_Suffer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Suffer2.TabIndex = 5;
            this.PB_Suffer2.TabStop = false;
            this.PB_Suffer2.Visible = false;
            // 
            // L_Role1
            // 
            this.L_Role1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Role1.AutoSize = true;
            this.L_Role1.Location = new System.Drawing.Point(3, 4);
            this.L_Role1.Name = "L_Role1";
            this.L_Role1.Size = new System.Drawing.Size(295, 31);
            this.L_Role1.TabIndex = 2;
            this.L_Role1.Text = "Role1";
            this.L_Role1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_VS
            // 
            this.L_VS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_VS.AutoSize = true;
            this.L_VS.Font = new System.Drawing.Font("Cooper Black", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_VS.ForeColor = System.Drawing.Color.Navy;
            this.L_VS.Location = new System.Drawing.Point(304, 0);
            this.L_VS.Name = "L_VS";
            this.TLP_Base.SetRowSpan(this.L_VS, 2);
            this.L_VS.Size = new System.Drawing.Size(114, 80);
            this.L_VS.TabIndex = 1;
            this.L_VS.Text = "VS";
            this.L_VS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Role2
            // 
            this.L_Role2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Role2.AutoSize = true;
            this.L_Role2.Location = new System.Drawing.Point(424, 4);
            this.L_Role2.Name = "L_Role2";
            this.L_Role2.Size = new System.Drawing.Size(295, 31);
            this.L_Role2.TabIndex = 2;
            this.L_Role2.Text = "Role2";
            this.L_Role2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Timer
            // 
            this.L_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.L_Timer.AutoSize = true;
            this.L_Timer.BackColor = System.Drawing.Color.Navy;
            this.L_Timer.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Timer.ForeColor = System.Drawing.Color.Lime;
            this.L_Timer.Location = new System.Drawing.Point(725, 0);
            this.L_Timer.Name = "L_Timer";
            this.TLP_Base.SetRowSpan(this.L_Timer, 2);
            this.L_Timer.Size = new System.Drawing.Size(599, 80);
            this.L_Timer.TabIndex = 2;
            this.L_Timer.Text = "00:00:00";
            this.L_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTB_Message
            // 
            this.RTB_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Message.Location = new System.Drawing.Point(725, 83);
            this.RTB_Message.Name = "RTB_Message";
            this.RTB_Message.ReadOnly = true;
            this.RTB_Message.Size = new System.Drawing.Size(599, 443);
            this.RTB_Message.TabIndex = 4;
            this.RTB_Message.Text = "";
            // 
            // TLP_Role1
            // 
            this.TLP_Role1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_Role1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TLP_Role1.ColumnCount = 2;
            this.TLP_Role1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Role1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Role1.Controls.Add(this.PB_Skill1, 0, 0);
            this.TLP_Role1.Controls.Add(this.PB_Suffer1, 0, 1);
            this.TLP_Role1.Location = new System.Drawing.Point(3, 83);
            this.TLP_Role1.Name = "TLP_Role1";
            this.TLP_Role1.RowCount = 3;
            this.TLP_Role1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Role1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Role1.Size = new System.Drawing.Size(295, 443);
            this.TLP_Role1.TabIndex = 0;
            // 
            // PB_Skill1
            // 
            this.PB_Skill1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Skill1.BackColor = System.Drawing.Color.Transparent;
            this.PB_Skill1.Image = global::DemoFight.Properties.Resources.Skill;
            this.PB_Skill1.Location = new System.Drawing.Point(0, 0);
            this.PB_Skill1.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Skill1.Name = "PB_Skill1";
            this.PB_Skill1.Size = new System.Drawing.Size(100, 100);
            this.PB_Skill1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Skill1.TabIndex = 5;
            this.PB_Skill1.TabStop = false;
            this.PB_Skill1.Visible = false;
            // 
            // PB_Suffer1
            // 
            this.PB_Suffer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Suffer1.BackColor = System.Drawing.Color.Transparent;
            this.TLP_Role1.SetColumnSpan(this.PB_Suffer1, 2);
            this.PB_Suffer1.Image = global::DemoFight.Properties.Resources.Suffer;
            this.PB_Suffer1.Location = new System.Drawing.Point(0, 100);
            this.PB_Suffer1.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Suffer1.Name = "PB_Suffer1";
            this.PB_Suffer1.Size = new System.Drawing.Size(295, 243);
            this.PB_Suffer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_Suffer1.TabIndex = 5;
            this.PB_Suffer1.TabStop = false;
            this.PB_Suffer1.Visible = false;
            // 
            // PB_Life2
            // 
            this.PB_Life2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Life2.BackColor = System.Drawing.Color.Green;
            this.PB_Life2.ForeColor = System.Drawing.Color.Black;
            this.PB_Life2.Location = new System.Drawing.Point(424, 43);
            this.PB_Life2.MaxValue = 100;
            this.PB_Life2.Name = "PB_Life2";
            this.PB_Life2.Size = new System.Drawing.Size(295, 34);
            this.PB_Life2.TabIndex = 9;
            this.PB_Life2.Text = "lazyLifeBox1";
            this.PB_Life2.Value = 100;
            this.PB_Life2.ValueColor = System.Drawing.Color.Red;
            // 
            // PB_Life1
            // 
            this.PB_Life1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Life1.BackColor = System.Drawing.Color.Green;
            this.PB_Life1.ForeColor = System.Drawing.Color.Black;
            this.PB_Life1.Location = new System.Drawing.Point(3, 43);
            this.PB_Life1.MaxValue = 100;
            this.PB_Life1.Name = "PB_Life1";
            this.PB_Life1.Size = new System.Drawing.Size(295, 34);
            this.PB_Life1.TabIndex = 9;
            this.PB_Life1.Text = "lazyLifeBox1";
            this.PB_Life1.Value = 100;
            this.PB_Life1.ValueColor = System.Drawing.Color.Red;
            // 
            // T_Timer
            // 
            this.T_Timer.Interval = 1000;
            this.T_Timer.Tick += new System.EventHandler(this.T_Timer_Tick);
            // 
            // F_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1327, 529);
            this.Controls.Add(this.TLP_Base);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网安之王";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Main_FormClosed);
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.TLP_Base.ResumeLayout(false);
            this.TLP_Base.PerformLayout();
            this.TLP_Role2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Skill2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Suffer2)).EndInit();
            this.TLP_Role1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Skill1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Suffer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Base;
        private System.Windows.Forms.Label L_Role1;
        private System.Windows.Forms.Label L_VS;
        private System.Windows.Forms.Label L_Role2;
        private System.Windows.Forms.Label L_Timer;
        private System.Windows.Forms.RichTextBox RTB_Message;
        private System.Windows.Forms.PictureBox PB_Skill1;
        private System.Windows.Forms.Timer T_Timer;
        private System.Windows.Forms.TableLayoutPanel TLP_Role1;
        private System.Windows.Forms.PictureBox PB_Suffer1;
        private System.Windows.Forms.TableLayoutPanel TLP_Role2;
        private System.Windows.Forms.PictureBox PB_Skill2;
        private System.Windows.Forms.PictureBox PB_Suffer2;
        private LazyLifeBox PB_Life2;
        private LazyLifeBox PB_Life1;
    }
}

