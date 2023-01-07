using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Game : Form
    {

        Image carsImg;
        Bitmap mapImg;

        Player player;
        PictureBox[] carEnemy;

        public const int Speed = 30;
        const int MapWidth = 5120;
        const int MapHeight = 2816;
        const int SectionSizePixel = 128;
        public int money;
        public int currY;
        int[,] map;
        Point delta;

        private int carWidth = 80;
        private int carHeight = 216;

        public Game()
        {
            InitializeComponent();
            this.exitBox.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);
            this.exitBox.Click += new System.EventHandler(Buttons.ExitBoxClick);
            this.startBox.MouseHover += new System.EventHandler(Buttons.StartBoxMouseHover);
            this.startBox.MouseLeave += new System.EventHandler(Buttons.StartBoxMouseLeave);
            this.optionBox.MouseHover += new System.EventHandler(Buttons.OptionBoxMouseHover);
            this.optionBox.MouseLeave += new System.EventHandler(Buttons.OptionBoxMouseLeave);
            this.optionBox.Click += new System.EventHandler(Buttons.OptionsBoxClick);
            this.zasadyBox.MouseHover += new System.EventHandler(Buttons.ZasadyBoxMouseHover);
            this.zasadyBox.MouseLeave += new System.EventHandler(Buttons.ZasadyBoxMouseLeave);
            this.zasadyBox.Click += new System.EventHandler(Buttons.ZasadyBoxClick);

            money = 10000;
            currY = 0;

            carEnemy = new PictureBox[1];

            carsImg = Properties.Resources.models;
            mapImg = Properties.Resources.map;
            player = new Player(new Size(80, 270), 80, 270, carsImg);
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
            if (map[(player.y + carWidth) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 1)
            {
                money -= 2;
                alertGrass.Visible = true;
            }
            else if (map[(player.y) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 2)
            {
                Pause();
                Win win = new Win(money);
                win.Show();
            }
            else
            {
                alertGrass.Visible = false;
            }
        }
        private void UpdateMovement(object sender, EventArgs e)
        {
            this.Invalidate();
            label2.Text = delta.X.ToString();
            label3.Text = player.x.ToString();
            label6.Text = player.y.ToString();
            label1.Text = Speed.ToString();
            moneyLabel.Text = money.ToString() + "$";

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

            if (player.CurrAnimation == AnimationPosition.Up)
            {
                adjustedPosition.x = position.x + carWidth / 2;
                adjustedPosition.y = position.y - carHeight / 2;
            }
            else if (player.CurrAnimation == AnimationPosition.Down)
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
        private void PaintEnemy(Graphics gr, int currY)
        {

            this.currY = currY;
            int FirstCarPositionX = 25 * SectionSizePixel;
            int FirstCarPositionY = 21 * SectionSizePixel;
            int SecondCarPositionX = 26 * SectionSizePixel;
            int SecondCarPositionY = 30 * SectionSizePixel;
            int ThirdCarPositionX = 26 * SectionSizePixel;
            int ThirdCarPositionY = 40 * SectionSizePixel;

            gr.DrawImage(player.spritesAnimation, FirstCarPositionX + delta.X, FirstCarPositionY + delta.Y - currY, new Rectangle(new Point(68, carHeight), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
            gr.DrawImage(player.spritesAnimation, SecondCarPositionX + delta.X, SecondCarPositionY + delta.Y - currY, new Rectangle(new Point(68, carHeight), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
            gr.DrawImage(player.spritesAnimation, ThirdCarPositionX + delta.X, ThirdCarPositionY + delta.Y - currY, new Rectangle(new Point(68, carHeight), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
        }

        private void EnemySpeedTimer_Tick(object sender, EventArgs e)
        {
            if (currY >= 0 && currY < 2 * 22 * SectionSizePixel)
            {
                currY += 20;
            }
            else
            {
                currY = 0;
            }
        }


        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            CreateMap(gr);
            PlayAnimation(gr);
            PaintEnemy(gr, currY);
        }

        private void Pause()
        {
            if (MoneyTimer.Enabled == true)
            {
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
                EnemySpeedTimer.Enabled = false;
                MovementTimer.Enabled = false;
                MoneyTimer.Enabled = false;
            }
            else if (MoneyTimer.Enabled == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
                EnemySpeedTimer.Enabled = Enabled;
                MovementTimer.Enabled = Enabled;
                MoneyTimer.Enabled = Enabled;
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
                            delta.X -= Speed;
                        }

                    }
                    break;
                case "A":
                    player.CurrAnimation = AnimationPosition.Left;

                    if (player.x > 0)
                    {
                        if (player.x >= base.Width / 2 && player.x < MapWidth - base.Width / 2)
                        {
                            delta.X += Speed;
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
                            delta.Y += Speed;
                        }
                    }
                    break;
                case "S":
                    player.CurrAnimation = AnimationPosition.Down;
                    if (player.y < MapHeight - Height / 2)
                    {
                        if (player.y > Height / 2)
                        {
                            delta.Y -= Speed;
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

        private void Label3_Click(object sender, EventArgs e)
        {

        }



        private void GameLoad(object sender, EventArgs e)
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
