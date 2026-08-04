using OperationsPortal.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OperationsPortal.Data.Repositories
{

    public class TicketHistoryRepository

    {
        private readonly OperationsPortalDbEntities1 _context;

        public TicketHistoryRepository()
        {
            _context = new OperationsPortalDbEntities1();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<TicketHistory> GetAll()
        {
            return _context.TicketHistories.ToList();
        }

        public TicketHistory GetById(int id)
        {
            return _context.TicketHistories.FirstOrDefault(x => x.TicketHistoryId == id);
        }

    }
}
