﻿namespace IRF_Beadando
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
            this.NevSajatLabel = new IRF_Beadando.SajatLabel();
            this.PontSajatLabel = new IRF_Beadando.SajatLabel();
            this.IntervalSajatLabel = new IRF_Beadando.SajatLabel();
            this.SuspendLayout();
            // 
            // NevSajatLabel
            // 
            this.NevSajatLabel.AutoSize = true;
            this.NevSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.NevSajatLabel.Location = new System.Drawing.Point(12, 9);
            this.NevSajatLabel.Name = "NevSajatLabel";
            this.NevSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.NevSajatLabel.TabIndex = 0;
            this.NevSajatLabel.Text = "sajatLabel1";
            // 
            // PontSajatLabel
            // 
            this.PontSajatLabel.AutoSize = true;
            this.PontSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.PontSajatLabel.Location = new System.Drawing.Point(13, 53);
            this.PontSajatLabel.Name = "PontSajatLabel";
            this.PontSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.PontSajatLabel.TabIndex = 1;
            this.PontSajatLabel.Text = "sajatLabel2";
            // 
            // IntervalSajatLabel
            // 
            this.IntervalSajatLabel.AutoSize = true;
            this.IntervalSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.IntervalSajatLabel.Location = new System.Drawing.Point(13, 99);
            this.IntervalSajatLabel.Name = "IntervalSajatLabel";
            this.IntervalSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.IntervalSajatLabel.TabIndex = 2;
            this.IntervalSajatLabel.Text = "sajatLabel3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IntervalSajatLabel);
            this.Controls.Add(this.PontSajatLabel);
            this.Controls.Add(this.NevSajatLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SajatLabel NevSajatLabel;
        private SajatLabel PontSajatLabel;
        private SajatLabel IntervalSajatLabel;
    }
}