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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.zasady_box = new System.Windows.Forms.PictureBox();
            this.exit_box = new System.Windows.Forms.PictureBox();
            this.option_box = new System.Windows.Forms.PictureBox();
            this.start_box = new System.Windows.Forms.PictureBox();
            this.EscMenu = new System.Windows.Forms.Label();
            this.AlertGrass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zasady_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_box)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.MoneyLoss);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.UpdateMovement);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.moneyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.ForeColor = System.Drawing.Color.Green;
            this.moneyLabel.Location = new System.Drawing.Point(824, 43);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(107, 38);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "10000";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.BackColor = System.Drawing.Color.SeaShell;
            this.menuPanel.BackgroundImage = global::Platformer.Properties.Resources.menu;
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.zasady_box);
            this.menuPanel.Controls.Add(this.exit_box);
            this.menuPanel.Controls.Add(this.option_box);
            this.menuPanel.Controls.Add(this.start_box);
            this.menuPanel.Location = new System.Drawing.Point(330, 73);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 407);
            this.menuPanel.TabIndex = 6;
            // 
            // zasady_box
            // 
            this.zasady_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zasady_box.Image = global::Platformer.Properties.Resources.zasady_normal;
            this.zasady_box.Location = new System.Drawing.Point(95, 141);
            this.zasady_box.Margin = new System.Windows.Forms.Padding(2);
            this.zasady_box.Name = "zasady_box";
            this.zasady_box.Size = new System.Drawing.Size(112, 52);
            this.zasady_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zasady_box.TabIndex = 3;
            this.zasady_box.TabStop = false;
            this.zasady_box.Click += new System.EventHandler(Buttons.ZasadyBoxClick);
            this.zasady_box.MouseLeave += new System.EventHandler(Buttons.ZasadyBoxMouseLeave);
            this.zasady_box.MouseHover += new System.EventHandler(Buttons.ZasadyBoxMouseHover);
            // 
            // exit_box
            // 
            this.exit_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_box.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exit_box.Location = new System.Drawing.Point(95, 255);
            this.exit_box.Margin = new System.Windows.Forms.Padding(2);
            this.exit_box.Name = "exit_box";
            this.exit_box.Size = new System.Drawing.Size(112, 52);
            this.exit_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_box.TabIndex = 2;
            this.exit_box.TabStop = false;
            this.exit_box.Click += new System.EventHandler(Buttons.ExitBoxClick);
            this.exit_box.MouseLeave += new System.EventHandler(Buttons.ExitBoxMouseLeave);
            this.exit_box.MouseHover += new System.EventHandler(Buttons.ExitBoxMouseHover);
            // 
            // option_box
            // 
            this.option_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_box.Image = global::Platformer.Properties.Resources.option_normal;
            this.option_box.Location = new System.Drawing.Point(95, 198);
            this.option_box.Margin = new System.Windows.Forms.Padding(2);
            this.option_box.Name = "option_box";
            this.option_box.Size = new System.Drawing.Size(112, 52);
            this.option_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option_box.TabIndex = 1;
            this.option_box.TabStop = false;
            this.option_box.Click += new System.EventHandler(Buttons.OptionsBoxClick);
            this.option_box.MouseLeave += new System.EventHandler(Buttons.OptionBoxMouseLeave);
            this.option_box.MouseHover += new System.EventHandler(Buttons.OptionBoxMouseHover);

            // 
            // start_box
            // 
            this.start_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_box.Image = global::Platformer.Properties.Resources.start_normal;
            this.start_box.Location = new System.Drawing.Point(95, 84);
            this.start_box.Margin = new System.Windows.Forms.Padding(2);
            this.start_box.Name = "start_box";
            this.start_box.Size = new System.Drawing.Size(112, 52);
            this.start_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_box.TabIndex = 0;
            this.start_box.TabStop = false;
            this.start_box.Click += new System.EventHandler(this.StartBoxClick);
            this.start_box.MouseLeave += new System.EventHandler(Buttons.StartBoxMouseLeave);
            this.start_box.MouseHover += new System.EventHandler(Buttons.StartBoxMouseHover);
            // 
            // EscMenu
            // 
            this.EscMenu.AutoSize = true;
            this.EscMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EscMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EscMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EscMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EscMenu.ForeColor = System.Drawing.Color.Green;
            this.EscMenu.Location = new System.Drawing.Point(11, 43);
            this.EscMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EscMenu.Name = "EscMenu";
            this.EscMenu.Size = new System.Drawing.Size(203, 38);
            this.EscMenu.TabIndex = 7;
            this.EscMenu.Text = "ESC - MENU";
            this.EscMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EscMenu.Click += new System.EventHandler(this.label4_Click);
            // 
            // AlertGrass
            // 
            this.AlertGrass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AlertGrass.AutoSize = true;
            this.AlertGrass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AlertGrass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlertGrass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlertGrass.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlertGrass.ForeColor = System.Drawing.Color.Red;
            this.AlertGrass.Location = new System.Drawing.Point(237, 9);
            this.AlertGrass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AlertGrass.Name = "AlertGrass";
            this.AlertGrass.Size = new System.Drawing.Size(565, 38);
            this.AlertGrass.TabIndex = 8;
            this.AlertGrass.Text = "NIE WOLNO JEŹDZIĆ PO TRAWNIKU";
            this.AlertGrass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AlertGrass.Visible = false;
            this.AlertGrass.Click += new System.EventHandler(this.AlertGrass_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AlertGrass);
            this.Controls.Add(this.EscMenu);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.Text = "Need For Speed Not Wanted";
            this.Load += new System.EventHandler(this.GameLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zasady_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.PictureBox start_box;
        private System.Windows.Forms.PictureBox exit_box;
        private System.Windows.Forms.PictureBox option_box;
        private System.Windows.Forms.PictureBox zasady_box;
        private System.Windows.Forms.Label EscMenu;
        private System.Windows.Forms.Label AlertGrass;
        private System.Windows.Forms.Label label4;
    }
}

