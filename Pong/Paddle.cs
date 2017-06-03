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
        public Rectangle paddleRect;

        public Paddle(Point p)
        {
            position = p;
        }
        
        public void draw(Graphics g)
        {
            paddleRect = new Rectangle(position, size);
            g.FillRectangle(Brushes.White, paddleRect);
        }
        public void moveUp()
        {
            if (!(this.position.Y <= 5))
            {
                this.position.Y = this.position.Y - 5;

            }

        }
        public void moveDown()
        {
            if (!(this.position.Y >= 295))
            {
                this.position.Y = this.position.Y + 5;

            }

        }
    }
}
