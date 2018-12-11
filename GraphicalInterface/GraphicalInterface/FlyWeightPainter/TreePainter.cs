using System.Drawing;

namespace GraphicalInterface.FlyWeightPainter
{
    public class TreePainter : IPainter
    {
        public static int ObjectCounter;

        private readonly Brush paintBrush;

        public TreePainter()
        {
            paintBrush = Brushes.Green;
            ++ObjectCounter;
        }

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }

}
