using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Ball
    {
        public Point position;
        public Size size = new Size(10, 10);
        public Ball(Point p)
        {
            position = p;
        }

        public void draw(Graphics g)
        {
            g.FillRectangle(Brushes.White, new Rectangle(position, size));
        }
    }
}
