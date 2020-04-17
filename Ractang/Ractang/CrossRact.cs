using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CrossRact
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public int x3;
        public int y3;
        public int x4;
        public int y4;

        public CrossRact(int rx1, int ry1, int rx2, int ry2, int rx3, int ry3, int rx4, int ry4)
        {
            this.x1 = rx1;
            this.y1 = ry1;
            this.x2 = rx2;
            this.y2 = ry2;
            this.x3 = rx3;
            this.y3 = ry3;
            this.x4 = rx4;
            this.y4 = ry4;
        }
        public int result()
        {
            Rectangle b = new Rectangle(x3, y3, x4, y4);
            Rectangle a = new Rectangle(x1, y1, x2, y2);
            return GetRectanglesIntersectionSquare(a, b);
        }
        int GetRectanglesIntersectionSquare(Rectangle a, Rectangle b)
        {
            int xIntersection = GetSegmentsIntersectionLength(a.Left, a.Right, b.Left, b.Right);
            int yIntersection = GetSegmentsIntersectionLength(a.Top, a.Bottom, b.Top, b.Bottom);

            return xIntersection * yIntersection;
        }

        int GetSegmentsIntersectionLength(int aLeft, int aRight, int bLeft, int bRight)
        {
            int left = Math.Max(aLeft, bLeft);
            int right = Math.Min(aRight, bRight);

            return Math.Max(right - left, 0);
        }

    }
}
