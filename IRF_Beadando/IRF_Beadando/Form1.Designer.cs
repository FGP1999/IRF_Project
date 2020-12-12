namespace IRF_Beadando
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
            this.StartButton = new System.Windows.Forms.Button();
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.IntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(333, 372);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NevTextBox
            // 
            this.NevTextBox.Location = new System.Drawing.Point(129, 107);
            this.NevTextBox.MaxLength = 50;
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(100, 20);
            this.NevTextBox.TabIndex = 1;
            // 
            // IntervalNumericUpDown
            // 
            this.IntervalNumericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Location = new System.Drawing.Point(129, 155);
            this.IntervalNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Name = "IntervalNumericUpDown";
            this.IntervalNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IntervalNumericUpDown.TabIndex = 4;
            this.IntervalNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.Location = new System.Drawing.Point(129, 209);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.SizeNumericUpDown.TabIndex = 5;
            this.SizeNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.IntervalNumericUpDown);
            this.Controls.Add(this.NevTextBox);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.NumericUpDown IntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
    }
}

