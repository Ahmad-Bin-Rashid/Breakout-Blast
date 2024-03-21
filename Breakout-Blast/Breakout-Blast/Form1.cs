using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Blast
{
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;

        int playerSpeed;
        int ballx;
        int bally;

        int score;

        Random rnd;

        PictureBox[] blocks;

        private void InitializeGame()
        {
            goLeft = false;
            goRight = false;

            playerSpeed = 10;
            ballx = 5;
            bally = 5;
            score = 0;
            ScoreLb.Text = "Score: " + score;

            rnd = new Random();
            

            ResultLb.Text = "";
            ResultLb.Visible = false;
            PlayAgainMsg.Visible = false;
            Ball.Left = 400;
            Ball.Top = 350;
            Player.Left = 370;
            Player.Top = 505;
            PlaceBlocks();
            GameTimer.Start();
        }



        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            if (goLeft == true && Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
            if (goRight == true && Player.Left < 681)
            {
                Player.Left += playerSpeed;
            }

            Ball.Left += ballx;
            Ball.Top += bally;

            if (Ball.Left < 1)
            {
                ballx = -ballx;
            }
            if (Ball.Left > 781)
            {
                ballx = -ballx;
            }

            if (Ball.Top < 1)
            {
                bally = -bally;
            }

            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                bally = -rnd.Next(5, 10);

                if (ballx < 0)
                {
                    ballx = -rnd.Next(3, 8);
                }
                else
                {
                    ballx = rnd.Next(3, 8);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 10;
                        ScoreLb.Text = "Score: " + score;
                        bally = -bally;
                        this.Controls.Remove(x);
                    }

                }
                
            }



            if (Ball.Top > 575)
            {
                GameOver(Color.Red, "You Fail !!");
            }

            if (score == 280)
            {
                GameOver(Color.LightGreen, "Congratulations! You Win !!");
            }


        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Enter)
            {
                InitializeGame();
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void PlaceBlocks()
        {
            blocks = new PictureBox[28];

            int x = 0;
            int top = 50;
            int left = 90;

            for (int i = 0; i < blocks.Length; i++)
            {
                if (x == 7)
                {
                    x = 0;
                    top += 50;
                    left = 90;
                }
                blocks[i] = new PictureBox();
                blocks[i].Name = "Blocks";
                blocks[i].Tag = "Blocks";
                blocks[i].Height = 20;
                blocks[i].Width = 50;
                blocks[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                blocks[i].Top = top;
                blocks[i].Left = left;
                this.Controls.Add(blocks[i]);
                left += 100;
                x++;

            }


        }
    
        private void GameOver(Color color, string message)
        {
            ResultLb.Text = message;
            ResultLb.ForeColor = color;
            ResultLb.Visible = true;
            PlayAgainMsg.Visible = true;
            for (int i = 0; i < blocks.Length; i++)
            {
                if (this.Controls.Contains(blocks[i]))
                {
                    this.Controls.Remove(blocks[i]);
                }
            }

            GameTimer.Stop();
        }


    }
}
