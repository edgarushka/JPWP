using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image playerImg;
        Image mapImg;
        string lastkeypressed;
        private int currFrame = 0;
        private bool isPressedAnyKey;

        int[,] map;
        const int width =20;
        const int height=20;

        Point delta;

        public Form1()
        {
            InitializeComponent();
            playerImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\models.png");
            mapImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\map.jpg");
            timer2.Interval = 50;
            timer3.Interval = 10;
            timer2.Tick += new EventHandler(update);
            timer3.Tick += new EventHandler(updMovement);
            this.KeyDown += new KeyEventHandler(keyboard);
            this.KeyUp += new KeyEventHandler(noMovement);

            delta = new Point(0,0);

            map = new int[width, height] {
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            };
        }

        //public void CreateMap(object sender, Graphics gr, PaintEventArgs e)
        //{
        //    Graphics gra = e.Graphics;
        //    gra.DrawImage(mapImg, 0, 0);

        //    for (int i = 0; i < width; i++)
        //    {
        //        for (int j = 0; j < height; j++)
        //        {
        //            if (map[i, j] == 0)
        //            {

        //            }
        //        }
        //    }
        //}
        private void CreateMap(Graphics gra)
        {
            gra.DrawImage(mapImg, delta.X*10, delta.Y*10);
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gra = e.Graphics;

            CreateMap(gra);

        }

        private void noMovement(object sender, EventArgs e)
        {
            isPressedAnyKey = false;
            currFrame = -1;
        }
        private void updMovement(object sender, EventArgs e)
        {
            if (isPressedAnyKey)
            {
                //if (currFrame==0 )
                //{
                //    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);
                //}
                //if (currFrame == 6)
                //{
                //    pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y);
                //}
                //if (currFrame == 4 )
                //{
                //    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);
                //}
                //if (currFrame == 2)
                //{
                //    pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                //}
            }
        }

        private void keyboard(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                currFrame = 0;
                isPressedAnyKey = true;
                delta.Y++;
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                currFrame = 6;
                isPressedAnyKey = true;
                delta.X++;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                currFrame = 4;
                isPressedAnyKey = true;
                delta.Y--;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                currFrame = 2;
                isPressedAnyKey = true;
                delta.X--;
            }
            //if (e.KeyCode == Keys.W && (e.Modifiers == Keys.A || e.Control || e.Shift))
            //{
            //    currFrame = 7;
            //}
            label1.Text = "Last: " + e.KeyCode+lastkeypressed;
            lastkeypressed = e.KeyCode.ToString();
        }

        private void update(object sender, EventArgs e)
        {

            playAnimation();

            //currFrame++;
            if (currFrame == 8)
            {
                currFrame = 0;
            }
        }
        private void playAnimation()
        {
            if (currFrame != -1)
            {
 
                Image part = new Bitmap(216, 216);
                Graphics g = Graphics.FromImage(part);
                g.PageScale = 0.5f;
                g.ResetTransform();

                //if (currFrame != -1)
                //{
                //    g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(25 + (216 * currFrame), 25), new Size(216, 216)), GraphicsUnit.Pixel);
                //}

                if (currFrame == 0)
                {
                    g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(68, 27), new Size(80, 216)), GraphicsUnit.Pixel);
                }
                else if (currFrame == 6)
                {
                    g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(27 + (216 * currFrame), 68), new Size(216, 80)), GraphicsUnit.Pixel);
                }
                else if (currFrame == 2)
                {
                    g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(27 + 216 * currFrame, 68), new Size(216, 80)), GraphicsUnit.Pixel);
                }
                else if (currFrame == 4)
                {
                    g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(68 + 216 * currFrame, 27), new Size(80, 216)), GraphicsUnit.Pixel);
                }
                var test = ResizeImg.ResizeImage(part, 120, 120);
             
                pictureBox1.Image = test;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
