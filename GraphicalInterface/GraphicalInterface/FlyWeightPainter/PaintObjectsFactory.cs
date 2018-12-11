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
                case "RockPaint":
                    if (!paints.ContainsKey("RockPaint"))
                        paints["RockPaint"] = new RockPainter();
                    return paints["RockPaint"];
                case "TreePaint" :
                    if (!paints.ContainsKey("TreePaint"))
                        paints["TreePaint"] = new TreePainter();
                    return paints["TreePaint"];
            }
            return null;
        }
    }
}
