namespace icyTower
{
    partial class frmIcyTower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pctPlatform4 = new System.Windows.Forms.PictureBox();
            this.pctPlatform3 = new System.Windows.Forms.PictureBox();
            this.pctPlatform = new System.Windows.Forms.PictureBox();
            this.pctPlatform2 = new System.Windows.Forms.PictureBox();
            this.pctBackGround2 = new System.Windows.Forms.PictureBox();
            this.pctBackGround1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pctPlayer);
            this.panel.Controls.Add(this.pctPlatform4);
            this.panel.Controls.Add(this.pctPlatform3);
            this.panel.Controls.Add(this.pctPlatform);
            this.panel.Controls.Add(this.pctPlatform2);
            this.panel.Controls.Add(this.pctBackGround2);
            this.panel.Controls.Add(this.pctBackGround1);
            this.panel.Location = new System.Drawing.Point(6, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 420);
            this.panel.TabIndex = 0;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::icyTower.Properties.Resources.player;
            this.pctPlayer.Location = new System.Drawing.Point(126, 368);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(40, 52);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPlayer.TabIndex = 9;
            this.pctPlayer.TabStop = false;
            // 
            // pctPlatform4
            // 
            this.pctPlatform4.Image = global::icyTower.Properties.Resources.platform1;
            this.pctPlatform4.Location = new System.Drawing.Point(55, 35);
            this.pctPlatform4.Name = "pctPlatform4";
            this.pctPlatform4.Size = new System.Drawing.Size(101, 32);
            this.pctPlatform4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPlatform4.TabIndex = 8;
            this.pctPlatform4.TabStop = false;
            this.pctPlatform4.Tag = "platform";
            // 
            // pctPlatform3
            // 
            this.pctPlatform3.Image = global::icyTower.Properties.Resources.platform1;
            this.pctPlatform3.Location = new System.Drawing.Point(233, 141);
            this.pctPlatform3.Name = "pctPlatform3";
            this.pctPlatform3.Size = new System.Drawing.Size(101, 32);
            this.pctPlatform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPlatform3.TabIndex = 7;
            this.pctPlatform3.TabStop = false;
            this.pctPlatform3.Tag = "platform";
            // 
            // pctPlatform
            // 
            this.pctPlatform.Image = global::icyTower.Properties.Resources.platform1;
            this.pctPlatform.Location = new System.Drawing.Point(53, 352);
            this.pctPlatform.Name = "pctPlatform";
            this.pctPlatform.Size = new System.Drawing.Size(103, 32);
            this.pctPlatform.TabIndex = 2;
            this.pctPlatform.TabStop = false;
            this.pctPlatform.Tag = "platform";
            // 
            // pctPlatform2
            // 
            this.pctPlatform2.Image = global::icyTower.Properties.Resources.platform1;
            this.pctPlatform2.Location = new System.Drawing.Point(174, 256);
            this.pctPlatform2.Name = "pctPlatform2";
            this.pctPlatform2.Size = new System.Drawing.Size(101, 32);
            this.pctPlatform2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctPlatform2.TabIndex = 5;
            this.pctPlatform2.TabStop = false;
            this.pctPlatform2.Tag = "platform";
            // 
            // pctBackGround2
            // 
            this.pctBackGround2.Image = global::icyTower.Properties.Resources.uncolored_piramids;
            this.pctBackGround2.Location = new System.Drawing.Point(0, 0);
            this.pctBackGround2.Name = "pctBackGround2";
            this.pctBackGround2.Size = new System.Drawing.Size(400, 420);
            this.pctBackGround2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBackGround2.TabIndex = 1;
            this.pctBackGround2.TabStop = false;
            // 
            // pctBackGround1
            // 
            this.pctBackGround1.Image = global::icyTower.Properties.Resources.uncolored_piramids;
            this.pctBackGround1.Location = new System.Drawing.Point(0, -420);
            this.pctBackGround1.Name = "pctBackGround1";
            this.pctBackGround1.Size = new System.Drawing.Size(400, 420);
            this.pctBackGround1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBackGround1.TabIndex = 0;
            this.pctBackGround1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.gameTimer);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(25, 441);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X: ";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(108, 441);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y: ";
            // 
            // frmIcyTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 518);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.panel);
            this.Name = "frmIcyTower";
            this.Text = "icy tower";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackGround1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pctBackGround1;
        private System.Windows.Forms.PictureBox pctBackGround2;
        private System.Windows.Forms.PictureBox pctPlatform;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pctPlatform3;
        private System.Windows.Forms.PictureBox pctPlatform2;
        private System.Windows.Forms.PictureBox pctPlatform4;
        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

