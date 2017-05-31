using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class PaddleController
    {
        public Paddle targetPaddle;
        public Ball targetBall;

        public PaddleController(Paddle t, Ball b)
        {
            targetPaddle = t;
            targetBall = b;
        }

        public void movePaddle()
        {
            if(!(targetPaddle.position.Y >= 295))
            {
                if (targetPaddle.position.Y < targetBall.position.Y)
                {
                    targetPaddle.moveDown();
                }
                else if(targetPaddle.position.Y >= targetBall.position.Y)
                {
                    targetPaddle.moveUp();
                }
            }
        }
    }
}
