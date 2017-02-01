using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaindBoxDomain.Core
{
    public class Ticket
    {


        public Ticket(string From, string To)
        {
            this.From = From;
            this.To = To;
        }

        public string From { get; set; }

        public string To { get; set; }
    }
}
