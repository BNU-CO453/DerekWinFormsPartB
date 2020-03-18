namespace DerekWindowsFormsApp.Unit3
{
    partial class CurrencyForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rupeesRadioButton = new System.Windows.Forms.RadioButton();
            this.eurosRadioButton = new System.Windows.Forms.RadioButton();
            this.dollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.poundsTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derek\'s Currency Converter";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 10);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rupeesRadioButton);
            this.panel1.Controls.Add(this.eurosRadioButton);
            this.panel1.Controls.Add(this.dollarsRadioButton);
            this.panel1.Location = new System.Drawing.Point(508, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 218);
            this.panel1.TabIndex = 2;
            // 
            // rupeesRadioButton
            // 
            this.rupeesRadioButton.AutoSize = true;
            this.rupeesRadioButton.Location = new System.Drawing.Point(37, 148);
            this.rupeesRadioButton.Name = "rupeesRadioButton";
            this.rupeesRadioButton.Size = new System.Drawing.Size(105, 30);
            this.rupeesRadioButton.TabIndex = 2;
            this.rupeesRadioButton.Text = "Rupees";
            this.rupeesRadioButton.UseVisualStyleBackColor = true;
            this.rupeesRadioButton.CheckedChanged += new System.EventHandler(this.calculateRupees);
            // 
            // eurosRadioButton
            // 
            this.eurosRadioButton.AutoSize = true;
            this.eurosRadioButton.Location = new System.Drawing.Point(37, 89);
            this.eurosRadioButton.Name = "eurosRadioButton";
            this.eurosRadioButton.Size = new System.Drawing.Size(87, 30);
            this.eurosRadioButton.TabIndex = 1;
            this.eurosRadioButton.Text = "Euros";
            this.eurosRadioButton.UseVisualStyleBackColor = true;
            this.eurosRadioButton.CheckedChanged += new System.EventHandler(this.calculateEuros);
            // 
            // dollarsRadioButton
            // 
            this.dollarsRadioButton.AutoSize = true;
            this.dollarsRadioButton.Location = new System.Drawing.Point(37, 20);
            this.dollarsRadioButton.Name = "dollarsRadioButton";
            this.dollarsRadioButton.Size = new System.Drawing.Size(98, 30);
            this.dollarsRadioButton.TabIndex = 0;
            this.dollarsRadioButton.Text = "Dollars";
            this.dollarsRadioButton.UseVisualStyleBackColor = true;
            this.dollarsRadioButton.CheckedChanged += new System.EventHandler(this.calculateDollars);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "UK Pounds (£)";
            // 
            // poundsTextBox
            // 
            this.poundsTextBox.Location = new System.Drawing.Point(238, 157);
            this.poundsTextBox.Name = "poundsTextBox";
            this.poundsTextBox.Size = new System.Drawing.Size(122, 32);
            this.poundsTextBox.TabIndex = 4;
            this.poundsTextBox.Text = "100.00";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.amountTextBox.Enabled = false;
            this.amountTextBox.Location = new System.Drawing.Point(238, 217);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(122, 32);
            this.amountTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(545, 293);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(135, 48);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeForm);
            // 
            // CurrencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(720, 372);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.poundsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrencyForm";
            this.Text = "Derek\'s Currency Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rupeesRadioButton;
        private System.Windows.Forms.RadioButton eurosRadioButton;
        private System.Windows.Forms.RadioButton dollarsRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poundsTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
    }
}