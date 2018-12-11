using System.Drawing;

namespace GraphicalInterface.SimpleMapPainter
{
    public class SimpleTreePainter : IMapPainter
    {
        public static int ObjectCounter;

        private readonly Brush paintBrush;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public SimpleTreePainter(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Green;
            X = x;
            Y = y;
            Width = width;
            Height = height;

            ++ObjectCounter;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(paintBrush, X, Y, Width, Height);
        }
    }
}
