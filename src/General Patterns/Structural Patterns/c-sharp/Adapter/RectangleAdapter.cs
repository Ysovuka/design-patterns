using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class RectangleAdapter : IRectangle
    {
        private LegacyRectangle _rectangle;
        public RectangleAdapter(int x1, int y1, int w, int h)
        {
            _rectangle = new LegacyRectangle(x1, y1, x1 + w, y1 + h);
        }

        public string Draw()
        {
            return _rectangle.Draw();
        }
    }
}
