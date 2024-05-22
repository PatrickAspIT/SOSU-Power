using Microsoft.AspNetCore.Mvc;
using SOSU_Power_9000.DataAccess;

namespace SOSU_Power_9000.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private readonly IRepository<Entities.Address> repository;

        public AddressController(IRepository<Entities.Address> repository)
        {
            this.repository = repository;
        }

        [HttpGet(nameof(GetBy))]
        public ActionResult<Entities.Address> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetAddressesFor))]
        public ActionResult<Entities.Address> GetAddressesFor(string careCenter)
        {
            return default; // TODO: Implement
        }

        [HttpPost]
        public void AddNew(Entities.Address address)
        {
            repository.Add(address);
        }
    }
}
