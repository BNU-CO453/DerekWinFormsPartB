namespace DerekWindowsFormsApp
{
    partial class DataEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.messageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.townLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(378, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Details Entry Form";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(84, 125);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(119, 26);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(254, 125);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.Text = "Derek";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(254, 179);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(261, 32);
            this.lastNameTextBox.TabIndex = 4;
            this.lastNameTextBox.Text = "Peacock";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(84, 179);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(118, 26);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(54, 423);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(130, 49);
            this.messageButton.TabIndex = 6;
            this.messageButton.Text = "Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.showMessage);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 423);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 49);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearMessage);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(598, 438);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 44);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeForm);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Yellow;
            this.messageLabel.Location = new System.Drawing.Point(200, 288);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(100, 26);
            this.messageLabel.TabIndex = 9;
            this.messageLabel.Text = "Message";
            // 
            // townTextBox
            // 
            this.townTextBox.Location = new System.Drawing.Point(254, 232);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(261, 32);
            this.townTextBox.TabIndex = 11;
            this.townTextBox.Text = "Abbots Langley";
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(84, 232);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(64, 26);
            this.townLabel.TabIndex = 10;
            this.townLabel.Text = "Town";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(382, 423);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(130, 49);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeMessage);
            // 
            // U1_DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(724, 494);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "U1_DataEntryForm";
            this.Text = "Derek\'s Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox townTextBox;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Button changeButton;
    }
}