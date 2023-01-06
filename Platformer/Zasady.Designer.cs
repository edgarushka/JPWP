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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.SeaShell;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.exitBox);
            this.menuPanel.Location = new System.Drawing.Point(1, 0);
            this.menuPanel.Name = "menu_panel";
            this.menuPanel.Size = new System.Drawing.Size(890, 500);
            this.menuPanel.TabIndex = 7;
            // 
            // exit_box
            // 
            this.exitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBox.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exitBox.Location = new System.Drawing.Point(366, 414);
            this.exitBox.Name = "exit_box";
            this.exitBox.Size = new System.Drawing.Size(150, 64);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 2;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.ExitBoxClick);
            this.exitBox.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);
            this.exitBox.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            // 
            // Zasady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 503);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.Name = "Zasady";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZASADY";
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox exitBox;
    }
}