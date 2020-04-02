using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public class KineticBall
    {
        //Objs
        public Life Life { get; set; }
        public ControlBar ControlBar { get; set; }
        public Enemies Enemies { get; set; }

        //Ctor
        public KineticBall()
        {
            this.Life = new Life();
            this.ControlBar = new ControlBar();
            this.Enemies = new Enemies();         
            Setting.timer.Tick += Timer_Tick;
        }

        //Events
        private void Timer_Tick(object sender, EventArgs e)
        {
            StartBallMoving();
        }


        //Public methods
        public void StartGame() {
            Setting.timer.Enabled = false;
            Setting.timer.Start();
        }

        public void StopGame()
        {
            Setting.timer.Enabled = false;
            Setting.timer.Stop();
        }


        //Private  methods
        void StartBallMoving()
        {

            BallIntersectWithContainerGame();

            this.Enemies.WallIsTouched();

            RefreshBallPosition();
        }

        void ShowCoordenatesObjects() {

            Setting.gameinfo.Text = "ContainerGame" + Setting.containergame.Top.ToString() + "      Ball:" + Setting.ball.Location.ToString();
        }

        void BallIntersectWithContainerGame() {

            Setting.x = Setting.x + Setting.xc * Setting.ballVelocity;

            Setting.y = Setting.y + Setting.yc * Setting.ballVelocity;

            List<int> intersectionBarX = ControlBar.GetPointsXFromLocation();

            if (Setting.x > Setting.containergame.Width)
            {
                Setting.x = Setting.containergame.Width - Setting.ball.Width; Setting.xc = -1;
            }


            if (Setting.y > Setting.containergame.Bottom)
            {
                Setting.y = Setting.containergame.Height - Setting.ball.Height; Setting.yc = -1;

                CheckLifeOfPlayer();             
            }

            if (Setting.y >= Setting.bargame.Location.Y && intersectionBarX.Contains(Setting.x))
            {
                Setting.y = Setting.ball.Location.Y; Setting.yc = -1;
            }

            if (Setting.x < 0)
            {
                Setting.x = 0 + Setting.ball.Width;
                Setting.xc = 1;
            }


            if (Setting.y < 0)
            {
                Setting.y = 0 + Setting.ball.Height;
                Setting.yc = 1;
            }

        }

        void RefreshBallPosition() {

            Setting.ball.Location = new Point(Setting.x - Setting.ball.Size.Width, Setting.y - Setting.ball.Size.Height);

        }

        void CheckLifeOfPlayer() {

            var result = this.Life.VerifyIfPlayerHasLose();
            if (result != null)
            {
                Setting.x = Setting.bargame.Location.X;
                Setting.y = Setting.bargame.Location.Y;
                Setting.ball.Visible = true;
                Setting.ball.Location = new Point(850, Setting.bargame.Location.Y - 8);
                Setting.bargame.Location = new Point(Setting.containergame.Width / 3, Setting.bargame.Location.Y);
            }
        }

    }
}
