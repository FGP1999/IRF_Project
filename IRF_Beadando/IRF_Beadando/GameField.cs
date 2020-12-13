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
        public int Value { get; set; }

        private bool _isClicked;

        public bool IsClicked
        {
            get { return _isClicked; }
            set
            {
                _isClicked = value;

                if (_isClicked == true)
                {
                    Enabled = false;
                }
                else
                {
                    Enabled = true;
                }
            }
        }


        public GameField()
        {
            IsClicked = false;
            Value = 0;
            BackColor = Color.White;
            Height = 50;
            Width = Height;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SetStyle(ControlStyles.Selectable, false);
            MouseDown += GameField_MouseDown;
        }

        private void GameField_MouseDown(object sender, MouseEventArgs e)
        {
            IsClicked = true;
            if (BackColor == Color.Red)
            {
                Value++;
            }
        }
    }
}
