using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace GraphicalInterface.SimpleMapPainter
{
    [Serializable]
    public class SimpleRockPainter : IMapPainter
    {
        public static int ObjectCounter;
        public static int MemoryUsage;

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
         //   MemoryUsage += Marshal.SizeOf(this);

            ++ObjectCounter;
        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(paintBrush, X, Y, Width, Height);
        }
    }
}
