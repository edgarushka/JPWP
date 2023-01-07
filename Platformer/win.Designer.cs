namespace Platformer
{
    partial class Win
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
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winLabel.Location = new System.Drawing.Point(65, 129);
            this.winLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(152, 55);
            this.winLabel.TabIndex = 1;
            this.winLabel.Text = "label2";
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.winLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Win";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YOU WON";
            this.Load += new System.EventHandler(this.win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label winLabel;
    }
}