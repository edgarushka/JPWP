using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Options : Form
    {
        /// <summary>
        /// Options
        /// </summary>
        public Options()
        {
            InitializeComponent();
            this.exitBox.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);
        }
        /// <summary>
        /// Click at the exit box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
