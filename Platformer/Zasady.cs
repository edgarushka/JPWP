﻿using System;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Zasady : Form
    {
        
        public Zasady()
        {
            InitializeComponent();
        }

        private void exitBoxClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
