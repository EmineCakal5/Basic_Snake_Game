using Snake_Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    public class GameScreen : Form
    {
        private List<Coord> snake = new List<Coord>();
        private Coord food;
        private Direction direction = Direction.Right;
        private Timer gameTimer = new Timer();
        private Random rand = new Random();
        private int gridSize = 20;
        private int tileSize = 20;

        public GameScreen()
        {
            this.Width = gridSize * tileSize + 16;
            this.Height = gridSize * tileSize + 39;
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Text = "Simple Snake Game";
            this.BackColor = Color.Black;

            gameTimer.Interval = 150;
            gameTimer.Tick += GameLoop;
            this.KeyDown += OnKeyDown;

            StartGame();
        }

        private void StartGame()
        {
            snake.Clear();
            snake.Add(new Coord(10, 10));
            direction = Direction.Right;
            SpawnFood();
            gameTimer.Start();
        }

        private void SpawnFood()
        {
            Coord newFood;
            do
            {
                newFood = new Coord(rand.Next(0, gridSize), rand.Next(0, gridSize));
            } while (snake.Any(s => s.Equals(newFood)));

            food = newFood;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != Direction.Down) direction = Direction.Up;
                    break;
                case Keys.Down:
                    if (direction != Direction.Up) direction = Direction.Down;
                    break;
                case Keys.Left:
                    if (direction != Direction.Right) direction = Direction.Left;
                    break;
                case Keys.Right:
                    if (direction != Direction.Left) direction = Direction.Right;
                    break;
            }
        }

        private void GameLoop(object sender, EventArgs e)
        {
            Coord head = new Coord(snake[0].X, snake[0].Y);

            switch (direction)
            {
                case Direction.Up: head.Y--; break;
                case Direction.Down: head.Y++; break;
                case Direction.Left: head.X--; break;
                case Direction.Right: head.X++; break;
            }

            if (head.X < 0 || head.Y < 0 || head.X >= gridSize || head.Y >= gridSize ||
                snake.Any(s => s.Equals(head)))
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
                StartGame();
                return;
            }

            snake.Insert(0, head);

            if (head.Equals(food))
            {
                SpawnFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var segment in snake)
            {
                g.FillRectangle(Brushes.LimeGreen, segment.X * tileSize, segment.Y * tileSize, tileSize, tileSize);
            }

            g.FillEllipse(Brushes.Red, food.X * tileSize, food.Y * tileSize, tileSize, tileSize);
        }
    }
}
