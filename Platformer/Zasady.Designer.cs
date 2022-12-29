namespace Platformer
{
    partial class Zasady
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_panel = new System.Windows.Forms.Panel();
            this.exit_box = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.SeaShell;
            this.menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_panel.Controls.Add(this.exit_box);
            this.menu_panel.Location = new System.Drawing.Point(1, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(890, 500);
            this.menu_panel.TabIndex = 7;
            // 
            // exit_box
            // 
            this.exit_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_box.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exit_box.Location = new System.Drawing.Point(366, 414);
            this.exit_box.Name = "exit_box";
            this.exit_box.Size = new System.Drawing.Size(150, 64);
            this.exit_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_box.TabIndex = 2;
            this.exit_box.TabStop = false;
            this.exit_box.Click += new System.EventHandler(this.exit_box_zasady_Click);
            this.exit_box.MouseLeave += new System.EventHandler(this.exit_box_MouseLeave);
            this.exit_box.MouseHover += new System.EventHandler(this.exit_box_MouseHover);
            // 
            // Zasady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 503);
            this.Controls.Add(this.menu_panel);
            this.DoubleBuffered = true;
            this.Name = "Zasady";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZASADY";
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox exit_box;
    }
}