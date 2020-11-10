using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Core;
using WPF.Utils;

namespace WPF.ViewModels
{
    public class VM_MainWindow : VM_Basic
    {
        public RelayCommand CmdExcel { get { return new RelayCommand(_DoExcel, _AlwaysTrue); } }

        private void _DoExcel()
        {//Test
            WorkExcel workExcel = new WorkExcel();
            workExcel.CreateExcel();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    workExcel.InsertValue((i + 2 * j).ToString(), i + 1, j + 1);
                }             
            }
       
            workExcel.Visible = true;
        }

        public string Title
        {
            get { return Ap.Const.Title; }
        }
    }
}
