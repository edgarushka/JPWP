using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
        }

        private void win_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            win_label.Text = "You won with "+game.money+"$";
        }

    }
}
