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
        private bool _isClicked;

        public bool IsClicked
        {
            get { return _isClicked; }
            set
            {
                _isClicked = value;
                if (_isClicked == true)
                {
                    BackColor = Color.Yellow;
                }
                else if (_isClicked == false)
                {
                    BackColor = Color.White;
                }
            }
        }

        public GameField()
        {
            IsClicked = false;
            Height = 50;
            Width = Height;
            MouseDown += GameField_MouseDown;
        }

        private void GameField_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsClicked == false)
            {
                IsClicked = true;
            }
            else
            {
                IsClicked = false;
            }
        }
    }
}
