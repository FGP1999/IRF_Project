﻿namespace IRF_Beadando
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
            this.IntervallumTextBox = new System.Windows.Forms.TextBox();
            this.TablameretTextBox = new System.Windows.Forms.TextBox();
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
            this.NevTextBox.Name = "NevTextBox";
            this.NevTextBox.Size = new System.Drawing.Size(100, 20);
            this.NevTextBox.TabIndex = 1;
            // 
            // IntervallumTextBox
            // 
            this.IntervallumTextBox.Location = new System.Drawing.Point(129, 158);
            this.IntervallumTextBox.Name = "IntervallumTextBox";
            this.IntervallumTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntervallumTextBox.TabIndex = 2;
            // 
            // TablameretTextBox
            // 
            this.TablameretTextBox.Location = new System.Drawing.Point(129, 220);
            this.TablameretTextBox.Name = "TablameretTextBox";
            this.TablameretTextBox.Size = new System.Drawing.Size(100, 20);
            this.TablameretTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablameretTextBox);
            this.Controls.Add(this.IntervallumTextBox);
            this.Controls.Add(this.NevTextBox);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox NevTextBox;
        private System.Windows.Forms.TextBox IntervallumTextBox;
        private System.Windows.Forms.TextBox TablameretTextBox;
    }
}

