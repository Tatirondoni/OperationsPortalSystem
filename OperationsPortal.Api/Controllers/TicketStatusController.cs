using OperationsPortal.Data.Repositories;
using System.Web.Http;

namespace OperationsPortal.Api.Controllers
{


    public class TicketStatusController : ApiController


    {
        private readonly TicketStatusRepository _repository;

        public TicketStatusController()
        {
            _repository = new TicketStatusRepository();
        }


        public IHttpActionResult Get()
        {
            var ticketStatus = _repository.GetAll();
            return Ok(ticketStatus);
        }


        public IHttpActionResult Get(int id)
        {
            var ticketStatus = _repository.GetById(id);

            if (ticketStatus == null)
                return NotFound();

            return Ok(ticketStatus);
        }
    }

}