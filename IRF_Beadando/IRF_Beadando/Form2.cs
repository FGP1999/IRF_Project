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
        List<GameField> FieldElements = new List<GameField>();
        Timer t = new Timer();
        Random rnd = new Random();
        int osszmezo = 0;
        int osszpont = 0;
        public Form2(string nev, int inter, int meret)
        {
            InitializeComponent();
            CreatePlayField(meret);
            NevSajatLabel.Text = "Név: " + nev;
            IntervalSajatLabel.Text = "Intervallum: " + inter.ToString();
            PontSajatLabel.Text = osszpont.ToString() + " Pont";
            osszpont = 1;
            osszmezo = meret;
            t.Enabled = true;
            t.Interval = inter;
            t.Start();
            t.Tick += T_Tick;
        }
        private void CreatePlayField(int tablaMeret)
        {
            for (int row = 0; row <  tablaMeret; row++)
            {
                for (int col = 0; col < tablaMeret; col++)
                {
                    GameField gf = new GameField();
                    gf.MouseDown += Gf_MouseDown;
                    gf.Left = col * gf.Width + (int)(Math.Floor((double)(col / tablaMeret)));
                    gf.Top = row * gf.Height + (int)(Math.Floor((double)(row / tablaMeret)));
                    FieldElements.Add(gf);
                    panel1.Controls.Add(gf);
                }
            }
        }

        private void Gf_MouseDown(object sender, MouseEventArgs e)
        {
            PontSajatLabel.Text = osszpont.ToString() + " Pont";
            foreach (var item in panel1.Controls.OfType<GameField>())
            {
                osszpont = osszpont + item.Value;
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int negyzet = osszmezo * osszmezo + 1;
            int pirosHelye = rnd.Next(0, negyzet);
            for (int i = 0; i < FieldElements.Count; i++)
            {
                if (i == pirosHelye)
                {
                    FieldElements[i].BackColor = Color.Red;
                }
                else
                {
                    FieldElements[i].BackColor = Color.White;
                }
            }
            foreach (var item in panel1.Controls.OfType<GameField>())
            {
                item.Value = 0;
                item.IsClicked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
