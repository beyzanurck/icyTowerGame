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

        PictureBox[] platforms = new PictureBox[4];

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
                pctPlayer.Left -= 7;
            }

            if (goRight == true && pctPlayer.Right<390)
            {
                pctPlayer.Left += 10;
            }

            if (goUp == true && step < 20)
            {
                pctPlayer.Top -= 7;
                step++;
            }

            if (step == 20)
            {
                pctPlayer.Top += 7;
            }

            platforms[0] = pctPlatform; platforms[1] = pctPlatform2; 
            platforms[2] = pctPlatform3; platforms[3] = pctPlatform4;

            if (collision = isCollision(platforms, pctPlayer))
            {
                step = 0;
                lblY.Text = pctPlayer.Top.ToString();
                lblX.Text = pctPlayer.Left.ToString();
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

        private bool isCollision(PictureBox[] platform, PictureBox player)
        {
            

            for (int i = 0; i < platform.Length; i++)
            {

                bool y = false, x = false;


                if ((player.Bottom > platform[i].Top - 5 & player.Bottom < platform[i].Top))
                {
                    y = true;
                    

                }
                if ((player.Right > platform[i].Left & player.Left < platform[i].Left)
                     || (player.Left < platform[i].Right & player.Right > platform[i].Right)
                     || (player.Left > platform[i].Left & player.Right < platform[i].Right))
                {
                    x = true;
                    
                }
                
                if (x == true & y == true)
                {
                    return true;
                }
            }

            
            return false;
        }
    }
}
