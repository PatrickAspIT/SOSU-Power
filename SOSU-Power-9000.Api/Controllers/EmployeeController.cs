using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController(IEmployeeRepository repository) : Controller
    {
        private readonly IRepository<Employee> repository = repository;

        [HttpGet(nameof(GetById))]
        public ActionResult<Employee> GetById(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public void AddNew([FromQuery] Employee employee)
        {
            repository.Add(employee);
        }

        [HttpPut]
        public void Update([FromQuery] Employee employee)
        {
            repository.Update(employee);
        }

        [HttpDelete(nameof(DeleteById))]
        public void DeleteById(int id)
        {
            repository.Delete(id);
        }
    }
}
