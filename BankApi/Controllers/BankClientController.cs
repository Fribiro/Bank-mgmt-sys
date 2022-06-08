using BankApi.Models;
using BankApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankClientController : Controller
    {
        private readonly BankApiContext dbContext;

        public BankClientController(BankApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBankClients() {

           var bankClients = await dbContext.BankClients.ToListAsync();

           return Ok(bankClients);

        }

        [HttpGet]
        [Route("{ClientId}")]
        [ActionName("GetBankClientById")]
        public async Task<IActionResult> GetBankClientById(Guid ClientId) {
            
            var bankClient = await dbContext.BankClients.FirstOrDefaultAsync(bC => bC.ClientId == ClientId);

            if (bankClient != null)
            {
                return Ok(bankClient);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddBankClient(AddBankClient addBankClient)
        {
            //convert DTO to Entity
            var bankclient = new BankClients()
            {
                FirstName = addBankClient.FirstName,
                LastName = addBankClient.LastName,
                Email = addBankClient.Email,
                Phone = addBankClient.Phone
            };

            bankclient.ClientId = Guid.NewGuid();
            await dbContext.BankClients.AddAsync(bankclient);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBankClientById), new { ClientId = bankclient.ClientId }, bankclient);
            
        }

        [HttpPut]
        [Route("{ClientId}")]

        public async Task<IActionResult> UpdateBankClient([FromRoute] Guid ClientId, UpdateClient updateClient)
        {
            var bankclient = new BankClients()
            {
                FirstName = updateClient.FirstName,
                LastName = updateClient.LastName,
                Email = updateClient.Email,
                Phone = updateClient.Phone
            };

            //check if client exists
            var existingClient = dbContext.BankClients.FindAsync(ClientId);
            
        }
    }
}