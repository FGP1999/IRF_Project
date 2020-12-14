using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_Beadando
{
    public partial class Form3 : Form
    {
        EredmenytablaEntities2 context = new EredmenytablaEntities2();
        List<Eredmeny> Eredmenyek = new List<Eredmeny>();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet; 
        public Form3(string felhasznalonev, int osszpont, int sebesseg, int tablaMeret)
        {
            InitializeComponent();
            Eredmeny eredm = new Eredmeny();
            eredm.Nev = felhasznalonev;
            eredm.Pont = osszpont;
            eredm.Sebesseg = sebesseg;
            eredm.TablaMeret = tablaMeret;
            context.Eredmenies.Add(eredm);
            context.SaveChanges();

            var Eredmeny = from x in context.Eredmenies orderby  x.Pont descending
                           select x;

            Eredmenyek = context.Eredmenies.ToList();

            dataGridView1.DataSource = Eredmeny.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Felhasználónév";
            dataGridView1.Columns[2].HeaderText = "Pontszám";
            dataGridView1.Columns[3].HeaderText = "Nehézségi szint";
            dataGridView1.Columns[4].HeaderText = "Táblaméret";

            SzerzettPontSajatLabel.Text = felhasznalonev + " nevű játékos pontszáma: " + osszpont.ToString();
        }

        private void MentesExcelSajatButton_Click(object sender, EventArgs e)
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                ExcelCreation();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        private void ExcelCreation()
        {
            string[] headers = new string[]
            {
                "Játékos neve",
                "Pontszám",
                "Nehézségi szint",
                "Táblaméret"
            };

            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }

            object[,] values = new object[Eredmenyek.Count, headers.Length];

            int counter = 0;
            foreach (Eredmeny item in Eredmenyek)
            {
                values[counter, 0] = item.Nev;
                values[counter, 1] = item.Pont;
                values[counter, 2] = item.Sebesseg;
                values[counter, 3] = item.TablaMeret;
                counter++;
                xlSheet.get_Range
                ( 
                    GetCell(2, 1),
                    GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
            }
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.OliveDrab;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range tableRange = xlSheet.get_Range(GetCell(1, 1), GetCell(Eredmenyek.Count + 1, headers.Length));
            tableRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void ExitSajatButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UjrakezdesSajatButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
