using BankApi.Models;
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
        [Route("{ClientId:int")]
        public async Task<IActionResult> GetBankClientById(int ClientId) {
            
            var bankClient = await dbContext.BankClients.FirstOrDefaultAsync(bC => bC.ClientId == ClientId);

            if (bankClient != null)
            {
                return Ok(bankClient);
            }

            return NotFound();
        }
    }
}