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
        private PictureBox[] carEnemyBox;
        private PictureBox carPlayerBox = new PictureBox();

        public const int Speed = 30;
        const int MapWidth = 5120;
        const int MapHeight = 2816;
        const int SectionSizePixel = 128;
        public int money;
        public int currY;
        readonly int[,] map;

        Point delta;

        private readonly int carWidth = 111;
        private readonly int carHeight = 218;
        public Game()
        {
            InitializeComponent();

            money = 10000;
            currY = 0;

            carEnemyBox = new PictureBox[4];

            for (int i = 0; i < carEnemyBox.Length; i++)
            {
                carEnemyBox[i] = new PictureBox();
                Controls.Add(carEnemyBox[i]);
                carEnemyBox[i].BackColor = Color.Gray;
                carEnemyBox[i].Size = new Size(carWidth, carHeight);
            }

            carPlayerBox.BackColor = Color.Gray;
            Controls.Add(carPlayerBox);

            carsImg = Properties.Resources.models2;
            mapImg = Properties.Resources.map;

            player = new Player(new Size(80, 270), 80, 270, carsImg);
            delta = new Point(0, 0);

            menuPanel.Location = new Point(
            this.ClientSize.Width / 2 - menuPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - menuPanel.Size.Height / 2);

            map = new int[22, 40]{
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,3,1,1,1,4,4,4,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,3,0,0,3,0,0,3,1,1,3,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,3,0,0,3,0,0,3,1,1,3,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 3,3,3,3,3,3,3,1,1,0,0,1,1,3,3,3,3,3,3,3,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,0,1,1,3,1,1,1,0,0,0,1,1,1,1,0,0,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,0,3,1,1,1,1,1,1,0,0,0,1,1,1,1,2,2,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,4,4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,4,4,4,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            };

            exitBox.MouseHover += new EventHandler(Buttons.ExitBoxMouseHover);
            exitBox.MouseLeave += new EventHandler(Buttons.ExitBoxMouseLeave);
            exitBox.Click += new EventHandler(Buttons.ExitBoxClick);
            startBox.MouseHover += new EventHandler(Buttons.StartBoxMouseHover);
            startBox.MouseLeave += new EventHandler(Buttons.StartBoxMouseLeave);
            optionBox.MouseHover += new EventHandler(Buttons.OptionBoxMouseHover);
            optionBox.MouseLeave += new EventHandler(Buttons.OptionBoxMouseLeave);
            optionBox.Click += new EventHandler(Buttons.OptionsBoxClick);
            zasadyBox.MouseHover += new EventHandler(Buttons.ZasadyBoxMouseHover);
            zasadyBox.MouseLeave += new EventHandler(Buttons.ZasadyBoxMouseLeave);
            zasadyBox.Click += new EventHandler(Buttons.ZasadyBoxClick);
        }
        private void MoneyLoss()
        {
            Win win = new Win(money);
            if (money > 0)
            {
                if (map[(player.y + carWidth / 2) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 1)
                {
                    money -= 100;
                    alertGrass.Visible = true;
                }
                else if (map[(player.y) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 2)
                {
                    Pause();
                    win.Show();
                }
                else if (map[(player.y) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 3)
                {
                    money -= 500;
                    wrongSignLabel.Visible = true;
                }               
                else if (map[(player.y) / SectionSizePixel, (player.x + carWidth) / SectionSizePixel] == 4)
                {
                    wrongSignLabel.Visible = true;
                }
                else
                {
                    alertGrass.Visible = false;
                    wrongSignLabel.Visible = false;
                }
                for (int i = 0; i < carEnemyBox.Length; i++)
                {
                    if (carPlayerBox.Bounds.IntersectsWith(carEnemyBox[i].Bounds))
                    {
                        money = 0;
                    }
                }
            }
            else
            {
                Pause();
                win.Show();
            }
        }
        private void UpdateMovement(object sender, EventArgs e)
        {
            this.Invalidate();
            moneyLabel.Text = money.ToString() + "$";
        }

        private void CreateMap(Graphics gr)
        {
            gr.DrawImage(mapImg, delta.X, delta.Y, MapWidth, MapHeight);
        }

        private void PlayAnimation()
        {
            Image leftRightImage = new Bitmap(carHeight, carWidth);
            Image upDownImage = new Bitmap(carWidth, carHeight);

            var carPositionX = player.x + delta.X;
            var carPositionY = player.y + delta.Y;

            (carPositionX, carPositionY) = AdjustPosition((carPositionX, carPositionY));

            if (player.CurrAnimation == AnimationPosition.Up)
            {
                Graphics g = Graphics.FromImage(upDownImage);
                g.DrawImage(carsImg, 0, 0, new Rectangle(new Point(42, 1), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
                carPlayerBox.Location = new Point(carPositionX, carPositionY);
                carPlayerBox.Size = new Size(carWidth, carHeight);
                carPlayerBox.Image = upDownImage;
            }
            else if (player.CurrAnimation == AnimationPosition.Left)
            {
                Graphics g = Graphics.FromImage(leftRightImage);
                g.DrawImage(carsImg, 0, 0, new Rectangle(new Point(((carHeight - 50) * (int)player.CurrAnimation), 42), new Size(carHeight, carWidth)), GraphicsUnit.Pixel);
                carPlayerBox.Location = new Point(carPositionX, carPositionY);
                carPlayerBox.Size = new Size(carHeight, carWidth);
                carPlayerBox.Image = leftRightImage;
            }
            else if (player.CurrAnimation == AnimationPosition.Right)
            {
                Graphics g = Graphics.FromImage(leftRightImage);
                g.DrawImage(carsImg, 0, 0, new Rectangle(new Point(((carHeight - 50) * (int)player.CurrAnimation), 42), new Size(carHeight, carWidth)), GraphicsUnit.Pixel);
                carPlayerBox.Location = new Point(carPositionX, carPositionY);
                carPlayerBox.Size = new Size(carHeight, carWidth);
                carPlayerBox.Image = leftRightImage;
            }
            else if (player.CurrAnimation == AnimationPosition.Down)
            {
                Graphics g = Graphics.FromImage(upDownImage);
                g.DrawImage(carsImg, 0, 0, new Rectangle(new Point((carHeight - 31) * (int)player.CurrAnimation, 0), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);
                carPlayerBox.Location = new Point(carPositionX, carPositionY);
                carPlayerBox.Size = new Size(carWidth, carHeight);
                carPlayerBox.Image = upDownImage;
            }
        }

        private (int x, int y) AdjustPosition((int x, int y) position)
        {
            var adjustedPosition = position;

            if (player.CurrAnimation == AnimationPosition.Up)
            {
                adjustedPosition.x = position.x + (carWidth / 2);
                adjustedPosition.y = position.y - (carHeight / 3);
            }
            else if (player.CurrAnimation == AnimationPosition.Down)
            {
                adjustedPosition.x = position.x + (carWidth / 2);
                adjustedPosition.y = position.y - (carHeight / 3);
            }
            else
            {
                adjustedPosition = position;
            }

            return adjustedPosition;
        }
        private void PaintEnemy(int currY)
        {
            this.currY = currY;

            int firstCarPositionX = 24 * SectionSizePixel;
            int firstCarPositionY = 21 * SectionSizePixel;
            int secondCarPositionX = 25 * SectionSizePixel;
            int secondCarPositionY = 30 * SectionSizePixel;
            int thirdCarPositionX = 25 * SectionSizePixel;
            int thirdCarPositionY = 40 * SectionSizePixel;
            int fourthCarPositionX = 24 * SectionSizePixel;
            int fourthCarPositionY = 34 * SectionSizePixel;

            Image UpDown = new Bitmap(carWidth, carHeight);
            Graphics g = Graphics.FromImage(UpDown);
            g.DrawImage(carsImg, 0, 0, new Rectangle(new Point(41, 170), new Size(carWidth, carHeight)), GraphicsUnit.Pixel);

            for (int i = 0; i < carEnemyBox.Length; i++)
            {
                if (i == 0)
                {
                    carEnemyBox[i].Location = new Point(firstCarPositionX + delta.X, firstCarPositionY + delta.Y - currY);
                }
                else if (i == 1)
                {
                    carEnemyBox[i].Location = new Point(secondCarPositionX + delta.X, secondCarPositionY + delta.Y - currY);
                }
                else if (i == 2)
                {
                    carEnemyBox[i].Location = new Point(thirdCarPositionX + delta.X, thirdCarPositionY + delta.Y - currY);
                }
                else if (i == 3)
                {
                    carEnemyBox[i].Location = new Point(fourthCarPositionX + delta.X, fourthCarPositionY + delta.Y - currY);
                }
                else
                {
                    return;
                }
                carEnemyBox[i].Image = UpDown;
            }
        }

        private void EnemySpeedTimer_Tick(object sender, EventArgs e)
        {
            if (currY >= 0 && currY < 2 * 21 * SectionSizePixel)
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
            PlayAnimation();
            PaintEnemy(currY);
        }

        private void Pause()
        {
            if (MoneyTimer.Enabled == true)
            {
                this.KeyDown -= new KeyEventHandler(this.GameKeyDown);
                EnemySpeedTimer.Enabled = false;
                MovementTimer.Enabled = false;
                MoneyTimer.Enabled = false;
            }
            else if (MoneyTimer.Enabled == false)
            {
                this.KeyDown += new KeyEventHandler(this.GameKeyDown);
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
                    MoneyLoss();
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
                    MoneyLoss();
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
                    MoneyLoss();
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
                    MoneyLoss();
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

    }
}
