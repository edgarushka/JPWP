using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Zasady : Form
    {
        
        public Zasady()
        {
            InitializeComponent();
            this.exitBox.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);
        }

        private void ExitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
