using System.Collections.Generic;
using System.Linq;

namespace OperationsPortal.Data.Repositories
{

    public class TicketStatusRepository
    {

        private readonly OperationsPortalDbEntities1 _context;


        public TicketStatusRepository()
        {
            _context = new OperationsPortalDbEntities1();
            _context.Configuration.ProxyCreationEnabled = false;
        }

        public List<TicketStatu> GetAll()
        {
            return _context.TicketStatus.ToList();
        }

        public TicketStatu GetById(int id)
        {
            return _context.TicketStatus.FirstOrDefault(x => x.TicketStatusId == id);
        }
    }

}
