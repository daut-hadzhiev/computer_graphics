using System;
using System.Drawing;

namespace Draw
{
    public class LineShape : Shape
    {
        #region Constructor

        public LineShape(RectangleF rect) : base(rect)
        {
        }

        public LineShape(LineShape line) : base(line)
        {
        }

        #endregion



        public override bool Contains(PointF point)
        {
            if (base.Contains(point))

                return true;
            else

                return false;
        }



        public override void DrawSelf(Graphics grfx)
        {

            base.DrawSelf(grfx);
            Pen pen = new Pen(BorderColor);
            pen.Width = 5.0F;

            grfx.DrawLine(pen, Rectangle.X, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);

            // Махаме химикала, след като вече сме нарисували фигурата
            pen.Dispose();
        }
    }
}
