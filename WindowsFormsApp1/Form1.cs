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
        PictureBox[] cloud;
        Image playerImg;
        Random rnd;
        int backgroundspeed;
        string lastkeypressed;
        private int currFrame = 0;
        public Form1()
        {
            InitializeComponent();
            playerImg = new Bitmap("D:\\VISUAL PROJECTS\\WindowsFormsApp1\\WindowsFormsApp1\\Resources\\models.png");
            pictureBox1.Image = playerImg;
            timer2.Interval = 10;
            timer1.Interval = 500;
            timer2.Tick += new EventHandler(update);
            timer1.Tick += new EventHandler(update);
            //pictureBox1.Location = new Point(512,216);
            this.KeyDown+=new KeyEventHandler(keyboard);
            
        }

        private void keyboard(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.W || e.KeyCode ==Keys.Up)
            {
                currFrame = 0;
                //if( lastkeypressed== "A")
                //{
                //    currFrame = 7;
                //}
                //else if (lastkeypressed == "D")
                //{
                //    currFrame = 1;
                //}
            }
            else if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                currFrame = 6;
            }
            else if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                currFrame = 4;
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                currFrame = 2;
            }
            //else if((int)e.KeyData == (int)Keys.Control + (int)Keys.Up)
            //{
            //    currFrame = 7;gghjghjghj
            //    MessageBox.Show("Ctrl + Up pressed...");
            //}
            //else if(e.Modifiers==Keys.W && e.KeyCode == Keys.D)
            //{
            //    currFrame = 1;
            //}
            //else if(e.Modifiers==Keys.A && e.KeyCode == Keys.S)
            //{
            //    currFrame = 5;
            //}
            //else if(e.Modifiers==Keys.D && e.KeyCode == Keys.S)
            //{
            //    currFrame = 3;
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
                g.DrawImage(playerImg, 0, 0, new Rectangle(new Point(25 + 216 * currFrame, 25), new Size(216, 216)), GraphicsUnit.Pixel);
                var test = ResizeImage(part, 100, 100);
                pictureBox1.Image = test;
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i =0; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }
            for (int i = cloud.Length; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroundspeed - 10;
                if (cloud[i].Left >= 1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundspeed = 5;
            cloud = new PictureBox[20];
            rnd = new Random();
            
            for (int i = 0; i < cloud.Length; i++)
            {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(rnd.Next(-1000, 1280), rnd.Next(140, 320));

                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(rnd.Next(100, 255), rnd.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 200, 200);
  
                }
                else
                {
                    cloud[i].Size = new Size(150, 25);
                    cloud[i].BackColor = Color.FromArgb(rnd.Next(50, 125), 255, 205, 205);
                }
                Controls.Add(cloud[i]);

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
