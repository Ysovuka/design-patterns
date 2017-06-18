using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyRectangle
    {
        public LegacyRectangle(int x1, int y1, int x2, int y2)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
        }

        public string Draw()
        {
            return $"({_x1},{_y1}) => ({_x2},{_y2})";
        }

        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;
    }
}
