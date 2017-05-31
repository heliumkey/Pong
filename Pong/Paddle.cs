using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Paddle
    {
        public Point position;
        public Size size = new Size(20, 60);

        public Paddle(Point p)
        {
            position = p;
        }
        
        public void draw(Graphics g)
        {
            g.FillRectangle(Brushes.White, new Rectangle(position, size));
        }
        public void moveUp()
        {
            if (!(this.position.Y <= 5))
            {
                this.position.Y = this.position.Y - 10;

            }

        }
        public void moveDown()
        {
            if (!(this.position.Y >= 295))
            {
                this.position.Y = this.position.Y + 10;

            }

        }
    }
}
