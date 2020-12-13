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
            int sebesseg = Convert.ToInt32(IntervalNumericUpDown.Value);
            int interval = 0;
            interval = IntervallumEllenorzes(sebesseg, interval);
            string neve = NevTextBox.Text;
            int merete = Convert.ToInt32(SizeNumericUpDown.Value);
            if (NevTextBox.Text.Length == 0)
            {
                MessageBox.Show("Kérem töltsön ki minden adatot!");
                this.DialogResult = DialogResult.None;
                return;
            }
            Form2 f2 = new Form2(neve,sebesseg, interval, merete);
            f2.ShowDialog();
        }

        private static int IntervallumEllenorzes(int sebesseg, int interval)
        {
            if (sebesseg == 1)
            {
                interval = 1000;
            }
            else if (sebesseg == 2)
            {
                interval = 950;
            }
            else if (sebesseg == 3)
            {
                interval = 900;
            }
            else if (sebesseg == 4)
            {
                interval = 850;
            }
            else if (sebesseg == 5)
            {
                interval = 800;
            }
            else if (sebesseg == 6)
            {
                interval = 750;
            }
            else if (sebesseg == 7)
            {
                interval = 700;
            }
            else if (sebesseg == 8)
            {
                interval = 650;
            }
            else if (sebesseg == 9)
            {
                interval = 600;
            }
            else if (sebesseg == 10)
            {
                interval = 550;
            }

            return interval;
        }
    }
}
