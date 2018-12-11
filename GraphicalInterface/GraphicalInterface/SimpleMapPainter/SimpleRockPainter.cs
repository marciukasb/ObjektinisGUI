using System.Drawing;

namespace GraphicalInterface.SimpleMapPainter
{
    public class SimpleRockPainter : IMapPainter
    {
        public static int ObjectCounter;

        private readonly Brush paintBrush;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public SimpleRockPainter(int x, int y, int width, int height)
        {
            paintBrush = Brushes.Gray;
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
