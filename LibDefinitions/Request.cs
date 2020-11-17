using System;

namespace LibDefinitions
{
    public class Request
    {
        public string Id { get; set; }

        public string TraderId { get; set; }

        public string QuotationId { get; set; }

        public DateTime Date { get; set; }

        public float Price { get; set; }

        public int Volume { get; set; }

        public bool RequestType { get; set; }

        public string Name { get; set; }

        public Request()
        {
        }

        public Request(string id, string traderId, string quotationId, DateTime date, float price, int volume, 
            bool requestType, string name)
        {
            Id = id;
            TraderId = traderId;
            QuotationId = quotationId;
            Date = date;
            Price = price;
            Volume = volume;
            RequestType = requestType;
            Name = name;
        }
    }
}