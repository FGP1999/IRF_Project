namespace IRF_Beadando
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExitSajatButton = new IRF_Beadando.SajatButton();
            this.UjrakezdesSajatButton = new IRF_Beadando.SajatButton();
            this.MentesExcelSajatButton = new IRF_Beadando.SajatButton();
            this.SzerzettPontSajatLabel = new IRF_Beadando.SajatLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 127);
            this.dataGridView1.TabIndex = 1;
            // 
            // ExitSajatButton
            // 
            this.ExitSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExitSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSajatButton.FlatAppearance.BorderSize = 0;
            this.ExitSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.ExitSajatButton.Location = new System.Drawing.Point(270, 413);
            this.ExitSajatButton.Name = "ExitSajatButton";
            this.ExitSajatButton.Size = new System.Drawing.Size(150, 30);
            this.ExitSajatButton.TabIndex = 9;
            this.ExitSajatButton.Text = "Kilépés";
            this.ExitSajatButton.UseVisualStyleBackColor = false;
            this.ExitSajatButton.Click += new System.EventHandler(this.ExitSajatButton_Click);
            // 
            // UjrakezdesSajatButton
            // 
            this.UjrakezdesSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.UjrakezdesSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UjrakezdesSajatButton.FlatAppearance.BorderSize = 0;
            this.UjrakezdesSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UjrakezdesSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.UjrakezdesSajatButton.Location = new System.Drawing.Point(60, 413);
            this.UjrakezdesSajatButton.Name = "UjrakezdesSajatButton";
            this.UjrakezdesSajatButton.Size = new System.Drawing.Size(150, 30);
            this.UjrakezdesSajatButton.TabIndex = 8;
            this.UjrakezdesSajatButton.Text = "Játék újrakezdése";
            this.UjrakezdesSajatButton.UseVisualStyleBackColor = false;
            this.UjrakezdesSajatButton.Click += new System.EventHandler(this.UjrakezdesSajatButton_Click);
            // 
            // MentesExcelSajatButton
            // 
            this.MentesExcelSajatButton.BackColor = System.Drawing.Color.Gainsboro;
            this.MentesExcelSajatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MentesExcelSajatButton.FlatAppearance.BorderSize = 0;
            this.MentesExcelSajatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MentesExcelSajatButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.MentesExcelSajatButton.Location = new System.Drawing.Point(175, 270);
            this.MentesExcelSajatButton.Name = "MentesExcelSajatButton";
            this.MentesExcelSajatButton.Size = new System.Drawing.Size(150, 50);
            this.MentesExcelSajatButton.TabIndex = 7;
            this.MentesExcelSajatButton.Text = "Eredménytábla mentése";
            this.MentesExcelSajatButton.UseVisualStyleBackColor = false;
            this.MentesExcelSajatButton.Click += new System.EventHandler(this.MentesExcelSajatButton_Click);
            // 
            // SzerzettPontSajatLabel
            // 
            this.SzerzettPontSajatLabel.AutoSize = true;
            this.SzerzettPontSajatLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.SzerzettPontSajatLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SzerzettPontSajatLabel.Location = new System.Drawing.Point(12, 185);
            this.SzerzettPontSajatLabel.Name = "SzerzettPontSajatLabel";
            this.SzerzettPontSajatLabel.Size = new System.Drawing.Size(79, 19);
            this.SzerzettPontSajatLabel.TabIndex = 5;
            this.SzerzettPontSajatLabel.Text = "sajatLabel1";
            this.SzerzettPontSajatLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Játékosok rangsora:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitSajatButton);
            this.Controls.Add(this.UjrakezdesSajatButton);
            this.Controls.Add(this.MentesExcelSajatButton);
            this.Controls.Add(this.SzerzettPontSajatLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itt a piros, hol a piros?";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private SajatLabel SzerzettPontSajatLabel;
        private SajatButton MentesExcelSajatButton;
        private SajatButton UjrakezdesSajatButton;
        private SajatButton ExitSajatButton;
        private System.Windows.Forms.Label label1;
    }
}