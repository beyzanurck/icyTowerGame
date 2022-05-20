using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        int gameSpeed = 3;
        bool goLeft, goRight;

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
        }

        private void gameTimer(object sender, EventArgs e)
        {
            if (goLeft == true && pctPlayer.Left > 5)
            {
                pctPlayer.Left -= 10;
            }

            if (goRight == true && pctPlayer.Right<390)
            {
                pctPlayer.Left += 10;
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
    }
}
