namespace DerekWindowsFormsApp.Unit4
{
    partial class TipsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipsterForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.peopleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.generousRadioButton = new System.Windows.Forms.RadioButton();
            this.madRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill (£)";
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(151, 46);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(100, 32);
            this.billTextBox.TabIndex = 2;
            this.billTextBox.Text = "120.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "People";
            // 
            // peopleNumericUpDown
            // 
            this.peopleNumericUpDown.Location = new System.Drawing.Point(151, 125);
            this.peopleNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.peopleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.peopleNumericUpDown.Name = "peopleNumericUpDown";
            this.peopleNumericUpDown.Size = new System.Drawing.Size(100, 32);
            this.peopleNumericUpDown.TabIndex = 4;
            this.peopleNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(525, 392);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(111, 41);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitApplication);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(358, 392);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(136, 41);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateBill);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.madRadioButton);
            this.groupBox1.Controls.Add(this.generousRadioButton);
            this.groupBox1.Controls.Add(this.normalRadioButton);
            this.groupBox1.Controls.Add(this.noneRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(39, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(19, 32);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(82, 30);
            this.noneRadioButton.TabIndex = 0;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = true;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Location = new System.Drawing.Point(155, 31);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(74, 30);
            this.normalRadioButton.TabIndex = 1;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "10%";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            // 
            // generousRadioButton
            // 
            this.generousRadioButton.AutoSize = true;
            this.generousRadioButton.Location = new System.Drawing.Point(19, 82);
            this.generousRadioButton.Name = "generousRadioButton";
            this.generousRadioButton.Size = new System.Drawing.Size(74, 30);
            this.generousRadioButton.TabIndex = 2;
            this.generousRadioButton.Text = "20%";
            this.generousRadioButton.UseVisualStyleBackColor = true;
            // 
            // madRadioButton
            // 
            this.madRadioButton.AutoSize = true;
            this.madRadioButton.Location = new System.Drawing.Point(155, 82);
            this.madRadioButton.Name = "madRadioButton";
            this.madRadioButton.Size = new System.Drawing.Size(72, 30);
            this.madRadioButton.TabIndex = 3;
            this.madRadioButton.Text = "Mad";
            this.madRadioButton.UseVisualStyleBackColor = true;
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.peopleNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TipsterForm";
            this.Text = "Derek\'s Tipster Bill Entry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown peopleNumericUpDown;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton madRadioButton;
        private System.Windows.Forms.RadioButton generousRadioButton;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton noneRadioButton;
    }
}