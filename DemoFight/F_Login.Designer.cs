namespace DemoFight
{
    partial class F_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Start = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Role1 = new System.Windows.Forms.ComboBox();
            this.CB_Role2 = new System.Windows.Forms.ComboBox();
            this.TB_User1 = new System.Windows.Forms.TextBox();
            this.TB_User2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.BackgroundImage = global::DemoFight.Properties.Resources.Saint;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.B_Start, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Exit, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CB_Role1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_Role2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_User1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_User2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 6);
            this.label3.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(3, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(673, 90);
            this.label3.TabIndex = 3;
            this.label3.Text = "506寝室之战";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // B_Start
            // 
            this.B_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Start.Location = new System.Drawing.Point(194, 341);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(140, 54);
            this.B_Start.TabIndex = 2;
            this.B_Start.Text = "开始";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Exit.Location = new System.Drawing.Point(344, 341);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(140, 54);
            this.B_Exit.TabIndex = 2;
            this.B_Exit.Text = "退出";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择角色1：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "请选择角色2：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Role1
            // 
            this.CB_Role1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Role1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Role1.FormattingEnabled = true;
            this.CB_Role1.Items.AddRange(new object[] {
            "狂战士",
            "圣战士",
            "幽灵战士",
            "天龙",
            "地虎"});
            this.CB_Role1.Location = new System.Drawing.Point(195, 224);
            this.CB_Role1.Margin = new System.Windows.Forms.Padding(6);
            this.CB_Role1.Name = "CB_Role1";
            this.CB_Role1.Size = new System.Drawing.Size(138, 39);
            this.CB_Role1.TabIndex = 0;
            // 
            // CB_Role2
            // 
            this.CB_Role2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Role2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Role2.FormattingEnabled = true;
            this.CB_Role2.Items.AddRange(new object[] {
            "狂战士",
            "圣战士",
            "幽灵战士",
            "天龙",
            "地虎"});
            this.CB_Role2.Location = new System.Drawing.Point(195, 274);
            this.CB_Role2.Margin = new System.Windows.Forms.Padding(6);
            this.CB_Role2.Name = "CB_Role2";
            this.CB_Role2.Size = new System.Drawing.Size(138, 39);
            this.CB_Role2.TabIndex = 0;
            // 
            // TB_User1
            // 
            this.TB_User1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_User1.Location = new System.Drawing.Point(492, 223);
            this.TB_User1.Name = "TB_User1";
            this.TB_User1.Size = new System.Drawing.Size(144, 39);
            this.TB_User1.TabIndex = 4;
            this.TB_User1.Text = "俊辉";
            // 
            // TB_User2
            // 
            this.TB_User2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_User2.Location = new System.Drawing.Point(492, 273);
            this.TB_User2.Name = "TB_User2";
            this.TB_User2.Size = new System.Drawing.Size(144, 39);
            this.TB_User2.TabIndex = 5;
            this.TB_User2.Text = "川哥";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "角色1姓名：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 1;
            this.label5.Text = "角色2姓名：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(683, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "F_Login";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Login";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CB_Role2;
        private System.Windows.Forms.ComboBox CB_Role1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.TextBox TB_User1;
        private System.Windows.Forms.TextBox TB_User2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}