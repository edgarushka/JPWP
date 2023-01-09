namespace Platformer
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MoneyTimer = new System.Windows.Forms.Timer(this.components);
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemySpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.moneyLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.zasadyBox = new System.Windows.Forms.PictureBox();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.optionBox = new System.Windows.Forms.PictureBox();
            this.startBox = new System.Windows.Forms.PictureBox();
            this.escMenu = new System.Windows.Forms.Label();
            this.alertGrass = new System.Windows.Forms.Label();
            this.wrongSignLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zasadyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementTimer
            // 
            this.MovementTimer.Interval = 10;
            this.MovementTimer.Tick += new System.EventHandler(this.UpdateMovement);
            // 
            // EnemySpeedTimer
            // 
            this.EnemySpeedTimer.Interval = 50;
            this.EnemySpeedTimer.Tick += new System.EventHandler(this.EnemySpeedTimer_Tick);
            // 
            // moneyLabel
            // 
            this.moneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Green;
            this.moneyLabel.Location = new System.Drawing.Point(1097, 53);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(125, 38);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "10000$";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.AutoSize = true;
            this.menuPanel.BackColor = System.Drawing.Color.SeaShell;
            this.menuPanel.BackgroundImage = global::Platformer.Properties.Resources.menu;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.zasadyBox);
            this.menuPanel.Controls.Add(this.exitBox);
            this.menuPanel.Controls.Add(this.optionBox);
            this.menuPanel.Controls.Add(this.startBox);
            this.menuPanel.Location = new System.Drawing.Point(499, 150);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 407);
            this.menuPanel.TabIndex = 6;
            // 
            // zasadyBox
            // 
            this.zasadyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zasadyBox.Image = global::Platformer.Properties.Resources.zasady_normal;
            this.zasadyBox.Location = new System.Drawing.Point(95, 141);
            this.zasadyBox.Margin = new System.Windows.Forms.Padding(2);
            this.zasadyBox.Name = "zasadyBox";
            this.zasadyBox.Size = new System.Drawing.Size(112, 52);
            this.zasadyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zasadyBox.TabIndex = 3;
            this.zasadyBox.TabStop = false;
            // 
            // exitBox
            // 
            this.exitBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBox.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exitBox.Location = new System.Drawing.Point(95, 255);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(112, 52);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBox.TabIndex = 2;
            this.exitBox.TabStop = false;
            // 
            // optionBox
            // 
            this.optionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionBox.Image = global::Platformer.Properties.Resources.option_normal;
            this.optionBox.Location = new System.Drawing.Point(95, 198);
            this.optionBox.Margin = new System.Windows.Forms.Padding(2);
            this.optionBox.Name = "optionBox";
            this.optionBox.Size = new System.Drawing.Size(112, 52);
            this.optionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optionBox.TabIndex = 1;
            this.optionBox.TabStop = false;
            // 
            // startBox
            // 
            this.startBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startBox.Image = global::Platformer.Properties.Resources.start_normal;
            this.startBox.Location = new System.Drawing.Point(95, 84);
            this.startBox.Margin = new System.Windows.Forms.Padding(2);
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(112, 52);
            this.startBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startBox.TabIndex = 0;
            this.startBox.TabStop = false;
            this.startBox.Click += new System.EventHandler(this.StartBoxClick);
            // 
            // escMenu
            // 
            this.escMenu.AutoSize = true;
            this.escMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.escMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.escMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.escMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escMenu.ForeColor = System.Drawing.Color.Green;
            this.escMenu.Location = new System.Drawing.Point(21, 53);
            this.escMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.escMenu.Name = "escMenu";
            this.escMenu.Size = new System.Drawing.Size(203, 38);
            this.escMenu.TabIndex = 7;
            this.escMenu.Text = "ESC - MENU";
            this.escMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alertGrass
            // 
            this.alertGrass.AutoSize = true;
            this.alertGrass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alertGrass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alertGrass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertGrass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alertGrass.ForeColor = System.Drawing.Color.Red;
            this.alertGrass.Location = new System.Drawing.Point(399, 19);
            this.alertGrass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alertGrass.Name = "alertGrass";
            this.alertGrass.Size = new System.Drawing.Size(565, 38);
            this.alertGrass.TabIndex = 8;
            this.alertGrass.Text = "NIE WOLNO JEŹDZIĆ PO TRAWNIKU";
            this.alertGrass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alertGrass.Visible = false;
            // 
            // wrongSignLabel
            // 
            this.wrongSignLabel.AutoSize = true;
            this.wrongSignLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wrongSignLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wrongSignLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrongSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wrongSignLabel.ForeColor = System.Drawing.Color.Red;
            this.wrongSignLabel.Location = new System.Drawing.Point(403, 62);
            this.wrongSignLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongSignLabel.Name = "wrongSignLabel";
            this.wrongSignLabel.Size = new System.Drawing.Size(557, 38);
            this.wrongSignLabel.TabIndex = 9;
            this.wrongSignLabel.Text = "NIE WOLNO JECHAĆ W TĘ STRONĘ";
            this.wrongSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wrongSignLabel.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.wrongSignLabel);
            this.Controls.Add(this.alertGrass);
            this.Controls.Add(this.escMenu);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.moneyLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Game";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.Text = "Need For Speed Not Wanted";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zasadyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MoneyTimer;
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Timer EnemySpeedTimer;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox startBox;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox optionBox;
        private System.Windows.Forms.PictureBox zasadyBox;
        private System.Windows.Forms.Label escMenu;
        private System.Windows.Forms.Label alertGrass;
        private System.Windows.Forms.Label wrongSignLabel;
    }
}

