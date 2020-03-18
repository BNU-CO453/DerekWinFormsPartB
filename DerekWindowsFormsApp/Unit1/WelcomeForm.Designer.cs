namespace DerekWindowsFormsApp
{
    partial class WelcomeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.bragLabel = new System.Windows.Forms.Label();
            this.computerButton = new System.Windows.Forms.Button();
            this.softwareButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.titleLabel.Location = new System.Drawing.Point(105, 75);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(370, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Welcome to SuperSoft";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bragLabel
            // 
            this.bragLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bragLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bragLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.bragLabel.Location = new System.Drawing.Point(142, 164);
            this.bragLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bragLabel.Name = "bragLabel";
            this.bragLabel.Size = new System.Drawing.Size(310, 70);
            this.bragLabel.TabIndex = 1;
            this.bragLabel.Text = "The Best Prices";
            this.bragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerButton
            // 
            this.computerButton.Location = new System.Drawing.Point(148, 366);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(126, 63);
            this.computerButton.TabIndex = 2;
            this.computerButton.Text = "Best Computer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.Click += new System.EventHandler(this.ShowBestComputer);
            // 
            // softwareButton
            // 
            this.softwareButton.Location = new System.Drawing.Point(315, 366);
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.Size = new System.Drawing.Size(137, 63);
            this.softwareButton.TabIndex = 3;
            this.softwareButton.Text = "Best Software";
            this.softwareButton.UseVisualStyleBackColor = true;
            this.softwareButton.Click += new System.EventHandler(this.showBestSoftware);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(500, 420);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(112, 51);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.exitForm);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(636, 483);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.softwareButton);
            this.Controls.Add(this.computerButton);
            this.Controls.Add(this.bragLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Derek Task 1.1 to 1.3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bragLabel;
        private System.Windows.Forms.Button computerButton;
        private System.Windows.Forms.Button softwareButton;
        private System.Windows.Forms.Button quitButton;
    }
}

