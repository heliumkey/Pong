using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class PongForm : Form
    {
        
        static Paddle leftPaddle = new Paddle(new Point(5, 5));
        static Paddle rightPaddle = new Paddle(new Point(360, 5));

        static Ball ball = new Ball(new Point(190, 190));

        PaddleController leftPControl = new PaddleController(leftPaddle, ball);


        public PongForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //move enemy paddle
            leftPControl.movePaddle();
            Debug.Write(rightPaddle.position.ToString());

            //draw things
            leftPaddle.draw(e.Graphics);
            rightPaddle.draw(e.Graphics);
            ball.draw(e.Graphics);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void PongForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            //disable resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //set larger buffer to reduce flicker
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);
        }

        private void PongForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            { 
                case Keys.Up:
                    rightPaddle.moveUp();
                    break;

                case Keys.Down:
                    rightPaddle.moveDown();
                break;
            }
        }

        private void PongForm_Resize(object sender, EventArgs e)
        {
            //rightPaddle.position.X = Form.ActiveForm.Width - 45;
            //leftPaddle.position.X = 10;
        }
    }
}

//possibly change to form component and add buttons, etc