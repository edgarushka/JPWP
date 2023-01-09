using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Win : Form
    {
        private int money;
        public Win(int money)
        {
            this.money = money;
            InitializeComponent();
            this.exitBox.MouseHover += new EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new EventHandler(Buttons.ExitBoxMouseLeave);
            this.exitBox.Click += new EventHandler(ExitBoxClick);

            if (money <= 0)
            {
                winLabel.Visible= false;
                loseLabel.Visible = true;
            }
            else
            {
                winLabel.Visible = true;
                loseLabel.Visible = false;
            }
        }
        private void win_Load(object sender, EventArgs e)
        {
            winLabel.Text = "Wygrałeś z " + money + "$!";
            loseLabel.Text = "FAIL! Spróbuj jeszcze raz";
        }
        private void ExitBoxClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
