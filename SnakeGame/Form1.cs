using System;
using System.Collections.Generic;

using System.Drawing;

using System.Windows.Forms;

using System.Drawing.Imaging;
namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            { 
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
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

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "My score: " + score + " and my HighScore is " + highScore + " in the Snake Game";
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            caption.ForeColor = Color.White;
            caption.Font = new Font("Segoe UI Variable Display", 12, FontStyle.Bold);
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game Snapshoot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            { 
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if(goLeft)
            {
                Settings.directions = "left";
                                                    
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            if (goDown)
            { 
                Settings.directions = "down";
            }
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }

                }

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

            }

            picCanvas.Invalidate();

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;
            

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                 
                    snakeColour = Brushes.DarkGreen;
           
                }
                else
                {
                    snakeColour = Brushes.Green;
                 

                }

                canvas.FillRectangle(snakeColour, new Rectangle
                    (
                    Snake[i].X* Settings.Width,
                    Snake[i].Y* Settings.Height,
                    Settings.Width, Settings.Height));
                    
                    
                
            }

           canvas.FillEllipse(Brushes.Gray, new Rectangle
                   (
                   food.X * Settings.Width,
                   food.Y * Settings.Height,
                   Settings.Width, Settings.Height)); 
        }

       

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();
            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            textScore.Text = "score: " + score;

            Circle head = new Circle { X = 10, Y = 5};
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            { 
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight)};

            GameTimer.Start();
        }

        private void EatFood()
        {
            score += 1;

            textScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y

            };

            Snake.Add(body);

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            GameTimer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;
            

            if (score > highScore)
            { 
            highScore = score;
                textHighScore.Text = "high score: " + highScore;
                textHighScore.ForeColor = Color.White;
                textHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }


    }
}
