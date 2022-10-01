using Microsoft.AspNetCore.Mvc;
using SalesWebAPI.Data;
using SalesWebAPI.Models;
using System.Runtime.InteropServices;

namespace SalesWebAPI.Controllers
{
    [Route("api/buyers")]
    public class BuyersController : Controller
    {
        private readonly IDataManager<Buyer> dataManager;

        public BuyersController(IDataManager<Buyer> dataManager)
        {
            this.dataManager = dataManager;
        }

        [HttpGet]
        public async Task<IEnumerable<Buyer>> Get()
        {
            return await dataManager.Get();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Buyer>> Get(int id)
        {
            var buyer = await dataManager.Get(id);
            if (buyer is not null)
                return new ActionResult<Buyer>(buyer);
            else
                return NotFound();
        }

        [HttpPost]
        public async Task Add(Buyer buyer)
        {
            await dataManager.Add(buyer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await dataManager.Delete(id))
                return Ok();
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public async Task Update(int id, Buyer updatedBuyer)
        {
            var buyerToUpdate = await dataManager.Get(id);

            buyerToUpdate.Name = updatedBuyer.Name;

            await dataManager.Update(buyerToUpdate);
        }
    }
}
