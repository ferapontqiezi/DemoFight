using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DemoFight
{
    public class LazyLifeBox : Control
    {
        public LazyLifeBox()
        {
            ValueColor = Color.Red;
            ForeColor = Color.Black;
            BackColor = Color.Green;
        }

        private int _MaxValue = 100;
        /// <summary>
        /// 满值
        /// </summary>
        public int MaxValue
        {
            get { return _MaxValue; }
            set
            {
                _MaxValue = Math.Max(1, value);
                Invalidate();

            }
        }

        private int _Value = 100;
        /// <summary>
        /// 当前值
        /// </summary>
        public int Value
        {
            get { return _Value; }
            set
            {
                _Value = Math.Max(0, value);
                Invalidate();

            }
        }

        /// <summary>
        /// 值颜色
        /// </summary>
        public Color ValueColor { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            Rectangle rect = e.ClipRectangle;
            rect.Width = rect.Width * Value / MaxValue;
            e.Graphics.FillRectangle(new SolidBrush(ValueColor), rect);

            TextRenderer.DrawText(e.Graphics, Value.ToString(), Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
