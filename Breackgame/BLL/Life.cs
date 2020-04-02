using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public class Life
    {

        public const string LOSEGAME = "Game Over";

        public Life()
        {

        }

        public dynamic VerifyIfPlayerHasLose()
        {
            Point BarSpriteLocation = Setting.bargame.Location;

            if (Setting.life <= 1)
            {
                Setting.life = 0;
                Setting.lifeinfo.Text = "Life: 0";
                Setting.ball.Visible = false;
                Setting.timer.Enabled = false;
                Setting.timer.Stop();
                MessageBox.Show(LOSEGAME);
                Application.Exit();
                return null;
            }
            else {
                Setting.life--;
                Setting.lifeinfo.Text = "Life: " + Setting.life.ToString();
                Setting.ball.Visible = false;
                Setting.timer.Enabled = false;
                Setting.timer.Stop();           
                System.Threading.Thread.Sleep(500);
                return new
                {
                    PointLocation = new Point(BarSpriteLocation.X / 2, BarSpriteLocation.Y),
                    BarSpriteLocation = BarSpriteLocation
                };
            }


        }



    }
}
