using System;
using System.Windows.Forms;

namespace icyTower
{
    public partial class frmIcyTower : Form
    {
        public frmIcyTower()
        {
            InitializeComponent();
            timer.Start();

        }

        bool collision;
        int gameSpeed = 1;
        bool goLeft, goRight, goUp;
        int step = 0;

        Random platform = new Random();
        int platformLocation;

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if ( e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode==Keys.Space)
            {
                goUp = true;
            }
        }
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                goUp = false;
            }
        }

        private void gameTimer(object sender, EventArgs e)
        {
            goUp = true;

            if (goLeft == true && pctPlayer.Left > 5)
            {
                pctPlayer.Left -= 10;
            }

            if (goRight == true && pctPlayer.Right<390)
            {
                pctPlayer.Left += 10;
            }

            if (goUp == true && step < 16)
            {
                pctPlayer.Top -= 10;
                step++;
            }

            if (step == 16)
            {
                pctPlayer.Top += 8;
            }

            if (collision = isCollision(pctPlatform2, pctPlayer))
            {
                step = 0;
            }


            pctBackGround1.Top += gameSpeed;
            pctBackGround2.Top += gameSpeed;

            if (pctBackGround2.Top >= 420)
            {
                pctBackGround2.Top = -420;
            }

            if (pctBackGround1.Top >= 420)
            {
                pctBackGround1.Top = -420;
            }

            pctPlatform.Top += (gameSpeed);
            pctPlatform2.Top += (gameSpeed);
            pctPlatform3.Top += (gameSpeed);
            pctPlatform4.Top += (gameSpeed);


            if (pctPlatform.Top >= 420)
            {
                platformLocation = platform.Next(6, 293);
                pctPlatform.Top = 0;
                pctPlatform.Left = platformLocation;
            }

            if (pctPlatform2.Top >= 420)
            {
                platformLocation = platform.Next(6, 293);
                pctPlatform2.Top = 0;
                pctPlatform2.Left = platformLocation;
            }

            if (pctPlatform3.Top >= 420)
            {
                platformLocation = platform.Next(6, 293);
                pctPlatform3.Top = 0;
                pctPlatform3.Left = platformLocation;
            }

            if (pctPlatform4.Top >= 420)
            {
                platformLocation = platform.Next(6, 293);
                pctPlatform4.Top = 0;
                pctPlatform4.Left = platformLocation;
            }

        }

        private bool isCollision(PictureBox platform, PictureBox player)
        {
            bool y = false, x = false;
            if ((player.Bottom > platform.Top - 10 & player.Bottom < platform.Top))
            {
                y = true;
            }

            if ((player.Right>platform.Left & player.Left < platform.Left)
                 || (player.Left < platform.Right & player.Right > platform.Right)
                 || (player.Left > platform.Left & player.Right < platform.Right))
            {
                x = true;
            }

            if (x == true & y == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
