﻿using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Zasady : Form
    {
        /// <summary>
        /// Zasady window
        /// </summary>
        public Zasady()
        {
            InitializeComponent();
            this.exitBox.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            this.exitBox.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);

            firstSign.Text = "Skrzyżowanie dróg";
            secondSign.Text = "Ustąp pierwszeństwa";
            thirdSign.Text = "STOP";
            fourthSign.Text = "Zakaz skręcania w lewo";
            fifthSign.Text = "Nakaz jazdy w prawo za znakiem";
            sixthSign.Text = "Droga z pierwszeństwem";
        }
        /// <summary>
        /// Result of the clicking at exit box at Win window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
