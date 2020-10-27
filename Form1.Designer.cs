namespace Simple_Calculator
{
    partial class Form1
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
            this.subtraction = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtraction
            // 
            this.subtraction.AccessibleDescription = "-";
            this.subtraction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(520, 328);
            this.subtraction.Margin = new System.Windows.Forms.Padding(4);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(76, 64);
            this.subtraction.TabIndex = 0;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = false;
            this.subtraction.Click += new System.EventHandler(this.PerformOperation);
            // 
            // division
            // 
            this.division.AccessibleDescription = "/";
            this.division.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.MenuText;
            this.division.Location = new System.Drawing.Point(520, 108);
            this.division.Margin = new System.Windows.Forms.Padding(4);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(76, 64);
            this.division.TabIndex = 2;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.PerformOperation);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(20, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 45);
            this.textBox1.TabIndex = 3;
            // 
            // addition
            // 
            this.addition.AccessibleDescription = "+";
            this.addition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.Location = new System.Drawing.Point(520, 254);
            this.addition.Margin = new System.Windows.Forms.Padding(4);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(76, 64);
            this.addition.TabIndex = 4;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.PerformOperation);
            // 
            // multiplication
            // 
            this.multiplication.AccessibleDescription = "*";
            this.multiplication.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(520, 181);
            this.multiplication.Margin = new System.Windows.Forms.Padding(4);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(76, 64);
            this.multiplication.TabIndex = 5;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.PerformOperation);
            // 
            // digit1
            // 
            this.digit1.AccessibleDescription = "1";
            this.digit1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit1.Location = new System.Drawing.Point(20, 109);
            this.digit1.Margin = new System.Windows.Forms.Padding(4);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(121, 62);
            this.digit1.TabIndex = 6;
            this.digit1.Tag = "";
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = false;
            this.digit1.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit2
            // 
            this.digit2.AccessibleDescription = "2";
            this.digit2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit2.Location = new System.Drawing.Point(185, 109);
            this.digit2.Margin = new System.Windows.Forms.Padding(4);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(121, 62);
            this.digit2.TabIndex = 7;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = false;
            this.digit2.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit3
            // 
            this.digit3.AccessibleDescription = "3";
            this.digit3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit3.Location = new System.Drawing.Point(351, 109);
            this.digit3.Margin = new System.Windows.Forms.Padding(4);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(121, 62);
            this.digit3.TabIndex = 8;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = false;
            this.digit3.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit4
            // 
            this.digit4.AccessibleDescription = "4";
            this.digit4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit4.Location = new System.Drawing.Point(20, 209);
            this.digit4.Margin = new System.Windows.Forms.Padding(4);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(121, 62);
            this.digit4.TabIndex = 9;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = false;
            this.digit4.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit5
            // 
            this.digit5.AccessibleDescription = "5";
            this.digit5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit5.Location = new System.Drawing.Point(185, 209);
            this.digit5.Margin = new System.Windows.Forms.Padding(4);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(121, 62);
            this.digit5.TabIndex = 10;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = false;
            this.digit5.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit6
            // 
            this.digit6.AccessibleDescription = "6";
            this.digit6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit6.Location = new System.Drawing.Point(351, 209);
            this.digit6.Margin = new System.Windows.Forms.Padding(4);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(121, 62);
            this.digit6.TabIndex = 11;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = false;
            this.digit6.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit7
            // 
            this.digit7.AccessibleDescription = "7";
            this.digit7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit7.Location = new System.Drawing.Point(20, 312);
            this.digit7.Margin = new System.Windows.Forms.Padding(4);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(121, 62);
            this.digit7.TabIndex = 12;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = false;
            this.digit7.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit8
            // 
            this.digit8.AccessibleDescription = "8";
            this.digit8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit8.Location = new System.Drawing.Point(185, 312);
            this.digit8.Margin = new System.Windows.Forms.Padding(4);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(121, 62);
            this.digit8.TabIndex = 13;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = false;
            this.digit8.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit9
            // 
            this.digit9.AccessibleDescription = "9";
            this.digit9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit9.Location = new System.Drawing.Point(351, 312);
            this.digit9.Margin = new System.Windows.Forms.Padding(4);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(121, 62);
            this.digit9.TabIndex = 14;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = false;
            this.digit9.Click += new System.EventHandler(this.InputNumber);
            // 
            // digit0
            // 
            this.digit0.AccessibleDescription = "0";
            this.digit0.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.digit0.Location = new System.Drawing.Point(185, 412);
            this.digit0.Margin = new System.Windows.Forms.Padding(4);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(121, 62);
            this.digit0.TabIndex = 15;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = false;
            this.digit0.Click += new System.EventHandler(this.InputNumber);
            // 
            // equals
            // 
            this.equals.AccessibleDescription = "Return";
            this.equals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(520, 402);
            this.equals.Margin = new System.Windows.Forms.Padding(4);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(76, 64);
            this.equals.TabIndex = 16;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.PerformOperation);
            // 
            // reset
            // 
            this.reset.AccessibleDescription = "c";
            this.reset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(41, 402);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(76, 64);
            this.reset.TabIndex = 17;
            this.reset.Text = "C";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.Reset);
            // 
            // decimalPoint
            // 
            this.decimalPoint.AccessibleDescription = ".";
            this.decimalPoint.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalPoint.Location = new System.Drawing.Point(371, 402);
            this.decimalPoint.Margin = new System.Windows.Forms.Padding(4);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(76, 64);
            this.decimalPoint.TabIndex = 18;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.InputNumber);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(601, 483);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.subtraction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Burbidge Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button digit1;
        private System.Windows.Forms.Button digit2;
        private System.Windows.Forms.Button digit3;
        private System.Windows.Forms.Button digit4;
        private System.Windows.Forms.Button digit5;
        private System.Windows.Forms.Button digit6;
        private System.Windows.Forms.Button digit7;
        private System.Windows.Forms.Button digit8;
        private System.Windows.Forms.Button digit9;
        private System.Windows.Forms.Button digit0;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button decimalPoint;
    }
}

