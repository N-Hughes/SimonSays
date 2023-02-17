using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        //: create a List to store the pattern. Must be accessable on other screens
        public static List<int> simonTrack = new List<int>();
        public static int diffMode = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            //: Launch MenuScreen
            MenuScreen ms = new MenuScreen();

            // Centre the screen on the form
            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

            this.Controls.Add(ms);
            ms.Focus();
        }
    }
}
