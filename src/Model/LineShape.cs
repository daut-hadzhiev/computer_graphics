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

            grfx.FillRectangle(new SolidBrush(Color.Black), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
