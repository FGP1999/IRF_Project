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
        public Form2(string nev, int inter, int meret)
        {
            InitializeComponent();
            CreatePlayField();
            NevLabel.Text = nev;
            IntervallumLabel.Text = inter.ToString();
            TablaMeretLabel.Text = meret.ToString();

            t.Enabled = true;
            t.Interval = inter;
            t.Start();
            t.Tick += T_Tick; ;
        }
        private void CreatePlayField()
        {
            for (int row = 0; row <  10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    GameField gf = new GameField();
                    gf.Left = col * gf.Width + (int)(Math.Floor((double)(col / 10))) + ClientSize.Width / 10;
                    gf.Top = row * gf.Height + (int)(Math.Floor((double)(row / 10))) + 20;
                    FieldElements.Add(gf);
                    Controls.Add(gf);
                }
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            int pirosHelye = rnd.Next(0, 101);

            for (int i = 0; i < FieldElements.Count; i++)
            {
                FieldElements[i].BackColor = Color.White;
                if (i == pirosHelye)
                {
                    FieldElements[pirosHelye].BackColor = Color.Red;
                }
            }
        }
    }
}
