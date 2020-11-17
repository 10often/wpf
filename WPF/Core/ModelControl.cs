using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Core
{
    [Serializable]
    public class ModelControl
    {
        private ModelControl() { }

        private static ModelControl s_inst = new ModelControl();

        public static ModelControl GetInstance()
        {
            return s_inst;
        }
    }
}
