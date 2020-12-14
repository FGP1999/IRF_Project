using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    class SajatLabel : Label
    {
        public SajatLabel()
        {
            BackColor = Color.OliveDrab;
            Font = new Font("Times New Roman",12);
            TextAlign = ContentAlignment.TopRight;
            AutoSize = true;
        }
    }
}
