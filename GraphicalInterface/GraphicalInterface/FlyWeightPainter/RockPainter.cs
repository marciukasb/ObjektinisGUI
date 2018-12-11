using System;
using System.Drawing;

namespace GraphicalInterface.FlyWeightPainter
{
    [Serializable]
    public class RockPainter : IPainter
    {
        public static int ObjectCounter;

        private readonly Brush paintBrush;

        public RockPainter()
        {
            paintBrush = Brushes.Gray;
            ++ObjectCounter;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}
