using System.Linq;
using System.Web.Http;
using OperationsPortal.Data.Repositories;
using OperationsPortal.Domain.Entities;

namespace OperationsPortal.Api.Controllers
{
    [RoutePrefix("api/categories")]
    public class CategoryController : ApiController
    {
        private readonly CategoryRepository _repository = new CategoryRepository();

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var categories = _repository.GetAll();
            return Ok(categories);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            var category = _repository.GetById(id);

            if (category == null)
                return NotFound();

            return Ok(category);
        }
    }
}