using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (NevTextBox.Text.Length == 0)
            {
                MessageBox.Show("Kérem töltsön ki minden adatot!");
                this.DialogResult = DialogResult.None;
                return;
            }
            string neve = NevTextBox.Text;
            int interval = Decimal.ToInt32(IntervalNumericUpDown.Value);
            int merete = Decimal.ToInt32(SizeNumericUpDown.Value);
            Form2 f2 = new Form2(neve, interval, merete);
            f2.ShowDialog();
        }

    }
}
