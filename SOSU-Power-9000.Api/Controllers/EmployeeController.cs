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

        /// <summary>
        /// Uses the GET method to get an employee by their ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetById))]
        public ActionResult<Employee> GetById(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Uses the GET method to get all employees.
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(GetAll))]
        public IEnumerable<Employee> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Uses the POST method to add a new employee.
        /// </summary>
        /// <param name="employee"></param>
        [HttpPost]
        public void AddNew([FromQuery] Employee employee)
        {
            repository.Add(employee);
        }

        /// <summary>
        /// Uses the PUT method to update an employee.
        /// </summary>
        /// <param name="employee"></param>
        [HttpPut]
        public void Update([FromQuery] Employee employee)
        {
            repository.Update(employee);
        }

        /// <summary>
        /// Uses the DELETE method to delete an employee by their ID.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete(nameof(DeleteById))]
        public void DeleteById(int id)
        {
            repository.Delete(id);
        }
    }
}
