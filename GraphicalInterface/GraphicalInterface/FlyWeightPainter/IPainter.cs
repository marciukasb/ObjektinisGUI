using System.Drawing;

namespace GraphicalInterface.FlyWeightPainter
{
    public interface IPainter
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}
