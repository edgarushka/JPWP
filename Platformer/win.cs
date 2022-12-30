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
    public partial class Win : Form
    {
        private int money;
        public Win(int money)
        {
            this.money = money;
            InitializeComponent();
        }
        private void win_Load(object sender, EventArgs e)
        {
            
            winLabel.Text = "You won with "+money+"$";
        }

    }
}
