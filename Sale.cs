using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОАИП_12
{
    public class Sale
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Clientid { get; set; }
        public string Goods { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }
        public Client Client { get; set; }

    }
}
