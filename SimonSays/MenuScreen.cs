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
    public partial class MenuScreen : UserControl
    {
         
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //: remove this screen and start the GameScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();

            // Centre the screen on the form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);


            f.Controls.Add(gs);
            gs.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.diffMode = 1;
            button3.BackColor = Color.Lime;
            soundButton.BackColor = Color.White;
            lightButton.BackColor = Color.White;
        }

        private void soundButton_Click(object sender, EventArgs e)
        {
            Form1.diffMode = 2;
            button3.BackColor = Color.White;
            soundButton.BackColor = Color.Orange;
            lightButton.BackColor = Color.White;
        }

        private void lightButton_Click(object sender, EventArgs e)
        {
            Form1.diffMode = 3;
            button3.BackColor = Color.White;
            soundButton.BackColor = Color.White;
            lightButton.BackColor = Color.Red;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //: end the application
            Application.Exit();
        }

        
    }
}
