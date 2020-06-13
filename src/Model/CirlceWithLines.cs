using System;
using System.Drawing;

namespace Draw
{
    public class CirlceWithLines : Shape
    {
        #region Constructor

        public CirlceWithLines(RectangleF rect) : base(rect)
        {
        }

        public CirlceWithLines(CirlceWithLines elipse) : base(elipse)
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
            pen.Width = 1F;

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            


            grfx.DrawLine(pen, Rectangle.X + 10, Rectangle.Y + 22, Rectangle.X + Rectangle.Width - 5, Rectangle.Y + Rectangle.Height - 33);

            grfx.DrawLine(pen, Rectangle.X + 1, Rectangle.Y + 50, Rectangle.X + Rectangle.Width - 15, Rectangle.Y + Rectangle.Height - 10);
            // Махаме химикала, след като вече сме нарисували фигурата
            pen.Dispose();
        }
    }
}
