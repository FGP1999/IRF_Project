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
            string nev = NevTextBox.Text;
            int intervallum = int.Parse(IntervallumTextBox.Text);
            int tablaMeret = int.Parse(TablameretTextBox.Text);
            Form2 f2 = new Form2(nev, intervallum, tablaMeret);
            f2.ShowDialog();

        }
    }
}
