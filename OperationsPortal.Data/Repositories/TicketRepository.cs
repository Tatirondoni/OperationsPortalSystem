using OperationsPortal.Domain.Entities;
using System.Collections.Generic;
using System.Linq;


namespace OperationsPortal.Data.Repositories
{
    public class TicketRepository
    {

        private readonly OperationsPortalDbEntities1 _context;


        public TicketRepository()
        {
            _context = new OperationsPortalDbEntities1();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<Ticket> GetAll()
        {
            return _context.Tickets.ToList();
        }

        public Ticket GetById(int id)
        {
            return _context.Tickets.FirstOrDefault(x => x.TicketId == id);
        }

    }
}

