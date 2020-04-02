using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public class Enemies
    {
        Points points;

        public Enemies()
        {
            points = new Points();
        }

        public void WallIsTouched() {

            foreach (Panel wall in Setting.walls)
            {
                if (wall.Visible) {
                    if (Setting.ball.Bottom >= wall.Top &&
                                        Setting.ball.Bottom <= wall.Bottom &&
                                        Setting.ball.Left >= wall.Left &&
                                        Setting.ball.Right <= wall.Right)
                    {
                        wall.Visible = false;
                        points.AddPoints();
                        points.ShowPoints();
                    }

                }
                             
            }          
        }

    }
}
