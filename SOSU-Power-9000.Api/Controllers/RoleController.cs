using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : Controller
    {
        private readonly IRepository<Entities.Role> repository;

        public RoleController(IRepository<Entities.Role> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Role> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetRolesFor))]
        public ActionResult<Entities.Role> GetRolesFor(string name)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Role role)
        {
            repository.Add(role);
        }
    }
}
