﻿using System;
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
            osszmezo = meret;
            t.Enabled = true;
            t.Interval = inter;
            t.Start();
            t.Tick += T_Tick;

            
            PontSajatLabel.Text = "Pont: " + osszpont.ToString();
        }
        private void CreatePlayField(int tablaMeret)
        {
            for (int row = 0; row <  tablaMeret; row++)
            {
                for (int col = 0; col < tablaMeret; col++)
                {
                    GameField gf = new GameField();
                    gf.Left = col * gf.Width + (int)(Math.Floor((double)(col / tablaMeret))) + ClientSize.Width / tablaMeret;
                    gf.Top = row * gf.Height + (int)(Math.Floor((double)(row / tablaMeret))) + 20;
                    FieldElements.Add(gf);
                    Controls.Add(gf);

                }
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
                    FieldElements[pirosHelye].BackColor = Color.Red;
                }
                else
                {
                    FieldElements[i].IsClicked = false;
                    FieldElements[i].BackColor = Color.White;
                }
                osszpont = osszpont + FieldElements[i].Value;
            }
        }
    }
}
