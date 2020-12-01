using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Core;
using WPF.Utils;
using WPF.Views;

namespace WPF.ViewModels
{
    public class VM_MainWindow : VM_Basic
    {
        public RelayCommand CmdExcel { get { return new RelayCommand(_DoExcel, _AlwaysTrue); } }
        public RelayCommand CmdSave { get { return new RelayCommand(_DoSave, _AlwaysTrue); } }
        public RelayCommand CmdWord { get { return new RelayCommand(_DoWord, _AlwaysTrue); } }


        private void _DoSave()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() != true)
                return;

            Ap.MC.Traders.Add(new LibDefinitions.Trader() { Account = 200, Id = 1, Name = "Alex" });

            Ap.DS.SaveToJSON(saveFileDialog.FileName, Ap.MC);
        }

        private void _DoExcel()
        {//Test
         //WorkExcel workExcel = new WorkExcel();
         //workExcel.CreateExcel();
         //for (int i = 0; i < 10; i++)
         //{
         //    for (int j = 0; j < 10; j++)
         //    {
         //        workExcel.InsertValue((i + 2 * j).ToString(), i + 1, j + 1);
         //    }             
         //}

            //workExcel.Visible = true;

            ExportExcelWindow w = new ExportExcelWindow();
            w.Show();
        }

        private void _DoWord()
        {//Test
            WorkWord workWord = new WorkWord();
            workWord.CreateWord();
            string[] words = new string[] { "Harder", "Better", "Faster", "Stronger" };
            workWord.InputText(words);
            //string imagePath = @"D:\wpf\WPF\bin\Debug\test.jpg";
            string newPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\");
            //newPath = System.IO.Path.Combine(newPath, @"Common\UML_Diagram.PNG");
            //workWord.InputImage(newPath);
            newPath = System.IO.Path.Combine(newPath, @"Common\test.jpg");
            workWord.InputImage(newPath);
            //workWord.InputImage(imagePath);
            workWord.InputText(words);
            string[,] words_m = new string[,] { { "Harder", "Better", "Faster", "Stronger" }, { "hi", "my", "by", "fy" }, { "Harder", "Better", "Faster", "Stronger" } };
            workWord.InputTable(words_m);
            workWord.Visible = true;
        }

        public string Title
        {
            get { return Ap.Const.Title; }
        }
    }
}
