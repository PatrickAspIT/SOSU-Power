using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CareCenterController : Controller
    {
        private readonly IRepository<Entities.CareCenter> repository;

        public CareCenterController(IRepository<Entities.CareCenter> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.CareCenter> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetCareCentersFor))]
        public ActionResult<Entities.CareCenter> GetCareCentersFor(string name)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.CareCenter careCenter)
        {
            repository.Add(careCenter);
        }
    }
}
