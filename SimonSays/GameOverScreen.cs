using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimonSays
{
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            //TODO: show the length of the pattern
            lengthLabel.Text = $"{Form1.simonTrack.Count() - 1}";
            if (Form1.simonTrack.Count() < 50)
            {
                lengthLabel.ForeColor = Color.Gold;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the MenuScreen
            Application.Exit();
        }

        private void tryAgainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MenuScreen ms = new MenuScreen();

            // Centre the screen on the form
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);


            f.Controls.Add(ms);
            ms.Focus();
        }
    }
}
