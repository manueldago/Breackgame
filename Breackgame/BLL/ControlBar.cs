using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public class ControlBar
    {
       
        public ControlBar()
        {
        }

        public void GetPressKeyOnGameContainer(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                e.Handled = true;

                if (Setting.timer.Enabled == false) {
                    Setting.timer.Enabled = true;
                    Setting.timer.Start();
                }

                Setting.bargame.Location = new Point(Setting.bargame.Location.X - 1 * Setting.barVelocity, Setting.bargame.Location.Y);

            }

            if (e.KeyCode == Keys.Right)
            {
                e.Handled = true;
                Setting.bargame.Location = new Point(Setting.bargame.Location.X + 1 * Setting.barVelocity, Setting.bargame.Location.Y);
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Application.Exit();

            }

        }

        public List<int> GetPointsXFromLocation()
        {
            int locationbar = Setting.bargame.Location.X;

            int barsize = Setting.bargame.Size.Width;

            var response = new List<int>();

            for (int i = locationbar; i < locationbar + barsize; i++)
            {
                response.Add(i);
            }

            return response;

        }

    }

}
