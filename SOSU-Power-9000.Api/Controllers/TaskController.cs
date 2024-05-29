using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;
using SOSU_Power_9000.Entities;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController(ITaskRepository repository, IEmployeeRepository employeeRepository) : Controller
    {
        private readonly ITaskRepository repository = repository;
        private readonly IEmployeeRepository employeeRepository = employeeRepository;

        [HttpGet]
        public IEnumerable<Entities.Task> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetTasksOnDate))]
        public IEnumerable<Entities.Task> GetTasksOnDate(DateTime date = default)
        {
            if (date == default)
                date = DateTime.Now;
            return repository.GetTasksOnDate(date);
        }

        [HttpGet(nameof(GetTasksForEmployeee))]
        public IEnumerable<Entities.Task> GetTasksForEmployeee([FromQuery] Employee employee)
        {
            return repository.GetTasksForEmployee(employee);
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
            repository.Add(task);
        }

        [HttpPut]
        public void Update(Entities.Task task)
        {
            repository.Update(task);
        }

        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpDelete]
        public void Delete(Entities.Task task)
        {
            repository.Delete(task);
        }
    }
}
