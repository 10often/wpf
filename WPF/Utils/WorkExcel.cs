﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace WPF
{
    public class WorkExcel
    {
        private Excel.Application _application = null;
        private Excel.Workbook _workBook = null;
        private Excel.Worksheet _workSheet = null;
        private object _missingObj = System.Reflection.Missing.Value;
        public void CreateExcel() //Создание Книги Excel
        {
            _application = new Excel.Application(); // Создаём экземпляр нашего приложения
            _workBook = _application.Workbooks.Add(_missingObj); // Создаём экземпляр рабочий книги Excel
            _workSheet = (Excel.Worksheet)_workBook.Worksheets.get_Item(1); // Создаём экземпляр листа Excel
        }
        public void CreateExcel(string pathToTemplate) //Создание Книги Excel
        {
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
        public void FillTable(string[,] source, int startRow, int startColumn)
        {
         //TODO   
        }

        /// <summary>
        /// ПОлучает матрицу значений из диапазона
        /// </summary>
        /// <param name="rFrom">НАчало диапазона - строка</param>
        /// <param name="cFrom">НАчало диапазона - столбец</param>
        /// <param name="rTo">Конец диапазона - строка</param>
        /// <param name="cTo">Конец диапазона - столбец</param>
        /// <returns></returns>
        public string[,] GetRange(int rFrom, int cFrom, int rTo, int cTo)
        {
            //TODO
            return null;
        }

        public bool Visible // ВИДИМОСТЬ ДОКУМЕНТА
        {
            get
            {
                return _application.Visible;
            }
            set
            {
                _application.Visible = value;
            }
        }
        public void InsertValue(string cellValue, int rowIndex, int columnIndex) // ВСТАВКА ЗНАЧЕНИЯ В ЯЧЕЙКУ
        {
            _workSheet.Cells[rowIndex, columnIndex] = cellValue;
        }

        public void CloseExcel()
        {
            _workBook.Close(false, _missingObj, _missingObj);

            _application.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(_application);

            _application = null;
            _workBook = null;
            _workSheet = null;

            System.GC.Collect();
        }
        public string GetValue(int rowIndex, int columnIndex) // ЧТЕНИЕ ЗНАЧЕНИЯ
        {
            string cellValue = "";
            Excel.Range cellRange = (Excel.Range)_workSheet.Cells[rowIndex, columnIndex];
            if (cellRange.Value != null)
            {
                cellValue = cellRange.Value.ToString();
            }
            return cellValue;
        }
        public void InsertRow(int rowNum) //Добавление строки
        {
            Excel.Range cellRange = (Excel.Range)_workSheet.Cells[rowNum, 1];
            Excel.Range rowRange = cellRange.EntireRow;
            rowRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown, false);
        }
    }
}
