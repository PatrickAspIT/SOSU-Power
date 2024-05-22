using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidentController : Controller
    {
        private readonly IRepository<Entities.Resident> repository;

        public ResidentController(IRepository<Entities.Resident> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Resident> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetResidentsFor))]
        public ActionResult<Entities.Resident> GetResidentsFor(string careCenter)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Resident resident)
        {
            repository.Add(resident);
        }
    }
}
