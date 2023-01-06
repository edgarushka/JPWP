﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Game : Form
    { 

        Image carsImg;
        Bitmap mapImg;

        Player player;

        const int MapWidth=5120;
        const int MapHeight=2816;
        const int CarSizePixel = 128;
        public int money;
        int[,] map;
        Point delta;

        private int carWidth = 80;
        private int carHeight = 216;

        public Game()
        {
            InitializeComponent();

            money = 10000;
            string workingDirectory = Environment.CurrentDirectory;

            carsImg = new Bitmap(@"D:\VISUAL PROJECTS\NFS Not Wanted\Platformer\Resources\models.png");
            mapImg = new Bitmap(global::Platformer.Properties.Resources.map) ;
            player = new Player(new Size(32,75),80,270,carsImg);
            delta = new Point(0, 0);
            map = new int[22, 40]{
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,0,0,0,1,1,1,1,2,2,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            };
            menuPanel.Location = new Point(
            this.ClientSize.Width / 2 - menuPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - menuPanel.Size.Height / 2);
            
        }
        private void MoneyLoss(object sender, EventArgs e)
        {
            if (map[(player.y+carWidth) / CarSizePixel, (player.x+carWidth) / CarSizePixel] == 1)
            {
                money -= 2;
                AlertGrass.Visible = true;
            }
            else if (map[(player.y) / CarSizePixel, (player.x+carWidth) / CarSizePixel] == 2)
            {
                Pause();
                Win win = new Win(money);
                win.Show();
            }
            else
            {
                AlertGrass.Visible = false;
            }
        }
        private void UpdateMovement(object sender, EventArgs e)
        {
            this.Invalidate();
            label2.Text = delta.X.ToString();
            label3.Text = player.x.ToString();
            label6.Text = player.y.ToString();
            label1.Text = player.speed.ToString();
            moneyLabel.Text = money.ToString();
        }

        private void CreateMap(Graphics gr)
        {
            gr.DrawImage(mapImg, delta.X, delta.Y, MapWidth, MapHeight);
        }
        
        private void PlayAnimation(Graphics gr)
        {
            // delta is speed offset
            

            var carPositionX = player.x + delta.X;
            var carPositionY = player.y + delta.Y;

            (carPositionX, carPositionY) = AdjustPosition((carPositionX, carPositionY));

            if (player.CurrAnimation == AnimationPosition.Up)
            {                
                gr.DrawImage(player.spritesAnimation, carPositionX, carPositionY, new Rectangle(new Point(68, 0), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
            }
            else if (player.CurrAnimation == AnimationPosition.Left)
            {
                gr.DrawImage(player.spritesAnimation, carPositionX, carPositionY, new Rectangle(new Point(27 + (carHeight * (int)player.CurrAnimation), 68), new Size(carHeight, carWidth)), GraphicsUnit.Pixel);
            }
            else if (player.CurrAnimation == AnimationPosition.Right)
            {
                gr.DrawImage(player.spritesAnimation, carPositionX, carPositionY, new Rectangle(new Point(27 + (carHeight * (int)player.CurrAnimation), 68), new Size(carHeight, carWidth)), GraphicsUnit.Pixel);
            }
            else if (player.CurrAnimation == AnimationPosition.Down)
            {
                gr.DrawImage(player.spritesAnimation, carPositionX, carPositionY, new Rectangle(new Point(68 + carHeight * (int)player.CurrAnimation, 0), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
            }
        }

        private (int x, int y) AdjustPosition((int x, int y) position)
        {
            var adjustedPosition = position;

            if(player.CurrAnimation == AnimationPosition.Up)
            {
                adjustedPosition.x = position.x + carWidth / 2;
                adjustedPosition.y = position.y - carHeight / 2;
            }
            else if(player.CurrAnimation == AnimationPosition.Down)
            {
                adjustedPosition.x = position.x + carWidth / 2;
                adjustedPosition.y = position.y - carHeight / 2;
            }
            else
            {
                adjustedPosition = position;
            }

            return adjustedPosition;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            CreateMap(gr);
            PlayAnimation(gr);
        }

        private void Pause()
        {
            if (timer1.Enabled == true)
            {
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
            }
            else if (timer1.Enabled == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
                timer3.Enabled = Enabled;
                timer2.Enabled = Enabled;
                timer1.Enabled = Enabled;
            }
        }
        private void StartBoxClick(object sender, EventArgs e)
        {
            menuPanel.Hide();
            Pause();
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "D":
                    player.CurrAnimation = AnimationPosition.Right;

                    if (player.x < MapWidth - base.Width / 2)
                    {
                        player.Right();

                        if (player.x >= base.Width / 2)
                        {
                            delta.X -= player.speed;
                        }

                    }
                    break;
                case "A":
                    player.CurrAnimation = AnimationPosition.Left;

                    if (player.x > 0)
                    {
                        if (player.x >= base.Width / 2 && player.x < MapWidth - base.Width / 2)
                        {
                            delta.X += player.speed;
                        }
                        player.Left();
                    }
                    break;
                case "W":
                    player.CurrAnimation = AnimationPosition.Up;

                    if (player.y > 0)
                    {
                        player.Up();

                        if (player.y > Height / 2 && player.y < MapHeight - Height / 2)
                        {
                            delta.Y += player.speed;
                        }
                    }
                    break;
                case "S":
                    player.CurrAnimation = AnimationPosition.Down;
                    if (player.y < MapHeight - Height / 2)
                    {
                        if (player.y > Height / 2)
                        {
                            delta.Y -= player.speed;
                        }
                        player.Down();
                    }
                    break;
            }
            if (e.KeyCode == Keys.Escape)
            {
                menuPanel.Show();

                Pause();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void GameLoad(object sender, EventArgs e)
        {

        }

        private void zasady_box_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AlertGrass_Click(object sender, EventArgs e)
        {

        }
    }
}