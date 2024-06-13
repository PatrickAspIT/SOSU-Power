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

        /// <summary>
        /// Uses the GET method to get a resident by their ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet(nameof(GetById))]
        public ActionResult<Resident> GetById(int id)
        {
            return repository.GetBy(id);
        }

        /// <summary>
        /// Uses the GET method to get all residents.
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(GetAll))]
        public IEnumerable<Resident> GetAll()
        {
            return repository.GetAll();
        }

        /// <summary>
        /// Uses the POST method to add a new resident.
        /// </summary>
        /// <param name="resident"></param>
        [HttpPost]
        public void AddNew([FromQuery] Resident resident)
        {
            repository.Add(resident);
        }

        /// <summary>
        /// Uses the PUT method to update a resident.
        /// </summary>
        /// <param name="resident"></param>
        [HttpPut]
        public void Update([FromQuery] Resident resident)
        {
            repository.Update(resident);
        }

        /// <summary>
        /// Uses the DELETE method to delete a resident by their ID.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete(nameof(DeleteById))]
        public void DeleteById(int id)
        {
            repository.Delete(id);
        }
    }
}
