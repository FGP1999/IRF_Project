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
            this.NevTextBox = new System.Windows.Forms.TextBox();
            this.IntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitSajatButton = new IRF_Beadando.SajatButton();
            this.StartSajatButton = new IRF_Beadando.SajatButton();
            this.sajatLabel3 = new IRF_Beadando.SajatLabel();
            this.sajatLabel2 = new IRF_Beadando.SajatLabel();
            this.sajatLabel1 = new IRF_Beadando.SajatLabel();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NevTextBox
            // 
            this.NevTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NevTextBox.Location = new System.Drawing.Point(19, 170);
            this.NevTextBox.MaxLength = 20;
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(149, 26);
            this.NevTextBox.TabIndex = 1;
            // 
            // IntervalNumericUpDown
            // 
            this.IntervalNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IntervalNumericUpDown.Location = new System.Drawing.Point(19, 240);
            this.IntervalNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Name = "IntervalNumericUpDown";
            this.IntervalNumericUpDown.Size = new System.Drawing.Size(149, 26);
            this.IntervalNumericUpDown.TabIndex = 4;
            this.IntervalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SizeNumericUpDown.Location = new System.Drawing.Point(19, 310);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SizeNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(149, 26);
            this.SizeNumericUpDown.TabIndex = 5;
            this.SizeNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(175, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Üdvözöljük!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Állítsa be a játék paramétereit, majd nyomjon a Start gombra.";
            // 
            // ExitSajatButton
            // 
            this.ExitSajatButton.AutoSize = true;
            this.ExitSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSajatButton.FlatAppearance.BorderSize = 0;
            this.ExitSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ExitSajatButton.Location = new System.Drawing.Point(274, 259);
            this.ExitSajatButton.Name = "ExitSajatButton";
            this.ExitSajatButton.Size = new System.Drawing.Size(150, 50);
            this.ExitSajatButton.TabIndex = 14;
            this.ExitSajatButton.Text = "Kilépés a programból";
            this.ExitSajatButton.UseVisualStyleBackColor = false;
            this.ExitSajatButton.Click += new System.EventHandler(this.ExitSajatButton_Click);
            // 
            // StartSajatButton
            // 
            this.StartSajatButton.AutoSize = true;
            this.StartSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.StartSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartSajatButton.FlatAppearance.BorderSize = 0;
            this.StartSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.StartSajatButton.Location = new System.Drawing.Point(274, 189);
            this.StartSajatButton.Name = "StartSajatButton";
            this.StartSajatButton.Size = new System.Drawing.Size(150, 50);
            this.StartSajatButton.TabIndex = 13;
            this.StartSajatButton.Text = "Start";
            this.StartSajatButton.UseVisualStyleBackColor = false;
            this.StartSajatButton.Click += new System.EventHandler(this.StartSajatButton_Click);
            // 
            // sajatLabel3
            // 
            this.sajatLabel3.AutoSize = true;
            this.sajatLabel3.BackColor = System.Drawing.Color.OliveDrab;
            this.sajatLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.sajatLabel3.Location = new System.Drawing.Point(19, 290);
            this.sajatLabel3.Name = "sajatLabel3";
            this.sajatLabel3.Size = new System.Drawing.Size(162, 19);
            this.sajatLabel3.TabIndex = 12;
            this.sajatLabel3.Text = "Játéktábla mérete (4-10):";
            this.sajatLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sajatLabel2
            // 
            this.sajatLabel2.AutoSize = true;
            this.sajatLabel2.BackColor = System.Drawing.Color.OliveDrab;
            this.sajatLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.sajatLabel2.Location = new System.Drawing.Point(15, 220);
            this.sajatLabel2.Name = "sajatLabel2";
            this.sajatLabel2.Size = new System.Drawing.Size(153, 19);
            this.sajatLabel2.TabIndex = 11;
            this.sajatLabel2.Text = "Játék sebessége (1-10):";
            this.sajatLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sajatLabel1
            // 
            this.sajatLabel1.AutoSize = true;
            this.sajatLabel1.BackColor = System.Drawing.Color.OliveDrab;
            this.sajatLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.sajatLabel1.Location = new System.Drawing.Point(15, 150);
            this.sajatLabel1.Name = "sajatLabel1";
            this.sajatLabel1.Size = new System.Drawing.Size(208, 19);
            this.sajatLabel1.TabIndex = 10;
            this.sajatLabel1.Text = "Játékos neve (max. 20 karakter):";
            this.sajatLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.ExitSajatButton);
            this.Controls.Add(this.StartSajatButton);
            this.Controls.Add(this.sajatLabel3);
            this.Controls.Add(this.sajatLabel2);
            this.Controls.Add(this.sajatLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SizeNumericUpDown);
            this.Controls.Add(this.IntervalNumericUpDown);
            this.Controls.Add(this.NevTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itt a piros, hol a piros?";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.NumericUpDown IntervalNumericUpDown;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SajatLabel sajatLabel1;
        private SajatLabel sajatLabel2;
        private SajatLabel sajatLabel3;
        private SajatButton StartSajatButton;
        private SajatButton ExitSajatButton;
    }
}

