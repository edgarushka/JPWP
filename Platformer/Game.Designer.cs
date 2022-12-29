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
            this.money_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.zasady_box = new System.Windows.Forms.PictureBox();
            this.exit_box = new System.Windows.Forms.PictureBox();
            this.option_box = new System.Windows.Forms.PictureBox();
            this.start_box = new System.Windows.Forms.PictureBox();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zasady_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_box)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.moneyLoss);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.updMovement);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // money_label
            // 
            this.money_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.money_label.AutoSize = true;
            this.money_label.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.money_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.money_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.money_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money_label.ForeColor = System.Drawing.Color.Green;
            this.money_label.Location = new System.Drawing.Point(1099, 53);
            this.money_label.Name = "money_label";
            this.money_label.Size = new System.Drawing.Size(130, 44);
            this.money_label.TabIndex = 3;
            this.money_label.Text = "10000";
            this.money_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // menu_panel
            // 
            this.menu_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu_panel.BackColor = System.Drawing.Color.SeaShell;
            this.menu_panel.BackgroundImage = global::Platformer.Properties.Resources.menu;
            this.menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menu_panel.Controls.Add(this.zasady_box);
            this.menu_panel.Controls.Add(this.exit_box);
            this.menu_panel.Controls.Add(this.option_box);
            this.menu_panel.Controls.Add(this.start_box);
            this.menu_panel.Location = new System.Drawing.Point(440, 90);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(400, 500);
            this.menu_panel.TabIndex = 6;
            // 
            // zasady_box
            // 
            this.zasady_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zasady_box.Image = global::Platformer.Properties.Resources.zasady_normal;
            this.zasady_box.Location = new System.Drawing.Point(127, 174);
            this.zasady_box.Name = "zasady_box";
            this.zasady_box.Size = new System.Drawing.Size(150, 64);
            this.zasady_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zasady_box.TabIndex = 3;
            this.zasady_box.TabStop = false;
            this.zasady_box.Click += new System.EventHandler(this.zasady_box_Click);
            this.zasady_box.MouseLeave += new System.EventHandler(this.zasady_box_MouseLeave);
            this.zasady_box.MouseHover += new System.EventHandler(this.zasady_box_MouseHover);
            // 
            // exit_box
            // 
            this.exit_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_box.Image = global::Platformer.Properties.Resources.exit_normal;
            this.exit_box.Location = new System.Drawing.Point(127, 314);
            this.exit_box.Name = "exit_box";
            this.exit_box.Size = new System.Drawing.Size(150, 64);
            this.exit_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_box.TabIndex = 2;
            this.exit_box.TabStop = false;
            this.exit_box.Click += new System.EventHandler(this.exit_box_Click);
            this.exit_box.MouseLeave += new System.EventHandler(this.exit_box_MouseLeave);
            this.exit_box.MouseHover += new System.EventHandler(this.exit_box_MouseHover);
            // 
            // option_box
            // 
            this.option_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_box.Image = global::Platformer.Properties.Resources.option_normal;
            this.option_box.Location = new System.Drawing.Point(127, 244);
            this.option_box.Name = "option_box";
            this.option_box.Size = new System.Drawing.Size(150, 64);
            this.option_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.option_box.TabIndex = 1;
            this.option_box.TabStop = false;
            this.option_box.MouseLeave += new System.EventHandler(this.option_box_MouseLeave);
            this.option_box.MouseHover += new System.EventHandler(this.option_box_MouseHover);
            // 
            // start_box
            // 
            this.start_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_box.Image = global::Platformer.Properties.Resources.start_normal;
            this.start_box.Location = new System.Drawing.Point(127, 104);
            this.start_box.Name = "start_box";
            this.start_box.Size = new System.Drawing.Size(150, 64);
            this.start_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_box.TabIndex = 0;
            this.start_box.TabStop = false;
            this.start_box.Click += new System.EventHandler(this.start_box_Click);
            this.start_box.MouseLeave += new System.EventHandler(this.start_box_MouseLeave);
            this.start_box.MouseHover += new System.EventHandler(this.start_box_MouseHover);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.money_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "Need For Speed Not Wanted";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menu_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Label money_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.PictureBox start_box;
        private System.Windows.Forms.PictureBox exit_box;
        private System.Windows.Forms.PictureBox option_box;
        private System.Windows.Forms.PictureBox zasady_box;
    }
}

