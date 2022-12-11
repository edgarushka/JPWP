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
    public partial class Form1 : Form
    { 
        Image playerImg;
        Image mapImg;

        Player player;
 

        const int width=6400;
        const int height=3760;

        Point delta;
        int[,] map;

        public Form1()
        {
            InitializeComponent();
            playerImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\models.png");
            mapImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\map.jpg");
           
            player = new Player(new Size(32,75),80,370,playerImg);
            timer2.Interval = 10;
            timer2.Tick += new EventHandler(updMovement);
            timer2.Start();
            delta = new Point(0, 0);



            this.KeyDown += new KeyEventHandler(keyboard);

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        private void updMovement(object sender, EventArgs e)
        {
            this.Invalidate();
            label2.Text = delta.X.ToString();
        }
        private void keyboard(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "D":
                    player.currAnimation = 2;

                    if (player._x < width - Width / 2)
                    {
                        player.Right();


                        if (player._x > Width / 2 && player._x < width - Width / 2)
                            delta.X -= player.speed;
                    }
                    break;
                case "A":
                    player.currAnimation = 6;

                    if (player._x > 0)
                    {
                        player.Left();

                    if (player._x > Width / 2 && player._x < width - Width / 2)
                        delta.X += player.speed;
                    }
                    break;
                case "W":
                    player.currAnimation = 0;

                    if (player._y > 0)
                    {
                        player.Up();
                        
                    if (player._y > Height / 2 && player._y < height - Height / 2)
                        delta.Y += player.speed;
                    }
                    break;
                case "S":
                    player.currAnimation = 4;
                    if (player._y < height-Height/2)
                    {
                        player.Down();

                    if (player._y > Height / 2 && player._y < height - Height / 2)
                        delta.Y -= player.speed;
                    }
                    break;
                   
                    
            }
        }
        private void CreateMap(Graphics gr)
        {
            gr.DrawImage(mapImg, delta.X, delta.Y);
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

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
