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
        EredmenytablaEntities context = new EredmenytablaEntities();
        List<GameField> FieldElements = new List<GameField>();
        Timer t = new Timer();
        Random rnd = new Random();
        int tablaMeret = 0;
        int osszpont = 0;
        int ido = 0;
        string felhasznalonev;
        public Form2(string nev, int inter, int meret)
        {
            InitializeComponent();
            CreatePlayField(meret);
            NevSajatLabel.Text = "Név: " + nev;
            IntervalSajatLabel.Text = "Intervallum: " + inter.ToString();
            PontSajatLabel.Text = osszpont.ToString() + " Pont";
            tablaMeret = meret;
            ido = inter;
            felhasznalonev = nev; 

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
            foreach (var item in panel1.Controls.OfType<GameField>())
            {
                osszpont = osszpont + item.Value;
                if (item.IsClicked == true && item.BackColor != Color.Red)
                {
                    ActiveForm.Close();
                    MessageBox.Show("Játék vége! Próbálja meg újra!");
                    Form3 f3 = new Form3(felhasznalonev, osszpont, ido, tablaMeret);
                    f3.ShowDialog();
                }
            }
            PontSajatLabel.Text = osszpont.ToString() + " Pont";
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int negyzet = tablaMeret * tablaMeret + 1;
            int pirosHelye = rnd.Next(0, negyzet);
            foreach (var item in panel1.Controls.OfType<GameField>())
            {
                item.Value = 0;
                item.IsClicked = false;
            }
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            Form3 f3 = new Form3(felhasznalonev, osszpont, ido, tablaMeret);
            f3.ShowDialog();
        }
    }
}
