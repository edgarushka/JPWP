using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void ExitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
