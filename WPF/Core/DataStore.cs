using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows;

namespace WPF.Core
{
    public class DataStore
    {
        public bool IsProjectChanged { get; set; } = false;

        public void SaveToJSON(string fileName, ModelControl mc)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new Exception("fileName пуст");

            if (mc == null)
                throw new ArgumentNullException("mc");
            //throw new Exception("mc == null");

            string jsonString = "";
            try
            {
                jsonString = JsonConvert.SerializeObject(mc);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка сериализации JSON, подробности: " + ex.Message
                    ,"Сохранение проекта в JSON", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                File.WriteAllText(fileName, jsonString, Encoding.UTF8);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Ошибка сохранения файла, подробности: " + ex.Message
                    , "Сохранение проекта в файл", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
