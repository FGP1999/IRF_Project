using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    class SajatButton : Button
    {
        public SajatButton()
        {
            Cursor = Cursors.Hand;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.Gainsboro;
            Font = new Font("Times New Roman", 10,FontStyle.Bold);
            TextAlign = ContentAlignment.MiddleCenter;
            AutoSize = false;
        }
    }
}
