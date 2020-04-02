namespace Breackgame
{
    partial class GameFrm
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
            this.containerGame = new System.Windows.Forms.Panel();
            this.barSprite = new System.Windows.Forms.Panel();
            this.ballSprite = new System.Windows.Forms.PictureBox();
            this.pointInfo = new System.Windows.Forms.Label();
            this.lifeInfo = new System.Windows.Forms.Label();
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.wall03 = new System.Windows.Forms.Panel();
            this.wall04 = new System.Windows.Forms.Panel();
            this.wall05 = new System.Windows.Forms.Panel();
            this.wall02 = new System.Windows.Forms.Panel();
            this.wall01 = new System.Windows.Forms.Panel();
            this.wall07 = new System.Windows.Forms.Panel();
            this.wall06 = new System.Windows.Forms.Panel();
            this.wall10 = new System.Windows.Forms.Panel();
            this.wall09 = new System.Windows.Forms.Panel();
            this.wall08 = new System.Windows.Forms.Panel();
            this.wall17 = new System.Windows.Forms.Panel();
            this.wall16 = new System.Windows.Forms.Panel();
            this.wall20 = new System.Windows.Forms.Panel();
            this.wall19 = new System.Windows.Forms.Panel();
            this.wall18 = new System.Windows.Forms.Panel();
            this.wall12 = new System.Windows.Forms.Panel();
            this.wall11 = new System.Windows.Forms.Panel();
            this.wall15 = new System.Windows.Forms.Panel();
            this.wall14 = new System.Windows.Forms.Panel();
            this.wall13 = new System.Windows.Forms.Panel();
            this.wall22 = new System.Windows.Forms.Panel();
            this.wall21 = new System.Windows.Forms.Panel();
            this.wall25 = new System.Windows.Forms.Panel();
            this.wall24 = new System.Windows.Forms.Panel();
            this.wall23 = new System.Windows.Forms.Panel();
            this.containerGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // containerGame
            // 
            this.containerGame.BackColor = System.Drawing.Color.White;
            this.containerGame.Controls.Add(this.wall22);
            this.containerGame.Controls.Add(this.wall21);
            this.containerGame.Controls.Add(this.wall25);
            this.containerGame.Controls.Add(this.wall24);
            this.containerGame.Controls.Add(this.wall23);
            this.containerGame.Controls.Add(this.wall17);
            this.containerGame.Controls.Add(this.wall16);
            this.containerGame.Controls.Add(this.wall20);
            this.containerGame.Controls.Add(this.wall19);
            this.containerGame.Controls.Add(this.wall18);
            this.containerGame.Controls.Add(this.wall12);
            this.containerGame.Controls.Add(this.wall11);
            this.containerGame.Controls.Add(this.wall15);
            this.containerGame.Controls.Add(this.wall14);
            this.containerGame.Controls.Add(this.wall13);
            this.containerGame.Controls.Add(this.wall07);
            this.containerGame.Controls.Add(this.wall06);
            this.containerGame.Controls.Add(this.wall10);
            this.containerGame.Controls.Add(this.wall09);
            this.containerGame.Controls.Add(this.wall08);
            this.containerGame.Controls.Add(this.wall02);
            this.containerGame.Controls.Add(this.wall01);
            this.containerGame.Controls.Add(this.wall05);
            this.containerGame.Controls.Add(this.wall04);
            this.containerGame.Controls.Add(this.wall03);
            this.containerGame.Controls.Add(this.barSprite);
            this.containerGame.Controls.Add(this.ballSprite);
            this.containerGame.Location = new System.Drawing.Point(15, 30);
            this.containerGame.Name = "containerGame";
            this.containerGame.Size = new System.Drawing.Size(657, 515);
            this.containerGame.TabIndex = 0;
            this.containerGame.Paint += new System.Windows.Forms.PaintEventHandler(this.containerGame_Paint);
            // 
            // barSprite
            // 
            this.barSprite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barSprite.Location = new System.Drawing.Point(278, 484);
            this.barSprite.Name = "barSprite";
            this.barSprite.Size = new System.Drawing.Size(137, 12);
            this.barSprite.TabIndex = 1;
            // 
            // ballSprite
            // 
            this.ballSprite.Image = global::Breackgame.Properties.Resources.pngfind_com_pelota_de_futbol_png_5606113;
            this.ballSprite.Location = new System.Drawing.Point(258, 266);
            this.ballSprite.Name = "ballSprite";
            this.ballSprite.Size = new System.Drawing.Size(25, 24);
            this.ballSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ballSprite.TabIndex = 0;
            this.ballSprite.TabStop = false;
            // 
            // pointInfo
            // 
            this.pointInfo.AutoSize = true;
            this.pointInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointInfo.ForeColor = System.Drawing.Color.Red;
            this.pointInfo.Location = new System.Drawing.Point(538, 9);
            this.pointInfo.Name = "pointInfo";
            this.pointInfo.Size = new System.Drawing.Size(58, 17);
            this.pointInfo.TabIndex = 3;
            this.pointInfo.Text = "Points:";
            // 
            // lifeInfo
            // 
            this.lifeInfo.AutoSize = true;
            this.lifeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeInfo.ForeColor = System.Drawing.Color.Red;
            this.lifeInfo.Location = new System.Drawing.Point(12, 9);
            this.lifeInfo.Name = "lifeInfo";
            this.lifeInfo.Size = new System.Drawing.Size(53, 17);
            this.lifeInfo.TabIndex = 4;
            this.lifeInfo.Text = "Lifes: ";
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameInfo.Location = new System.Drawing.Point(91, 9);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(31, 17);
            this.lblGameInfo.TabIndex = 5;
            this.lblGameInfo.Text = "Info";
            this.lblGameInfo.Visible = false;
            // 
            // wall03
            // 
            this.wall03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall03.Location = new System.Drawing.Point(44, 124);
            this.wall03.Name = "wall03";
            this.wall03.Size = new System.Drawing.Size(92, 23);
            this.wall03.TabIndex = 3;
            // 
            // wall04
            // 
            this.wall04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall04.Location = new System.Drawing.Point(44, 162);
            this.wall04.Name = "wall04";
            this.wall04.Size = new System.Drawing.Size(92, 23);
            this.wall04.TabIndex = 3;
            // 
            // wall05
            // 
            this.wall05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall05.Location = new System.Drawing.Point(44, 200);
            this.wall05.Name = "wall05";
            this.wall05.Size = new System.Drawing.Size(92, 23);
            this.wall05.TabIndex = 3;
            // 
            // wall02
            // 
            this.wall02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall02.Location = new System.Drawing.Point(44, 88);
            this.wall02.Name = "wall02";
            this.wall02.Size = new System.Drawing.Size(92, 23);
            this.wall02.TabIndex = 4;
            // 
            // wall01
            // 
            this.wall01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall01.Location = new System.Drawing.Point(44, 50);
            this.wall01.Name = "wall01";
            this.wall01.Size = new System.Drawing.Size(92, 23);
            this.wall01.TabIndex = 5;
            // 
            // wall07
            // 
            this.wall07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall07.Location = new System.Drawing.Point(167, 88);
            this.wall07.Name = "wall07";
            this.wall07.Size = new System.Drawing.Size(92, 23);
            this.wall07.TabIndex = 9;
            // 
            // wall06
            // 
            this.wall06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall06.Location = new System.Drawing.Point(167, 50);
            this.wall06.Name = "wall06";
            this.wall06.Size = new System.Drawing.Size(92, 23);
            this.wall06.TabIndex = 10;
            // 
            // wall10
            // 
            this.wall10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall10.Location = new System.Drawing.Point(167, 200);
            this.wall10.Name = "wall10";
            this.wall10.Size = new System.Drawing.Size(92, 23);
            this.wall10.TabIndex = 6;
            // 
            // wall09
            // 
            this.wall09.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall09.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall09.Location = new System.Drawing.Point(167, 162);
            this.wall09.Name = "wall09";
            this.wall09.Size = new System.Drawing.Size(92, 23);
            this.wall09.TabIndex = 7;
            // 
            // wall08
            // 
            this.wall08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall08.Location = new System.Drawing.Point(167, 124);
            this.wall08.Name = "wall08";
            this.wall08.Size = new System.Drawing.Size(92, 23);
            this.wall08.TabIndex = 8;
            // 
            // wall17
            // 
            this.wall17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall17.Location = new System.Drawing.Point(401, 88);
            this.wall17.Name = "wall17";
            this.wall17.Size = new System.Drawing.Size(92, 23);
            this.wall17.TabIndex = 19;
            // 
            // wall16
            // 
            this.wall16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall16.Location = new System.Drawing.Point(401, 50);
            this.wall16.Name = "wall16";
            this.wall16.Size = new System.Drawing.Size(92, 23);
            this.wall16.TabIndex = 20;
            // 
            // wall20
            // 
            this.wall20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall20.Location = new System.Drawing.Point(401, 200);
            this.wall20.Name = "wall20";
            this.wall20.Size = new System.Drawing.Size(92, 23);
            this.wall20.TabIndex = 16;
            // 
            // wall19
            // 
            this.wall19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall19.Location = new System.Drawing.Point(401, 162);
            this.wall19.Name = "wall19";
            this.wall19.Size = new System.Drawing.Size(92, 23);
            this.wall19.TabIndex = 17;
            // 
            // wall18
            // 
            this.wall18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall18.Location = new System.Drawing.Point(401, 124);
            this.wall18.Name = "wall18";
            this.wall18.Size = new System.Drawing.Size(92, 23);
            this.wall18.TabIndex = 18;
            // 
            // wall12
            // 
            this.wall12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall12.Location = new System.Drawing.Point(278, 88);
            this.wall12.Name = "wall12";
            this.wall12.Size = new System.Drawing.Size(92, 23);
            this.wall12.TabIndex = 14;
            // 
            // wall11
            // 
            this.wall11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall11.Location = new System.Drawing.Point(278, 50);
            this.wall11.Name = "wall11";
            this.wall11.Size = new System.Drawing.Size(92, 23);
            this.wall11.TabIndex = 15;
            // 
            // wall15
            // 
            this.wall15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall15.Location = new System.Drawing.Point(278, 200);
            this.wall15.Name = "wall15";
            this.wall15.Size = new System.Drawing.Size(92, 23);
            this.wall15.TabIndex = 11;
            // 
            // wall14
            // 
            this.wall14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall14.Location = new System.Drawing.Point(278, 162);
            this.wall14.Name = "wall14";
            this.wall14.Size = new System.Drawing.Size(92, 23);
            this.wall14.TabIndex = 12;
            // 
            // wall13
            // 
            this.wall13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall13.Location = new System.Drawing.Point(278, 124);
            this.wall13.Name = "wall13";
            this.wall13.Size = new System.Drawing.Size(92, 23);
            this.wall13.TabIndex = 13;
            // 
            // wall22
            // 
            this.wall22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall22.Location = new System.Drawing.Point(516, 88);
            this.wall22.Name = "wall22";
            this.wall22.Size = new System.Drawing.Size(92, 23);
            this.wall22.TabIndex = 24;
            // 
            // wall21
            // 
            this.wall21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall21.Location = new System.Drawing.Point(516, 50);
            this.wall21.Name = "wall21";
            this.wall21.Size = new System.Drawing.Size(92, 23);
            this.wall21.TabIndex = 25;
            // 
            // wall25
            // 
            this.wall25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall25.Location = new System.Drawing.Point(516, 200);
            this.wall25.Name = "wall25";
            this.wall25.Size = new System.Drawing.Size(92, 23);
            this.wall25.TabIndex = 21;
            // 
            // wall24
            // 
            this.wall24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall24.Location = new System.Drawing.Point(516, 162);
            this.wall24.Name = "wall24";
            this.wall24.Size = new System.Drawing.Size(92, 23);
            this.wall24.TabIndex = 22;
            // 
            // wall23
            // 
            this.wall23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.wall23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wall23.Location = new System.Drawing.Point(516, 124);
            this.wall23.Name = "wall23";
            this.wall23.Size = new System.Drawing.Size(92, 23);
            this.wall23.TabIndex = 23;
            // 
            // GameFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 557);
            this.Controls.Add(this.lblGameInfo);
            this.Controls.Add(this.lifeInfo);
            this.Controls.Add(this.pointInfo);
            this.Controls.Add(this.containerGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "GameFrm";
            this.Text = "GameFrm";
            this.Load += new System.EventHandler(this.GameFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameFrm_KeyDown);
            this.containerGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballSprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel containerGame;
        private System.Windows.Forms.PictureBox ballSprite;
        private System.Windows.Forms.Panel barSprite;
        private System.Windows.Forms.Label pointInfo;
        private System.Windows.Forms.Label lifeInfo;
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.Panel wall22;
        private System.Windows.Forms.Panel wall21;
        private System.Windows.Forms.Panel wall25;
        private System.Windows.Forms.Panel wall24;
        private System.Windows.Forms.Panel wall23;
        private System.Windows.Forms.Panel wall17;
        private System.Windows.Forms.Panel wall16;
        private System.Windows.Forms.Panel wall20;
        private System.Windows.Forms.Panel wall19;
        private System.Windows.Forms.Panel wall18;
        private System.Windows.Forms.Panel wall12;
        private System.Windows.Forms.Panel wall11;
        private System.Windows.Forms.Panel wall15;
        private System.Windows.Forms.Panel wall14;
        private System.Windows.Forms.Panel wall13;
        private System.Windows.Forms.Panel wall07;
        private System.Windows.Forms.Panel wall06;
        private System.Windows.Forms.Panel wall10;
        private System.Windows.Forms.Panel wall09;
        private System.Windows.Forms.Panel wall08;
        private System.Windows.Forms.Panel wall02;
        private System.Windows.Forms.Panel wall01;
        private System.Windows.Forms.Panel wall05;
        private System.Windows.Forms.Panel wall04;
        private System.Windows.Forms.Panel wall03;
    }
}