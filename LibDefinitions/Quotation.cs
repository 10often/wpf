using System;
using System.Collections.Generic;

namespace LibDefinitions
{
    public class Quotation
    {
        public int Id { get; set; }
        public int InstrumentId { get; set; }
        public string Name { get; set; }
        public float Open { get; set; }
        public float Close { get; set; }
        public float Low { get; set; }
        public float High { get; set; }
        public float Difference { get; set; }
        public int Volume { get; set; }
        public DateTime Date { get; set; }
        public List<Request> Requests { get; set; }

        public Quotation()
        {
        }

        public Quotation(int id, int instrumentId, string name, float open, float close, float low, float high, 
            float difference, int volume, DateTime date, List<Request> requests)
        {
            Id = id;
            InstrumentId = instrumentId;
            Name = name;
            Open = open;
            Close = close;
            Low = low;
            High = high;
            Difference = difference;
            Volume = volume;
            Date = date;
            Requests = requests;
        }
    }
}