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

        /// <summary>
        /// Uses the GET method to get a task by its ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Uses the GET method to get all tasks.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Entities.Task> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Uses the GET method to get all tasks for a specific employee by a specific date.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetTasksForEmployeeByDate))]
        public IEnumerable<Entities.Task> GetTasksForEmployeeByDate(int employeeId, DateTime date = default)
        {
            return repository.GetTasksForEmployeeByDate(employeeId, date);
        }

        /// <summary>
        /// Uses the GET method to get all tasks for a specific employee.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetTasksForEmployeee))]
        public IEnumerable<Entities.Task> GetTasksForEmployeee([FromQuery] Employee employee)
        {
            return repository.GetTasksForEmployee(employee);
        }

        /// <summary>
        /// Uses the POST method to add a new task.
        /// </summary>
        /// <param name="task"></param>
        [HttpPost]
        public void AddNew(Entities.Task task)
        {
            repository.Add(task);
        }

        /// <summary>
        /// Uses the PUT method to update a task.
        /// </summary>
        /// <param name="task"></param>
        [HttpPut]
        public void Update(Entities.Task task)
        {
            repository.Update(task);
        }

        /// <summary>
        /// Uses the DELETE method to delete a task by its ID.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("DeleteById")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        /// <summary>
        /// Uses the DELETE method to delete a task.
        /// </summary>
        /// <param name="task"></param>
        [HttpDelete]
        public void Delete(Entities.Task task)
        {
            repository.Delete(task);
        }
    }
}
