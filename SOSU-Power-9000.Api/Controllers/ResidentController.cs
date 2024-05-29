using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResidentController(IRepository<Resident> repository) : Controller
    {
        private readonly IRepository<Resident> repository = repository;

        [HttpGet(nameof(GetById))]
        public ActionResult<Resident> GetById(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Resident> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public void AddNew([FromQuery] Resident resident)
        {
            repository.Add(resident);
        }

        [HttpPut]
        public void Update([FromQuery] Resident resident)
        {
            repository.Update(resident);
        }

        [HttpDelete(nameof(DeleteById))]
        public void DeleteById(int id)
        {
            repository.Delete(id);
        }
    }
}
