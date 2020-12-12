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
        public int Value { get; set; }

        public GameField()
        {
            Value = 0;
            IsClicked = false;
            BackColor = Color.White;
            Height = 50;
            Width = Height;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            SetStyle(ControlStyles.Selectable, false);
            MouseDown += GameField_MouseDown;
        }

        private void GameField_MouseDown(object sender, MouseEventArgs e)
        {
            if (BackColor == Color.Red)
            {
                IsClicked = true;
                Value = 1;
            }
            else
            {
                Form.ActiveForm.Hide();
                MessageBox.Show("Játék vége. Próbálja meg újra!");
            }
        }
    }
}
