using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Beadando
{
    class GameField : Button
    {
        public bool IsClicked { get; set; }
        private int __value;

        public int Value
        {
            get { return __value; }
            set
            {
                __value = value;
                if (IsClicked == true && BackColor == Color.Red)
                {
                    __value++;
                }

            }
        }

        public GameField()
        {
            IsClicked = false;
            BackColor = Color.White;
            Height = 50;
            Width = Height;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SetStyle(ControlStyles.Selectable, false);
            MouseDown += GameField_MouseDown;
        }

        private void GameField_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsClicked == false)
            {
                IsClicked = true;
            }
        }
    }
}
