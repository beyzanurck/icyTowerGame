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
        }

        bool goLeft, goRight;

        

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            goLeft = true; goRight = true;

            if (goLeft == true && e.KeyCode == Keys.Left && pctPlayer.Left>5)
            {
                pctPlayer.Left -=10;
            }

            if (goRight == true && e.KeyCode == Keys.Right && pctPlayer.Right < 390)
            {
                pctPlayer.Left += 10;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            goLeft = false;
            goRight = false;
        }
    }
}
