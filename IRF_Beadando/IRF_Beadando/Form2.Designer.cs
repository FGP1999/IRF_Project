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
            this.NevLabel = new System.Windows.Forms.Label();
            this.IntervallumLabel = new System.Windows.Forms.Label();
            this.TablaMeretLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NevLabel
            // 
            this.NevLabel.AutoSize = true;
            this.NevLabel.Location = new System.Drawing.Point(84, 62);
            this.NevLabel.Name = "NevLabel";
            this.NevLabel.Size = new System.Drawing.Size(35, 13);
            this.NevLabel.TabIndex = 0;
            this.NevLabel.Text = "label1";
            // 
            // IntervallumLabel
            // 
            this.IntervallumLabel.AutoSize = true;
            this.IntervallumLabel.Location = new System.Drawing.Point(68, 132);
            this.IntervallumLabel.Name = "IntervallumLabel";
            this.IntervallumLabel.Size = new System.Drawing.Size(35, 13);
            this.IntervallumLabel.TabIndex = 1;
            this.IntervallumLabel.Text = "label2";
            // 
            // TablaMeretLabel
            // 
            this.TablaMeretLabel.AutoSize = true;
            this.TablaMeretLabel.Location = new System.Drawing.Point(67, 185);
            this.TablaMeretLabel.Name = "TablaMeretLabel";
            this.TablaMeretLabel.Size = new System.Drawing.Size(35, 13);
            this.TablaMeretLabel.TabIndex = 2;
            this.TablaMeretLabel.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablaMeretLabel);
            this.Controls.Add(this.IntervallumLabel);
            this.Controls.Add(this.NevLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NevLabel;
        private System.Windows.Forms.Label IntervallumLabel;
        private System.Windows.Forms.Label TablaMeretLabel;
    }
}