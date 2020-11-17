using System.Collections.Generic;

namespace LibDefinitions
{
    public class Trader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Account { get; set; }
        public List<Request> Requests { get; set; }

        public Trader()
        {
        }

        public Trader(int id, string name, float account, List<Request> requests)
        {
            Id = id;
            Name = name;
            Account = account;
            Requests = requests;
        }
        
    }
}
