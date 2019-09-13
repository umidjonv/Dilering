using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
namespace Classes
{
    class ExcelClass
    {
        Application _excelApp;

        /// <summary>
        /// Initialize a new Excel reader. Must be integrated
        /// with an Excel interface object.
        /// </summary>
        public ExcelClass()
        {
            savepath = System.Windows.Forms.Application.StartupPath + "\\";
            _excelApp = new Application();
        }

        public ExcelClass(string path)
        {
            savepath = path;
            _excelApp = new Application();
        }
        public string savepath;
        public Color backColor = Color.White;
        Workbook activeWorkbook;
        public Worksheet activeSheet;
        public void Create(string name)
        {
            string wname = name;
            bool created = false;
            activeWorkbook = _excelApp.Workbooks.Add();
            //activeSheet = 
            if (activeWorkbook.Sheets.Count != 0)
            {
                activeSheet = activeWorkbook.Sheets[1];
            }
            else
            {
                activeWorkbook.Sheets.Add();
                activeSheet = activeWorkbook.Sheets[0];
            }
        }

        public void SetCell(string cell, string value, bool? isBold)
        {
            Range range = activeSheet.get_Range(cell);
            range.Interior.Color = System.Drawing.ColorTranslator.ToOle(backColor);
            SetBorder(cell);
            range.Value = value;
            if (isBold != null)
            {
                range.Font.Bold = isBold;
            }
        }
        public string GetCell(string cell)
        {
            Range range = activeSheet.get_Range(cell);
            if(range.Value!=null)
            return range.Value.ToString();
            else
                return "";
            
        }
        public void SetBorder(string cell)
        {
            Range range = activeSheet.get_Range(cell);
            BorderAround(range, 0);
        }

        public void BorderAround(Range range, int colour)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = colour;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
            borders = null;
        }
        public void Merging(string cell1, string cell2)
        {
            Range range = activeSheet.get_Range(cell1, cell2);
            range.Merge();
        }

        public void ColWidth(string col, int width)
        {
            activeSheet.Columns[col].ColumnWidth = width;

        }

        public void SetSize(string cell, bool center)
        {
            Range range = activeSheet.get_Range(cell);
            range.Font.Size = 14;
            //range.
 
        }

        public void Save()
        {
            activeWorkbook.SaveAs(savepath);
            activeWorkbook.Close();
            _excelApp.Quit();

        }
        public void SaveOnly()
        {
            activeWorkbook.SaveAs(savepath);
            
        }

        public string[] Find(string cell1, string cell2, string search)
        {
            Range range = activeSheet.get_Range(cell1, cell2);
            range = range.Find(search, Type.Missing,
                XlFindLookIn.xlValues, XlLookAt.xlPart,
                XlSearchOrder.xlByRows, XlSearchDirection.xlNext, false,
                Type.Missing, Type.Missing);
            if (range!=null && range.Value != null)
                return new string[] {GetExcelColumnName(range.Column)+""+range.Row, range.Value};
            else
                return null;
 
        }
        private string GetExcelColumnName(int columnNumber)
        {
            int dividend = columnNumber;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }
        public void Close()
        {
            activeWorkbook.Close();
            _excelApp.Quit();
        }
        public void Open(string filename)
        {
            Workbook workbook = _excelApp.Workbooks.Open(filename);
            activeWorkbook = workbook;
            activeSheet = workbook.ActiveSheet;
        }
        
    }
}
