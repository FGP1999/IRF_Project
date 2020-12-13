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
    public partial class Form3 : Form
    {
        EredmenytablaEntities context = new EredmenytablaEntities();
        public Form3(string felhasznalonev, int osszpont, int ido, int tablaMeret)
        {
            InitializeComponent();
            Eredmeny eredm = new Eredmeny();
            eredm.Nev = felhasznalonev;
            eredm.Pont = osszpont;
            eredm.IdoIntervallum = ido;
            eredm.TablaMeret = tablaMeret;
            context.Eredmenies.Add(eredm);
            context.SaveChanges();

            var Eredmenyek = from x in context.Eredmenies
                             select x;

            dataGridView1.DataSource = Eredmenyek.ToList();
        }
    }
}
