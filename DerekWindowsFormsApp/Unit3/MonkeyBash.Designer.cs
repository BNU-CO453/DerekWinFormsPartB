namespace DerekWindowsFormsApp.Unit3
{
    partial class MonkeyBash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyBash));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.Location = new System.Drawing.Point(250, 418);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 41);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startTimer);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(413, 418);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(117, 41);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopTimer);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeButton.Location = new System.Drawing.Point(568, 418);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(117, 41);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeForm);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            this.animationTimer.Tick += new System.EventHandler(this.moveMonkey);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.Image")));
            this.imagePictureBox.Location = new System.Drawing.Point(113, 82);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(100, 100);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 3;
            this.imagePictureBox.TabStop = false;
            this.imagePictureBox.Click += new System.EventHandler(this.imagePictureBox_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(601, 26);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(54, 26);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "(x,y)";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(12, 426);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(198, 26);
            this.hitsLabel.TabIndex = 5;
            this.hitsLabel.Text = "Hits = 0 Misses = 0";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.imagePictureBox);
            this.gamePanel.Location = new System.Drawing.Point(17, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(668, 391);
            this.gamePanel.TabIndex = 6;
            this.gamePanel.Click += new System.EventHandler(this.gamePanel_Click);
            // 
            // MonkeyBash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 471);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MonkeyBash";
            this.Text = "Derek\'s Monkey Bash";
            this.Click += new System.EventHandler(this.MonkeyBash_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyBash_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Panel gamePanel;
    }
}