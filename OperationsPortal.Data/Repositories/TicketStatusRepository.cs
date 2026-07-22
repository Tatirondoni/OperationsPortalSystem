using OperationsPortal.Domain.Entities;
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
        }

        public List<TicketStatus> GetAll()
        {
            return _context.TicketStatus.ToList();
        }

        public TicketStatus GetById(int id)
        {
            return _context.TicketStatus.FirstOrDefault(x => x.TicketStatusId == id);
        }
    }

}
