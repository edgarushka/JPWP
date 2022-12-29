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
    public partial class Zasady : Form
    {
        public Zasady()
        {
            InitializeComponent();
        }

        private void exit_box_zasady_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_box_MouseHover(object sender, EventArgs e)
        {
            exit_box.Image = Properties.Resources.exit_hover;
        }

        private void exit_box_MouseLeave(object sender, EventArgs e)
        {
            exit_box.Image = Properties.Resources.exit_normal;
        }
    }
}
