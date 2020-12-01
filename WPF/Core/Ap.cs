using LibDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPF.Core
{
    public class Ap
    {
        // private Traders t;
        //Доступ к Моделям, Проектам

        /// <summary>
        /// Управление моделями
        /// </summary>
        public static ModelControl MC = ModelControl.GetInstance();

        public static Constants Const = new Constants();

        /// <summary>
        /// Управление данными текущего проекта
        /// </summary>
        public static DataStore DS = new DataStore();

    }
}
