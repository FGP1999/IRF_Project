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
            this.SebessegSajatLabel = new IRF_Beadando.SajatLabel();
            this.PontSajatLabel = new IRF_Beadando.SajatLabel();
            this.NevSajatLabel = new IRF_Beadando.SajatLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(135, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 388);
            this.panel1.TabIndex = 3;
            // 
            // SebessegSajatLabel
            // 
            this.SebessegSajatLabel.AutoSize = true;
            this.SebessegSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SebessegSajatLabel.Location = new System.Drawing.Point(12, 51);
            this.SebessegSajatLabel.Name = "SebessegSajatLabel";
            this.SebessegSajatLabel.Size = new System.Drawing.Size(37, 19);
            this.SebessegSajatLabel.TabIndex = 2;
            this.SebessegSajatLabel.Text = "label";
            // 
            // PontSajatLabel
            // 
            this.PontSajatLabel.AutoSize = true;
            this.PontSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PontSajatLabel.Location = new System.Drawing.Point(12, 93);
            this.PontSajatLabel.Name = "PontSajatLabel";
            this.PontSajatLabel.Size = new System.Drawing.Size(0, 19);
            this.PontSajatLabel.TabIndex = 1;
            // 
            // NevSajatLabel
            // 
            this.NevSajatLabel.AutoSize = true;
            this.NevSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NevSajatLabel.Location = new System.Drawing.Point(12, 9);
            this.NevSajatLabel.Name = "NevSajatLabel";
            this.NevSajatLabel.Size = new System.Drawing.Size(37, 19);
            this.NevSajatLabel.TabIndex = 0;
            this.NevSajatLabel.Text = "label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SebessegSajatLabel);
            this.Controls.Add(this.PontSajatLabel);
            this.Controls.Add(this.NevSajatLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SajatLabel SebessegSajatLabel;
        private SajatLabel PontSajatLabel;
        private SajatLabel NevSajatLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}