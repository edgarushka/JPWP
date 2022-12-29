using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Game : Form
    { 
        Image playerImg;
        Bitmap mapImg;

        Player player;

        const int width=5120;
        const int height=2816;
        public int money;
        int[,] map;
        Point delta;
        public Game()
        {
            InitializeComponent();

            money = 10000;
            playerImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\models.png");
            mapImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\map.jpg");
            player = new Player(new Size(32,75),80,270,playerImg);
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
            menu_panel.Location = new Point(
            this.ClientSize.Width / 2 - menu_panel.Size.Width / 2,
            this.ClientSize.Height / 2 - menu_panel.Size.Height / 2);
            
        }
        private void moneyLoss(object sender, EventArgs e)
        {
            if (map[(player._y + 60) / 128, (player._x + 40) / 128] == 1)
            {
                money -= 2;
            }
            else if (map[(player._y + 60) / 128, (player._x + 40) / 128] == 2)
            {
                pause();
                win Win = new win();
                Win.Show();
            }
        }
        private void updMovement(object sender, EventArgs e)
        {
            this.Invalidate();
            label2.Text = delta.X.ToString();
            label3.Text = player._x.ToString();
            label6.Text = player._y.ToString();
            label1.Text = player.speed.ToString();
            money_label.Text = money.ToString();
        }

        private void CreateMap(Graphics gr)
        {
            gr.DrawImage(mapImg, delta.X, delta.Y, width, height);
        }
        private void PlayAnimation(Graphics gr)
        {
                if (player.currAnimation == 0)
                {
                    gr.DrawImage(player._spritesAnimation, player._x + delta.X, player._y + delta.Y, new Rectangle(new Point(68, 0), new Size(80, 216)), GraphicsUnit.Pixel);
                }
                else if (player.currAnimation == 6)
                {
                    gr.DrawImage(player._spritesAnimation, player._x + delta.X, player._y + delta.Y, new Rectangle(new Point(27 + (216 * player.currAnimation), 68), new Size(216, 80)), GraphicsUnit.Pixel);
                }
                else if (player.currAnimation == 2)
                {
                    gr.DrawImage(player._spritesAnimation, player._x + delta.X, player._y + delta.Y, new Rectangle(new Point(27 + (216 * player.currAnimation), 68), new Size(216, 80)), GraphicsUnit.Pixel);
                }
                else if (player.currAnimation == 4)
                {
                    gr.DrawImage(player._spritesAnimation, player._x + delta.X, player._y + delta.Y, new Rectangle(new Point(68 + 216 * player.currAnimation, 0), new Size(80, 216)), GraphicsUnit.Pixel);
                }
        }
        
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            CreateMap(gr);
            PlayAnimation(gr);
        }


        private void start_box_Click(object sender, EventArgs e)
        {
            menu_panel.Hide();
            pause();
            
        }
        private void pause()
        {
            if (timer1.Enabled == true)
            {
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
                timer3.Enabled = false;
                timer2.Enabled = false;
                timer1.Enabled = false;
            }
            else if (timer1.Enabled == false)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
                timer3.Enabled = Enabled;
                timer2.Enabled = Enabled;
                timer1.Enabled = Enabled;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "D":
                    player.currAnimation = 2;

                    if (player._x < width - Width / 2)
                    {
                        player.Right();

                        if (player._x >= Width / 2)
                        {
                            delta.X -= player.speed;
                        }

                    }
                    break;
                case "A":
                    player.currAnimation = 6;

                    if (player._x > 0)
                    {
                        if (player._x >= Width / 2 && player._x < width - Width / 2)
                        {
                            delta.X += player.speed;
                        }
                        player.Left();
                    }
                    break;
                case "W":
                    player.currAnimation = 0;

                    if (player._y > 0)
                    {
                        player.Up();

                        if (player._y > Height / 2 && player._y < height - Height / 2)
                        {
                            delta.Y += player.speed;
                        }
                    }
                    break;
                case "S":
                    player.currAnimation = 4;
                    if (player._y < height - Height / 2)
                    {
                        if (player._y > Height / 2)
                        {
                            delta.Y -= player.speed;
                        }
                        player.Down();
                    }
                    break;
            }
            if (e.KeyCode == Keys.Escape)
            {
                menu_panel.Show();

                pause();
            }
        }

        private void start_box_MouseHover(object sender, EventArgs e)
        {
            start_box.Image = Properties.Resources.start_hover;
        }

        private void option_box_MouseHover(object sender, EventArgs e)
        {
            option_box.Image = Properties.Resources.option_hover;
        }

        private void exit_box_MouseHover(object sender, EventArgs e)
        {
            exit_box.Image = Properties.Resources.exit_hover;
        }

        private void zasady_box_MouseHover(object sender, EventArgs e)
        {
            zasady_box.Image = Properties.Resources.zasady_hover;
        }

        private void start_box_MouseLeave(object sender, EventArgs e)
        {
            start_box.Image = Properties.Resources.start_normal;
        }

        private void option_box_MouseLeave(object sender, EventArgs e)
        {
            option_box.Image = Properties.Resources.option_normal;
        }

        private void exit_box_MouseLeave(object sender, EventArgs e)
        {
            exit_box.Image = Properties.Resources.exit_normal;
        }

        private void zasady_box_MouseLeave(object sender, EventArgs e)
        {
            zasady_box.Image = Properties.Resources.zasady_normal;
        }

        private void exit_box_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void zasady_box_Click(object sender, EventArgs e)
        {
            Zasady zasady_menu = new Zasady();
            zasady_menu.Show();
        }

    }
}
