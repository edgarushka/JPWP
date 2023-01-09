namespace Platformer
{
    partial class Options
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
            this.escMenu = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.SeaShell;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.escMenu);
            this.menuPanel.Controls.Add(this.exitBox);
            this.menuPanel.Location = new System.Drawing.Point(1, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(672, 407);
            this.menuPanel.TabIndex = 7;
            // 
            // exitBox
            // 
            this.exitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBox.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exitBox.Location = new System.Drawing.Point(274, 336);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(112, 52);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 2;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.ExitBoxClick);
            // 
            // escMenu
            // 
            this.escMenu.AutoSize = true;
            this.escMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.escMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escMenu.ForeColor = System.Drawing.Color.Green;
            this.escMenu.Location = new System.Drawing.Point(205, 157);
            this.escMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.escMenu.Name = "escMenu";
            this.escMenu.Size = new System.Drawing.Size(243, 38);
            this.escMenu.TabIndex = 8;
            this.escMenu.Text = "COMING SOON";
            this.escMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 409);
            this.Controls.Add(this.menuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPTIONS";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.Label escMenu;
    }
}