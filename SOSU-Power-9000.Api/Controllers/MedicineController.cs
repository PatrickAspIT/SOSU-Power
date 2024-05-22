using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicineController : Controller
    {
        private readonly IRepository<Entities.Medicine> repository;

        public MedicineController(IRepository<Entities.Medicine> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Medicine> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetMedicinesFor))]
        public ActionResult<Entities.Medicine> GetMedicinesFor(string careCenter)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Medicine medicine)
        {
            repository.Add(medicine);
        }
    }
}
