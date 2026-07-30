using OperationsPortal.Api.Models;
using OperationsPortal.Data.Repositories;
using System.Linq;
using System.Web.Http;

namespace OperationsPortalApi.Controllers
{
    public class UsersController : ApiController
    {

        private readonly UserRepository _repository;

        public UsersController()

        {
            _repository = new UserRepository();
        }

        public IHttpActionResult Get()

        {
            var users = _repository.GetAll()
                .Select(x => new UserDto
                {
                    UserId = x.UserId,
                    Name = x.Name,
                    Email = x.Email,
                    Login = x.Login,
                    IsActive = x.IsActive,
                    CreatedAt = x.CreatedAt
                })
                .ToList();

            return Ok(users);
        }

        public IHttpActionResult Get(int id)

        {
            var user = _repository.GetById(id);

            if (user == null)
                return NotFound();

            var userDto = new UserDto
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Login = user.Login,
                IsActive = user.IsActive,
                CreatedAt = user.CreatedAt
            };

            return Ok(userDto);
        }
    }
}