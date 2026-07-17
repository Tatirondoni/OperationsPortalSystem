using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsPortal.Domain.Entities
{
    public class TicketHistory
    {
        public int TicketHistoryId { get; set; }
        public int TicketId { get; set; }
        public int PreviousTicketStatusId { get; set; }
        public int NewTicketStatusId { get; set; }
        public int ChangedByUserId { get; set; }
        public string Comment { get; set; }
        public DateTime ChangedAt { get; set; }
    }
}
