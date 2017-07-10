using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Meds.Models
{
    public class Meds
    {
        public int ID { get; set; }
        public string rxName { get; set; }
        public int rxNumber { get; set; }
        public int rxAmount { get; set; }
        public int doses { get; set; }
        public int dosesLeft { get; set; }
        public DateTime fillDate { get; set; }
        public DateTime refillDate { get; set; }
        public string rxPhone { get; set; }
        public bool email { get; set; }
        public bool text { get; set; }
        public int acctID { get; set; }
    }
}
