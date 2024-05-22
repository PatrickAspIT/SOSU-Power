using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IRepository<Entities.Employee> repository;

        public EmployeeController(IRepository<Entities.Employee> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Employee> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetEmployeesFor))]
        public ActionResult<Entities.Employee> GetEmployeesFor(string careCenter)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Employee employee)
        {
            repository.Add(employee);
        }
    }
}
