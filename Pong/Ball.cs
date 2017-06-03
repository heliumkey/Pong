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
        public Rectangle ballRect;

        public Boolean xDirection = true;
        public Boolean yDirection = false;

        public Paddle leftP;
        public Paddle rightP;
        
        
        //add speeds for each direction

        public int xSpeed = 1;
        public int ySpeed = 1;

        public Ball(Point p, Paddle lP, Paddle rP)
        {
            position = p;
            leftP = lP;
            rightP = rP;

        }

        public void draw(Graphics g)
        {
            ballRect = new Rectangle(position, size);
            g.FillRectangle(Brushes.White, ballRect);
        }

        public void move()
        {
            detect();
            if (xDirection && yDirection)
            {
                this.position.X = this.position.X + xSpeed;
                this.position.Y = this.position.Y + ySpeed;
            }
            else if(xDirection && !yDirection)
            {
                this.position.X = this.position.X + xSpeed;
                this.position.Y = this.position.Y - ySpeed;
            }
            else if(!xDirection && yDirection)
            {
                this.position.X = this.position.X - xSpeed;
                this.position.Y = this.position.Y + ySpeed;
            }
            else
            {
                this.position.X = this.position.X - xSpeed;
                this.position.Y = this.position.Y - ySpeed;
            }
        }

        public void detect()
        {
            if(ballRect.IntersectsWith(leftP.paddleRect))
            {
                xDirection = !xDirection;
            }
            if (ballRect.IntersectsWith(rightP.paddleRect))
            {
                xDirection = !xDirection;
            }
            if(position.X == 0 | position.X == 380)
            {
                xDirection = !xDirection;

            }
            if(position.Y == 0 | position.Y == 350)
            {
                yDirection = !yDirection;
            }
        }
    }
}
