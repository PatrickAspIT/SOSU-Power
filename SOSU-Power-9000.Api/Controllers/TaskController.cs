using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly IRepository<Entities.Task> repository;

        public TaskController(IRepository<Entities.Task> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetTasksFor))]
        public ActionResult<Entities.Task> GetTasksFor(DateTime date = default)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
            repository.Add(task);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
