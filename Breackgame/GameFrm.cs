using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breackgame
{
    public partial class GameFrm : Form
    {
        ControlBar ControlBar = new ControlBar();
       
        public GameFrm()
        {
            InitializeComponent();
            SetCaptionFormTitle();
            Setting.LoadDefaultSettings();
            Setting.LoadGameFormControls(this);

        }

        private void SetCaptionFormTitle() {

            string msg = string.Format("Breackgame                                                    Version({0})", Application.ProductVersion);
            this.Text = msg;
        }

        private void GameFrm_Load(object sender, EventArgs e)
        {
            KineticBall game = new KineticBall();

            game.StartGame();
        }

        private void GameFrm_KeyDown(object sender, KeyEventArgs e)
        {
            ControlBar.GetPressKeyOnGameContainer(sender, e);
        }

        private void containerGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
