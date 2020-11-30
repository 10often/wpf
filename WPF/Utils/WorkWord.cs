using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Word = Microsoft.Office.Interop.Word;

namespace WPF.Utils
{
    public class WorkWord
    {
        private Word.Application _application = null;
        private Word.Document _document = null;
        object missing = System.Reflection.Missing.Value; // переменная для пропущенных значений при создании документа 
        
        public void CreateWord()
        {
            _application = new Word.Application(); // Создаём экземпляр нашего приложения
            //_application.ShowAnimation = false; // Убираем анимацию, почему-то эта строка выводит ошибку в 2019 версии, хотя в 2015 она не жалуется
            _application.Visible = false;
            _document = _application.Documents.Add(ref missing, ref missing, ref missing, ref missing); // Создаем документ

        }
        ///<summary>
        ///Вставляет текст
        ///</summary>
        ///<param name="source"> массив строк, каждая которая является новым абзацем</param>
        public void InputText(string[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                _document.Characters.Last.Select(); // находим последнюю строку
                _application.Selection.Collapse(); //переходим на новую строку
                _application.Selection.TypeText(source[i] + Environment.NewLine); //вставляем текст и переход на новую строку
            }
        }
        ///<summary>
        ///Вставляет изображение
        ///</summary> 
        ///<param name="image_path">Путь к файлу по абсолютному или относительному адресу</param> 
        public void InputImage(string image_path)
        {
            _document.Characters.Last.Select();
            _application.Selection.Collapse();
            _application.Selection.InlineShapes.AddPicture(image_path);
            _application.Selection.TypeText(Environment.NewLine);//переход на новую строку
        }
        /// <summary>
        /// Вставляет таблицу 
        /// </summary>
        /// <param name="source"> Двумерный массив строк </param>
        public void InputTable(string[,] source)
        {
            _document.Characters.Last.Select();
            _application.Selection.Collapse();
            Word.Range wordRange = _application.Selection.Range;
            var wordTable = _document.Tables.Add(wordRange, source.GetLength(0), source.GetLength(1)); // 0 - rows; 1 - colums
            wordTable.Borders.Enable = 1;//выделение границ для видимости таблицы
            for (var j = 0; j < source.GetLength(0); j++)//проход по строке
            {
                for (var k = 0; k < source.GetLength(1); k++)//проход по столбцам
                {
                    wordTable.Cell(j + 1, k + 1).Range.Text = source[j, k];//заполняем ячейку
                }
            }
            _document.Characters.Last.Select();
            _application.Selection.Collapse();
        }
        public bool Visible
        {
            get { return _application.Visible; }
            set { _application.Visible = value; }
        }
        /*public void CloseWord()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            object filename = path + "\\temp1.docx";
            _document.SaveAs2(ref filename);
            _document.Close(ref missing, ref missing, ref missing);
            _document = null;
            _application.Quit(ref missing, ref missing, ref missing);
            _application = null;
        }*/
    }
}