using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows;

namespace WPF
{
    public class WorkExcel
    {
        private Excel.Application _application = null;
        private Excel.Workbook _workBook = null;
        private Excel.Worksheet _workSheet = null;
        private Excel.Range _range =null;
        private object _missingObj = Type.Missing;
        public void CreateExcel() {
            _application = new Excel.Application(); // Создаём экземпляр нашего приложения
            _application.Visible = false;
            _application.SheetsInNewWorkbook = 2; 
            _workBook = _application.Workbooks.Add(_missingObj); // Создаём экземпляр рабочий книги Excel
            _workSheet = (Excel.Worksheet) _workBook.Worksheets.get_Item(1); // Создаём экземпляр листа Excel
        }

        public void CreateExcel(string pathToTemplate) {
            object pathToTemplateObj = pathToTemplate;
            _application = new Excel.Application();
            _workBook = _application.Workbooks.Add(pathToTemplateObj);
            _workSheet = (Excel.Worksheet)_workBook.Worksheets.get_Item(1);
        }

        /// <summary>
        /// Заполняет текущий лист данными из источника
        /// </summary>
        /// <param name="source">Матрица строк</param>
        /// <param name="startColumn">Начальная позиция вставки - столбец</param>
        /// <param name="startRow">Начальная позиция вставки - строка</param>
        public void FillTable(string[,] source, int startRow, int startColumn) {
            for (int i = 0; i < source.GetLength(0); i++) {
                for (int j = 0; j < source.GetLength(1); j++) {
                    _workSheet.Cells[startRow + i, startColumn + j] = source[i, j];
                }
            }
        }

        /// <summary>
        /// ПОлучает матрицу значений из диапазона
        /// </summary>
        /// <param name="rFrom">НАчало диапазона - строка</param>
        /// <param name="cFrom">НАчало диапазона - столбец</param>
        /// <param name="rTo">Конец диапазона - строка</param>
        /// <param name="cTo">Конец диапазона - столбец</param>
        /// <returns></returns>
        public string[,] GetRange(int rFrom, int cFrom, int rTo, int cTo) {
            Excel.Range fromRange = _workSheet.Cells[rFrom, cFrom];
            Excel.Range toRange = _workSheet.Cells[rTo, cTo];
            Excel.Range _selectedRange = _workSheet.get_Range(fromRange, toRange);
            object[,] _objectValues = (object[,])_selectedRange.Value2;
            int _rows = _objectValues.GetLength(0);
            int _columns = _objectValues.GetLength(1);
            string[,] _stringValues = new string[_rows, _columns];
            for (int i = 0; i < _rows; i++) {
                for (int j = 0; j < _columns; j++) {
                    _stringValues[i, j] = Convert.ToString(_objectValues[i + 1, j + 1]);
                }
            }
            return _stringValues;
        }

        public bool Visible {
            get { return _application.Visible; }
            set { _application.Visible = value; }
        }

        public void InsertValue(string cellValue, int rowIndex, int columnIndex) {
            _workSheet.Cells[rowIndex, columnIndex] = cellValue;
        }

        public void CloseExcel() {
            _workBook.Close(false, _missingObj, _missingObj);

            _application.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(_application);

            _application = null;
            _workBook = null;
            _workSheet = null;

            System.GC.Collect();
        }

        /**
         * ЧТЕНИЕ ЗНАЧЕНИЯ
         * 
         * param name="rowIndex" - 
         * param name="columnIndex" - 
         */
        public string GetValue(int rowIndex, int columnIndex) {
            string cellValue = "";
            Excel.Range cellRange = (Excel.Range)_workSheet.Cells[rowIndex, columnIndex];
            if (cellRange.Value != null)
            {
                cellValue = cellRange.Value.ToString();
            }
            return cellValue;
        }

        /**
         * Добавление строки
         * 
         * param name="rowNum" - 
         */
        public void InsertRow(int rowNum) {
            Excel.Range cellRange = (Excel.Range)_workSheet.Cells[rowNum, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
        }
    }
}
