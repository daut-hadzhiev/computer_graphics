using System;
using System.Drawing;

namespace Draw
{
    public class ElipseShape : Shape
    {
        #region Constructor

        public ElipseShape(RectangleF rect) : base(rect)
        {
        }

        public ElipseShape(ElipseShape elipse) : base(elipse)
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

            Pen pen = new Pen(Brushes.Red);
            pen.Width = 1.5F;

            grfx.FillEllipse(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawEllipse(pen, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            
            // Махаме химикала, след като вече сме нарисували фигурата
            pen.Dispose();
        }
    }
}
