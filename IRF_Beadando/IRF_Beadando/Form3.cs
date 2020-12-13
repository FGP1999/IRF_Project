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
        public Form3()
        {
            InitializeComponent();

            var Eredmenyek = from x in context.Eredmenies
                             select x;

            dataGridView1.DataSource = Eredmenyek.ToList();
        }
    }
}
