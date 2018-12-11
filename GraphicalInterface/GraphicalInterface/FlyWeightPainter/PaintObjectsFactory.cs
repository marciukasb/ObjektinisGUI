using System.Collections.Generic;

namespace GraphicalInterface.FlyWeightPainter
{
    public class PaintObjectsFactory
    {
        static Dictionary<string, IPainter> paints = new Dictionary<string, IPainter>();

        public static IPainter GetPaint(string paintType)
        {
            switch(paintType)
            {
                case "HousePaint" :
                    if (!paints.ContainsKey("HousePaint"))
                        paints["HousePaint"] = new RockPainter();
                    return paints["HousePaint"];
                case "TreePaint" :
                    if (!paints.ContainsKey("TreePaint"))
                        paints["TreePaint"] = new TreePainter();
                    return paints["TreePaint"];
            }
            return null;
        }
    }
}
