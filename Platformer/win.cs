using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Win : Form
    {
        private int money;
        /// <summary>
        /// Win window
        /// </summary>
        /// <param name="money"></param>
        public Win(int money)
        {
            this.money = money;
            InitializeComponent();
            this.exitBox.MouseHover += new EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new EventHandler(Buttons.ExitBoxMouseLeave);
            this.exitBox.Click += new EventHandler(ExitBoxClick);

            winLabel.Text = "Wygrałeś z " + money + "$!";
            loseLabel.Text = "FAIL! Spróbuj jeszcze raz";
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
        /// <summary>
        /// Result of the clicking at exit box at Win window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBoxClick(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
