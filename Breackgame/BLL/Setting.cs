using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public static class Setting
    {

        public static int ballVelocity { get; set; }
        public static int barVelocity { get; set; }
        public static int life { get; set; }
        public static int x, xc, y, yc;
        public static Timer timer { get; set; }
        public static PictureBox ball { get; set; }
        public static Panel bargame { get; set; }
        public static Panel containergame { get; set; }
        public static Label lifeinfo { get; set; }
        public static Label pointsinfo { get; set; }
        public static Label gameinfo { get; set; }
        public static List<Panel> walls { get; set; }


        public static void LoadDefaultSettings() {

            ballVelocity = 13;
            barVelocity = 10;
            life = 3;
            xc = 1;
            yc = 1;
        }


        public static void LoadGameFormControls(GameFrm form) {

            timer = new Timer();
            walls = new List<Panel>();

            foreach (Control ctrl in form.Controls)
            {
                if (ctrl.Name == "containerGame")
                {
                    containergame = ctrl as Panel;

                }
                if (ctrl.Name == "lifeInfo")
                {
                   lifeinfo = ctrl as Label;
                    lifeinfo.Text = "Lifes: " + life.ToString();

                }
                if (ctrl.Name == "pointInfo")
                {
                    pointsinfo = ctrl as Label;
                    pointsinfo.Text = "Points: 0";

                }
                if (ctrl.Name == "lblGameInfo")
                {
                    gameinfo = ctrl as Label;
                    gameinfo.Text = "Info";

                }

                if (containergame != null) {

                    foreach (Control c in containergame.Controls)
                    {
                        if (c.Name.Contains("wall"))
                        {
                            Panel tmp = c as Panel;
                            walls.Add(tmp);
                        }

                        if (c.Name == "ballSprite")
                        {
                            ball = c as PictureBox;
                        }
                        if (c.Name == "barSprite")
                        {
                            bargame = c as Panel ;
                        }
                    }

                }                

            }

        }

    }
}
