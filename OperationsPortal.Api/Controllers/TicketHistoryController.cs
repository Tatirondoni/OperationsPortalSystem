using OperationsPortal.Data.Repositories;
using System.Web.Http;

namespace OperationsPortalApi.Controllers
{
    public class TicketHistoryController : ApiController
    {

        private readonly TicketHistoryRepository _repository;


        public TicketHistoryController()
        {
            _repository = new TicketHistoryRepository();
        }

        public IHttpActionResult Get()
        {
            var ticketHistories = _repository.GetAll();
            return Ok(ticketHistories);
        }

        public IHttpActionResult Get(int id)
        {
            var ticketHistory = _repository.GetById(id);

            if (ticketHistory == null)
                return NotFound();

            return Ok(ticketHistory);
        }

    }
}