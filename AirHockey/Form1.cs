using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirHockey
{
    public partial class Form1 : Form
    {
        // scores
        int player1Score = 0;
        int player2Score = 0;

        // speeds
        int playerSpeed = 8;
        int ballXSpeed = 5;
        int ballYSpeed = 5;

        // set up keys
        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        bool aDown = false;
        bool dDown = false;
        bool leftDown = false;
        bool rightDown = false;

        // set up brushes
        SolidBrush pinkBrush = new SolidBrush(Color.HotPink);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        //set up pens
        Pen pinkPen = new Pen(Color.HotPink, 5);
        Pen yellowPen = new Pen(Color.Yellow, 5);
        // set up player 1 + sides
        Rectangle player1 = new Rectangle(170, 15, 50, 50);
        Rectangle top1 = new Rectangle(170, 15, 50, 2);
        Rectangle bottom1 = new Rectangle(170, 65, 50, 2);
        Rectangle right1 = new Rectangle(220, 16, 2, 50);
        Rectangle left1 = new Rectangle(170, 16, 2, 50);
        // set up player 2 + sides
        Rectangle player2 = new Rectangle(170, 440, 50, 50);
        Rectangle top2 = new Rectangle(171, 440, 50, 2);
        Rectangle bottom2 = new Rectangle(171, 490, 50, 2);
        Rectangle right2 = new Rectangle(220, 440, 2, 50);
        Rectangle left2 = new Rectangle(170, 440, 2, 50);
        // set up ball
        Rectangle ball = new Rectangle(170, 300, 35, 35);
        // set up nets
        Rectangle player1Net = new Rectangle(70, -100, 250, 205);
        Rectangle player2Net = new Rectangle(70, 400, 250, 205);


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // set up keys
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            // fix stuck issue
            int rebound = 15;

            // move ball
                ball.X += ballXSpeed;
                ball.Y += ballYSpeed;

            // move player1
            if (wDown == true && player1.Y > 0) // move up
            {
                player1.Y -= playerSpeed;
                top1.Y -= playerSpeed;
                bottom1.Y -= playerSpeed;
                left1.Y -= playerSpeed;
                right1.Y -= playerSpeed;
            }

            if (aDown == true && player1.X > 0) // move left
            {
                player1.X -= playerSpeed;
                top1.X -= playerSpeed;
                bottom1.X -= playerSpeed;
                left1.X -= playerSpeed;
                right1.X -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height) // move down
            {
                player1.Y += playerSpeed;
                top1.Y += playerSpeed;
                bottom1.Y += playerSpeed;
                left1.Y += playerSpeed;
                right1.Y += playerSpeed;

            }
            if (dDown == true && player1.X < 580) // move right
            {
                player1.X += playerSpeed;
                top1.X += playerSpeed;
                bottom1.X += playerSpeed;
                left1.X += playerSpeed;
                right1.X += playerSpeed;

            }
            // move player2
            if (upArrowDown == true && player2.Y > 0) // move up
            {
                player2.Y -= playerSpeed;
                top2.Y -= playerSpeed;
                bottom2.Y -= playerSpeed;
                left2.Y -= playerSpeed;
                right2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height) // move down
            {
                player2.Y += playerSpeed;
                top2.Y += playerSpeed;
                bottom2.Y += playerSpeed;
                left2.Y += playerSpeed;
                right2.Y += playerSpeed;

            }

            if (leftDown == true && player2.X > 0) // move left
            {
                player2.X -= playerSpeed;
                top2.X -= playerSpeed;
                bottom2.X -= playerSpeed;
                left2.X -= playerSpeed;
                right2.X -= playerSpeed;
            }
        
            if (rightDown == true && player2.X < 580) // move right
            {
                player2.X += playerSpeed;
                top2.X += playerSpeed;
                bottom2.X += playerSpeed;
                left2.X += playerSpeed;
                right2.X += playerSpeed;
            }

            // ball collision with top and bottom walls
            if (ball.Y < 0 || ball.Y > this.Height - ball.Height)
            {
                ballYSpeed *= -1;

            }

            // ball collision with left and right walls
            if (ball.X < 0 || ball.X > this.Width - ball.Width)
            {
                ballXSpeed *= -1;  
            }

            //ball collision with player1
            if (top1.IntersectsWith(ball))
            {
                ballYSpeed *= -1;
                ball.Y = ball.Y - rebound;

            }
            if (bottom1.IntersectsWith(ball))
            {
                ballYSpeed *= -1;

                ball.Y = ball.Y + rebound;
            }
            if (left1.IntersectsWith(ball))
            {
                ballXSpeed *= -1;

                ball.X = ball.X - rebound;
            }
            if (right1.IntersectsWith(ball))
            {
                ballXSpeed *= -1;

                ball.X = ball.X + rebound;
            }
             

            //ball collision with player2
            if (top2.IntersectsWith(ball))
            {
                ballYSpeed *= -1;
                ball.Y = ball.Y - rebound;

            }
            if (bottom2.IntersectsWith(ball))
            {
                ballYSpeed *= -1;
                ball.Y = ball.Y + rebound;
            }
            if (left2.IntersectsWith(ball))
            {
                ballXSpeed *= -1;

                ball.X = ball.X - rebound;

            }
            if (right2.IntersectsWith(ball))
            {
                ballXSpeed *= -1;
                ball.X = ball.X + rebound;

            }

            //when ball collides with net, add score

            if (player1Net.IntersectsWith(ball))
            {

                ballXSpeed *= -1;
                // add to score
                player2Score++;
                score2output.Text = $"{player2Score}";
                // reset positions
                gameTimer.Enabled = false;

                ball.X = 300;
                ball.Y = 300;
                player1.X = 170;
                player1.Y = 15;
                player2.X = 170;
                player2.Y = 440;

                top1.X = 170;
                top1.Y = 15;
                bottom1.X = 170;
                bottom1.Y = 65;
                left1.X = 220;
                left1.Y = 16;
                right1.X = 170;
                right1.Y = 16;

                top2.X = 171;
                top2.Y = 440;
                bottom2.X = 171;
                bottom2.Y = 490;
                left2.X = 220;
                left2.Y = 440;
                right2.X = 170;
                right2.Y = 440;

            }

            if (player2Net.IntersectsWith(ball))
            {


                ballXSpeed *= -1;
                // add to score
                player1Score++;
                score1output.Text = $"{player1Score}";
                // reset positions
                gameTimer.Enabled = false;

                ball.X = 300;
                ball.Y = 300;

                player1.X = 170;
                player1.Y = 15;

                player2.X = 170;
                player2.Y = 440;

                top1.X = 170;
                top1.Y = 15;
                bottom1.X = 170;
                bottom1.Y = 65;
                left1.X = 220;
                left1.Y = 16;
                right1.X = 170;
                right1.Y = 16;

                top2.X = 171;
                top2.Y = 440;
                bottom2.X = 171;
                bottom2.Y = 490;
                left2.X = 220;
                left2.Y = 440;
                right2.X = 170;
                right2.Y = 440;


            }

            // if either score reaches 3, stop game
            if ( player1Score != 3 ||player2Score != 3)
            {
                gameTimer.Enabled = true;
            }

            if (player1Score == 3 || player2Score == 3)
            {
                outputText.Visible = true;
                outputText.Text = "Play again!";
                gameTimer.Enabled = false;
    
            }
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            // player 1 + sides
            e.Graphics.FillEllipse(pinkBrush, player1);
            e.Graphics.FillRectangle(whiteBrush, top1);
            e.Graphics.FillRectangle(whiteBrush, bottom1);
            e.Graphics.FillRectangle(whiteBrush, right1);
            e.Graphics.FillRectangle(whiteBrush, left1);


            // player 2 + sides
            e.Graphics.FillEllipse(yellowBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, top2);
            e.Graphics.FillRectangle(whiteBrush, bottom2);
            e.Graphics.FillRectangle(whiteBrush, right2);
            e.Graphics.FillRectangle(whiteBrush, left2);

            // ball 
            e.Graphics.FillEllipse(whiteBrush, ball);

            // nets
            e.Graphics.DrawArc(yellowPen, player1Net, 360, 180);

            e.Graphics.DrawArc(pinkPen, player2Net, 540, 180);


        }
    }
}
