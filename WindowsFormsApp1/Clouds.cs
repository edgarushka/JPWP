using System;

public class Clouds
{
    private void timer1_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < cloud.Length; i++)
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
}
