using System;
using System.Windows.Forms;

namespace Platformer
{
    public static class Buttons
    {
    
        public static void StartBoxMouseHover(object sender, EventArgs e)
        {
            var startBox = (PictureBox)sender;
            startBox.Image = Properties.Resources.start_hover;
        }

        public static void OptionBoxMouseHover(object sender, EventArgs e)
        {
            var optionBox = (PictureBox)sender;
            optionBox.Image = Properties.Resources.option_hover;
        }

        public static void ExitBoxMouseHover(object sender, EventArgs e)
        {
            var exitBox = (PictureBox)sender;
            exitBox.Image = Properties.Resources.exit_hover;
        }

        public static void ZasadyBoxMouseHover(object sender, EventArgs e)
        {
            var zasadyBox = (PictureBox)sender;
            zasadyBox.Image = Properties.Resources.zasady_hover;
        }

        public static void StartBoxMouseLeave(object sender, EventArgs e)
        {
            var startBox = (PictureBox)sender;
            startBox.Image = Properties.Resources.start_normal;
        }

        public static void OptionBoxMouseLeave(object sender, EventArgs e)
        {
            var optionBox = (PictureBox)sender;
            optionBox.Image = Properties.Resources.option_normal;
        }

        public static void ExitBoxMouseLeave(object sender, EventArgs e)
        {
            var exitBox = (PictureBox)sender;
            exitBox.Image = Properties.Resources.exit_normal;

        }

        public static void ZasadyBoxMouseLeave(object sender, EventArgs e)
        {
            var zasadyBox = (PictureBox)sender;
            zasadyBox.Image = Properties.Resources.zasady_normal;
        }

        public static void ExitBoxClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void ZasadyBoxClick(object sender, EventArgs e)
        {
            Zasady zasady_menu = new Zasady();
            zasady_menu.Show();
        }
        public static void OptionsBoxClick(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

    }
}
