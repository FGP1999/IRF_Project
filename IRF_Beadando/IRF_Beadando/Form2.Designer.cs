namespace IRF_Beadando
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JatekVegeSajatButton = new IRF_Beadando.SajatButton();
            this.PontSajatLabel = new IRF_Beadando.SajatLabel();
            this.SebessegSajatLabel = new IRF_Beadando.SajatLabel();
            this.NevSajatLabel = new IRF_Beadando.SajatLabel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(222, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 3;
            // 
            // JatekVegeSajatButton
            // 
            this.JatekVegeSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.JatekVegeSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JatekVegeSajatButton.FlatAppearance.BorderSize = 0;
            this.JatekVegeSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JatekVegeSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.JatekVegeSajatButton.Location = new System.Drawing.Point(41, 200);
            this.JatekVegeSajatButton.Name = "JatekVegeSajatButton";
            this.JatekVegeSajatButton.Size = new System.Drawing.Size(120, 30);
            this.JatekVegeSajatButton.TabIndex = 12;
            this.JatekVegeSajatButton.Text = "Játék vége";
            this.JatekVegeSajatButton.UseVisualStyleBackColor = false;
            this.JatekVegeSajatButton.Click += new System.EventHandler(this.JatekVegeSajatButton_Click);
            // 
            // PontSajatLabel
            // 
            this.PontSajatLabel.AutoSize = true;
            this.PontSajatLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.PontSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PontSajatLabel.Location = new System.Drawing.Point(13, 112);
            this.PontSajatLabel.Name = "PontSajatLabel";
            this.PontSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.PontSajatLabel.TabIndex = 11;
            this.PontSajatLabel.Text = "sajatLabel3";
            this.PontSajatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SebessegSajatLabel
            // 
            this.SebessegSajatLabel.AutoSize = true;
            this.SebessegSajatLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.SebessegSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SebessegSajatLabel.Location = new System.Drawing.Point(13, 62);
            this.SebessegSajatLabel.Name = "SebessegSajatLabel";
            this.SebessegSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.SebessegSajatLabel.TabIndex = 10;
            this.SebessegSajatLabel.Text = "sajatLabel2";
            this.SebessegSajatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NevSajatLabel
            // 
            this.NevSajatLabel.AutoSize = true;
            this.NevSajatLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.NevSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NevSajatLabel.Location = new System.Drawing.Point(13, 12);
            this.NevSajatLabel.Name = "NevSajatLabel";
            this.NevSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.NevSajatLabel.TabIndex = 9;
            this.NevSajatLabel.Text = "sajatLabel1";
            this.NevSajatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(734, 524);
            this.ControlBox = false;
            this.Controls.Add(this.JatekVegeSajatButton);
            this.Controls.Add(this.PontSajatLabel);
            this.Controls.Add(this.SebessegSajatLabel);
            this.Controls.Add(this.NevSajatLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 563);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itt a piros, hol a piros?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private SajatLabel NevSajatLabel;
        private SajatLabel SebessegSajatLabel;
        private SajatLabel PontSajatLabel;
        private SajatButton JatekVegeSajatButton;
    }
}