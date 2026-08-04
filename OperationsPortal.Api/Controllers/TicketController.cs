using OperationsPortal.Data.Repositories;
using System.Web.Http;


namespace OperationsPortalApi.Controllers
{

    public class TicketController : ApiController
    {

        private readonly TicketRepository _repository;


        public TicketController()
        {
            _repository = new TicketRepository();
        }

        public IHttpActionResult Get()
        {
            var tickets = _repository.GetAll();
            return Ok(tickets);
        }

        public IHttpActionResult Get(int id)
        {
            var ticket = _repository.GetById(id);

            if (ticket == null)
                return NotFound();

            return Ok(ticket);
        }

    }
}
