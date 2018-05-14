using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Ticket
    {
        public int TicketId { set; get; }
        public int ticketCode { set; get; }

        public int? nameSpectacleId { set; get; }
        public virtual Spectacle name { set; get; }
        

    }
}
