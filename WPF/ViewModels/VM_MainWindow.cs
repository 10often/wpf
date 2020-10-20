using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Core;

namespace WPF.ViewModels
{
    public class VM_MainWindow : VM_Basic
    {
        public string Title
        {
            get { return Ap.Const.Title; }
        }
    }
}
