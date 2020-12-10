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
    public partial class Form2 : Form
    {
        public Form2(string nev, int inter, int meret)
        {
            InitializeComponent();
            label1.Text = nev;
            label2.Text = inter.ToString();
            label3.Text = meret.ToString();
        }
    }
}
