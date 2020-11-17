using System.Collections.Generic;

namespace LibDefinitions
{
    public class Instrument
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Quotation> Quotations { get; set; }

        public Instrument(List<Quotation> quotations)
        {
            Quotations = quotations;
        }

        public Instrument(string id, string name, List<Quotation> quotations)
        {
            Id = id;
            Name = name;
            Quotations = quotations;
        }
    }
}