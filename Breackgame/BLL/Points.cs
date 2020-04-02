using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breackgame
{
    public class Points
    {
        public int point { get; set; }

        public Points()
        {
            this.point = 0;
        }

        public void AddPoints() {
            this.point++;
        }

        public void RemPoints()
        {
            this.point--;
        }

        public void ShowPoints() {

            Setting.pointsinfo.Text = "Points: " + point.ToString();
            Setting.pointsinfo.Refresh();
        }

    }
}
