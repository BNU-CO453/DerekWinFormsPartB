namespace DerekWindowsFormsApp.Game
{
    partial class GameUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.userPictureBox);
            this.groupBox1.Controls.Add(this.scissorsRadioButton);
            this.groupBox1.Controls.Add(this.paperRadioButton);
            this.groupBox1.Controls.Add(this.rockRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(43, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Choice";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.playButton);
            this.groupBox2.Controls.Add(this.computerPictureBox);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(300, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Choice";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.messageLabel);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(542, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 239);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Score";
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Location = new System.Drawing.Point(36, 257);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(80, 30);
            this.rockRadioButton.TabIndex = 0;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            this.rockRadioButton.CheckedChanged += new System.EventHandler(this.rockRadioButton_CheckedChanged);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(36, 293);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(88, 30);
            this.paperRadioButton.TabIndex = 1;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.paperRadioButton_CheckedChanged);
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(36, 329);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(113, 30);
            this.scissorsRadioButton.TabIndex = 2;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPictureBox.Location = new System.Drawing.Point(7, 42);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(201, 173);
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(7, 42);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(201, 173);
            this.computerPictureBox.TabIndex = 4;
            this.computerPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(778, 376);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 50);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(47, 257);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(116, 53);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(18, 42);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(153, 26);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "message label";
            // 
            // GameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 438);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GameUI";
            this.Text = "Derek\'s Rock-Paper-Scissors Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button closeButton;
    }
}