using LibDefinitions;
using System;
using System.Collections.Generic;

namespace WPF.Core
{
    [Serializable]
    public class ModelControl
    {
        private ModelControl() { FillTestData(); }

        private static ModelControl s_inst = new ModelControl();

        public static ModelControl GetInstance()
        {    
            return s_inst;
        }

        private void FillTestData()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Quotation.Add(new Quotation()
                {
                     Id = i,
                     Close = (float)(i * r.NextDouble()),
                     Date = DateTime.Now,
                     High = (float)(i * r.NextDouble()),
                     Low = (float)(i * r.NextDouble()),
                     Name = $"Q_{i}",
                     Open = (float)(i * r.NextDouble()),
                     Volume = 10*i * (int)Math.Round(r.NextDouble()),
                     InstrumentId = i+1,
                     Difference = 25
                });
            }
        }

        /// <summary>
        /// Трейдеры
        /// </summary>
        public List<Trader> Traders = new List<Trader>();

        /// <summary>
        /// Трейдеры
        /// </summary>
        public List<Quotation> Quotation = new List<Quotation>();


    }
}
