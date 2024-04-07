using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace NewFishGame
{
    public partial class GameScreen : Form
    {
        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        int xPos;
        int yPos;
        bool goLeft, goRight, goUp, goDown, showBins;
        int playerScore;

        List<Waste> wasteList = new List<Waste>();
        Waste selectedWaste;
        int totalWaste = 0;
        int wasteNumber = -1;
        int lineAnimation = 0;
        int wasteOnScreen = 0;

        List<string> imageLocation = new List<string>();


        public GameScreen()
        {
            InitializeComponent();

            showBins = false;
            paperBin.Visible = false;
            plasticBin.Visible = false;
            bioHazardsBin.Visible = false;
            batteriesBin.Visible = false;

            SetUpApp();

        }

        private void SetUpApp()
        {
            imageLocation = Directory.GetFiles("Waste", "*.jpeg").ToList();
            totalWaste = imageLocation.Count;
        }


        private void wasteFrquency(object sender, EventArgs e)
        {
            if (wasteOnScreen < 10 && showBins == false)
            {
                MakeWaste();
            }
        }

        private void MakeWaste()
        {
            wasteNumber = random.Next(0, totalWaste);
            wasteOnScreen++;

            Waste newWaste = new Waste(imageLocation[wasteNumber], 75, 100);

            xPos = random.Next(10, this.ClientSize.Width - newWaste.width);
            yPos = random.Next(0 + newWaste.height, this.ClientSize.Height/4);

            newWaste.position.X = xPos;
            newWaste.position.Y = yPos;

            newWaste.rect.X = newWaste.position.X;
            newWaste.rect.Y = newWaste.position.Y;

            wasteList.Add(newWaste);
        }

        public void RestartGame()
        {
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft && player.Left > 0)
            {
                player.Left -= 15;
            }

            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 15;
            }
            if (goUp && player.Top > this.ClientSize.Height / 2)
            {
                player.Top -= 15;
            }
            if (goDown && player.Bottom < this.ClientSize.Height)
            {
                player.Top += 15;
            }

            if (showBins == false)
            {
                foreach (Waste waste in wasteList)
                {
                    if (waste.position.Y < this.ClientSize.Height - waste.height)
                    {
                        
                        waste.position.Y += 5;
                        waste.rect.Y = waste.position.Y;
                    }
                }
            }

        }
        private void TrashTimerEvent(object sender, EventArgs e)
        {
            foreach (Waste waste in wasteList)
            {
                waste.rect.X = waste.position.X;
                waste.rect.Y = waste.position.Y;

                if (showBins == false && player.Bounds.IntersectsWith(waste.rect))
                {
                    EndGame();
                }
            }

            if (selectedWaste != null)
            {
                if (lineAnimation < 5)
                {
                    lineAnimation++;
                }
            }

            this.Invalidate();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (showBins == false)
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                    player.Image = Properties.Resources.fish;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                    player.Image = Properties.Resources.fish_flipped;
                }
                if (e.KeyCode == Keys.Up)
                {
                    goUp = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    goDown = true;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GamePaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Waste waste in wasteList)
            {
                e.Graphics.DrawImage(waste.wastePic, waste.position.X, waste.position.Y, waste.width, waste.height);

                Pen outline;

                if (waste.active)
                {
                    outline = new Pen(Color.Red, lineAnimation);
                }
                else
                {
                    outline = new Pen(Color.Transparent, 1);
                }

                e.Graphics.DrawRectangle(outline, waste.rect);
            }
            if (selectedWaste != null)
            {
                e.Graphics.DrawImage(selectedWaste.wastePic, selectedWaste.position.X, selectedWaste.position.Y, selectedWaste.width, selectedWaste.height);
            }
        }
        private void GameMouseMove(object sender, MouseEventArgs e)
        {
            if (showBins == true)
            {
                if (selectedWaste != null)
                {
                    selectedWaste.position.X = e.X - (selectedWaste.width / 2);
                    selectedWaste.position.Y = e.Y - (selectedWaste.height / 2);
                }
            }
        }

        private void GameMouseUp(object sender, MouseEventArgs e)
        {
            foreach (Waste tempWaste in wasteList)
            {
                tempWaste.active = false;
            }
            selectedWaste = null;
            lineAnimation = 0;
        }

        private void GameMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);

            if (showBins == true)
            {
                foreach (Waste newWaste in wasteList)
                {
                    if (selectedWaste == null)
                    {
                        if (newWaste.rect.Contains(mousePosition))
                        {
                            selectedWaste = newWaste;
                            newWaste.active = true;
                        }
                    }

                }
            }
        }

        private void wasteBinsButton_Click(object sender, EventArgs e)
        {
            if (showBins == true)
            {
                showBins = false;

                paperBin.Visible = false;
                plasticBin.Visible = false;
                bioHazardsBin.Visible = false;
                batteriesBin.Visible = false;
            }
            else
            {
                showBins = true;

                paperBin.Visible = true;
                plasticBin.Visible = true;
                bioHazardsBin.Visible = true;
                batteriesBin.Visible = true;
            }
        }

        private void EndGame()
        {
            playerTimer.Stop();
            trashTimer.Stop();
            frequency.Stop();

            playerScore = 0;

            player.Image = Properties.Resources.fish_dead;

            MessageBox.Show("Game OVER!!!");
            this.Close();
        }
    }
}
