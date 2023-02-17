using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create an int guess variable to track what part of the pattern the user is at
        int simonGuess = 0;
        Random randGen = new Random();
        SoundPlayer greenClick = new SoundPlayer(Properties.Resources.green);
        SoundPlayer yellowClick = new SoundPlayer(Properties.Resources.yellow);
        SoundPlayer blueClick = new SoundPlayer(Properties.Resources.blue);
        SoundPlayer redClick = new SoundPlayer(Properties.Resources.red);
        SoundPlayer gameLose = new SoundPlayer(Properties.Resources.mistake);
        public GameScreen()
        {
            InitializeComponent();



        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //clear the pattern list from form1
            Form1.simonTrack.Clear();
            Refresh();

            //refresh
            //pause for a bit
            Thread.Sleep(850);
            Refresh();

            //run ComputerTurn()
            ComputerTurn();
        }

        private void ComputerTurn()
        {
            //TODO: get rand num between 0 and 4 (0, 1, 2, 3) and add to pattern list. Each number represents a button. For example, 0 may be green, 1 may be blue, etc.
            Form1.simonTrack.Add(randGen.Next(1, 5));

            //TODO: create a for loop that shows each value in the pattern by lighting up approriate button
            if (Form1.diffMode == 1)
            {
                for (int i = 0; i < Form1.simonTrack.Count; i++)
                {
                    Thread.Sleep(446);
                    switch (Form1.simonTrack[i])
                    {

                        case 1:
                            greenButton.BackColor = Color.Lime;
                            greenClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            greenButton.BackColor = Color.ForestGreen;
                            Refresh();
                            break;

                        case 2:
                            yellowButton.BackColor = Color.Yellow;
                            yellowClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            yellowButton.BackColor = Color.DarkGoldenrod;
                            Refresh();
                            break;

                        case 3:
                            blueButton.BackColor = Color.RoyalBlue;
                            blueClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            blueButton.BackColor = Color.DarkBlue;
                            Refresh();
                            break;

                        case 4:
                            redButton.BackColor = Color.Red;
                            redClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            redButton.BackColor = Color.DarkRed;
                            Refresh();
                            break;
                    }


                }
            }
            else if (Form1.diffMode == 2)
            {
                for (int i = 0; i < Form1.simonTrack.Count; i++)
                {
                    Thread.Sleep(446);
                    switch (Form1.simonTrack[i])
                    {

                        case 1:
                            greenButton.BackColor = Color.Lime;
                            Refresh();
                            Thread.Sleep(460);
                            greenButton.BackColor = Color.ForestGreen;
                            Refresh();
                            break;

                        case 2:
                            yellowButton.BackColor = Color.Yellow;
                            Refresh();
                            Thread.Sleep(460);
                            yellowButton.BackColor = Color.DarkGoldenrod;
                            Refresh();
                            break;

                        case 3:
                            blueButton.BackColor = Color.RoyalBlue;
                            Refresh();
                            Thread.Sleep(460);
                            blueButton.BackColor = Color.DarkBlue;
                            Refresh();
                            break;

                        case 4:
                            redButton.BackColor = Color.Red;
                            Refresh();
                            Thread.Sleep(460);
                            redButton.BackColor = Color.DarkRed;
                            Refresh();
                            break;
                    }


                }
            }
            else if (Form1.diffMode == 3) 
            {
                for (int i = 0; i < Form1.simonTrack.Count; i++)
                {
                    Thread.Sleep(446);
                    switch (Form1.simonTrack[i])
                    {

                        case 1:
                            greenClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            Refresh();
                            break;

                        case 2:
                            yellowClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            Refresh();
                            break;

                        case 3:
                            blueClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            Refresh();
                            break;

                        case 4:
                            redClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            Refresh();
                            break;
                    }


                }
            }

            if (Form1.diffMode == 0)
            {
                for (int i = 0; i < Form1.simonTrack.Count; i++)
                {
                    Thread.Sleep(446);
                    switch (Form1.simonTrack[i])
                    {

                        case 1:
                            greenButton.BackColor = Color.Lime;
                            greenClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            greenButton.BackColor = Color.ForestGreen;
                            Refresh();
                            break;

                        case 2:
                            yellowButton.BackColor = Color.Yellow;
                            yellowClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            yellowButton.BackColor = Color.DarkGoldenrod;
                            Refresh();
                            break;

                        case 3:
                            blueButton.BackColor = Color.RoyalBlue;
                            blueClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            blueButton.BackColor = Color.DarkBlue;
                            Refresh();
                            break;

                        case 4:
                            redButton.BackColor = Color.Red;
                            redClick.Play();
                            Refresh();
                            Thread.Sleep(460);
                            redButton.BackColor = Color.DarkRed;
                            Refresh();
                            break;
                    }
                }
            }

            //TODO: set guess value back to 0
            simonGuess = 0;

        }

        //TODO: create one of these event methods for each button

        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value in the pattern list at index [guess] equal to a green?
            // change button color
            // play sound
            // refresh
            // pause
            // set button colour back to original
            // add one to the guess variable

            //TODO:check to see if we are at the end of the pattern, (guess is the same as pattern list count).
            // call ComputerTurn() method
            // else call GameOver method
            if (Form1.simonTrack[simonGuess] == 1)
            {
                greenButton.BackColor = Color.Lime;
                greenClick.Play();
                Refresh();
                Thread.Sleep(260);
                greenButton.BackColor = Color.ForestGreen;
                Refresh();
                simonGuess++;             
            }
            else
            {
                GameOver();
            }

            if (simonGuess == Form1.simonTrack.Count)
            {
                ComputerTurn();
            }
        }
        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.simonTrack[simonGuess] == 2)
            {
                yellowButton.BackColor = Color.Yellow;
                yellowClick.Play();
                Refresh();
                Thread.Sleep(260);
                yellowButton.BackColor = Color.DarkGoldenrod;
                Refresh();
                simonGuess++;

            }
            else
            {
                GameOver();
            }
            if (simonGuess == Form1.simonTrack.Count)
            {
                ComputerTurn();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.simonTrack[simonGuess] == 3)
            {
                blueButton.BackColor = Color.RoyalBlue;
                blueClick.Play();
                Refresh();
                Thread.Sleep(260);
                blueButton.BackColor = Color.DarkBlue;
                Refresh();
                simonGuess++;

            }
            else
            {
                GameOver();
            }
            if (simonGuess == Form1.simonTrack.Count)
            {
                ComputerTurn();
            }
        }
        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.simonTrack[simonGuess] == 4)
            {
                redButton.BackColor = Color.Red;
                redClick.Play();
                Refresh();
                Thread.Sleep(260);
                redButton.BackColor = Color.DarkRed;
                Refresh();
                simonGuess++;

            }
            else
            {
                GameOver();
            }
            if (simonGuess == Form1.simonTrack.Count)
            {
                ComputerTurn();
            }
        }

        public void GameOver()
        {
            //TODO: Play a game over sound
            gameLose.Play();
            //TODO: close this screen and open the GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen os = new GameOverScreen();

            // Centre the screen on the form
            os.Location = new Point((f.Width - os.Width) / 2, (f.Height - os.Height) / 2);


            f.Controls.Add(os);
            os.Focus();

        }

        
    }
}

