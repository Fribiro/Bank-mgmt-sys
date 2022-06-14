using BankApi.Models;
using BankApi.Models.DTO;
using BankApi.Models.Entity;
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
        [Route("{Id:guid}")]
        [ActionName("GetBankClientById")]
        public async Task<IActionResult> GetBankClientById(Guid Id) {
            
            var bankClient = await dbContext.BankClients.FirstOrDefaultAsync(bC => bC.Id == Id);

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

            bankclient.Id = Guid.NewGuid();
            await dbContext.BankClients.AddAsync(bankclient);
            //await dbContext.AccountDetails.AddAsync(new AccountDetails () { BankClients = bankclient});
            await dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBankClientById), new { Id = bankclient.Id }, bankclient);
            
        }

        [HttpPost]
        [Route("deposit/{Id:guid}")]

        public async Task<IActionResult> AddNewTransaction([FromRoute] Guid Id,[FromQueryAttribute] Transactions transactions,[FromBodyAttribute] AddClientTransaction addClientTransaction)
        {
            //addClientTransaction.BankClients = Id;

            var clientTransaction = new Transactions()
            {
                TransactionType = addClientTransaction.TransactionType,
                TransactionDate = addClientTransaction.TransactionDate,
                TransactionAmount = addClientTransaction.TransactionAmount,
                AccountBalance = addClientTransaction.AccountBalance,
                BankClients = addClientTransaction.BankClients
                //transactions.AccountBalance - addClientTransaction.AccountBalance (bankClients.Id == addClientTransaction.BankClients)
              
            };

            clientTransaction.Id = Guid.NewGuid();
            await dbContext.Transactions.AddAsync(clientTransaction);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBankClientById), clientTransaction);
            
        }

        [HttpPut]
        [Route("{Id:guid}")]

        public async Task<IActionResult> UpdateBankClient([FromRoute] Guid Id, UpdateClient updateClient)
        {

            //check if client exists
            var existingClient = await dbContext.BankClients.FindAsync(Id);

            if (existingClient != null )
            {
                existingClient.FirstName = updateClient.FirstName;
                existingClient.LastName = updateClient.LastName;
                existingClient.Email = updateClient.Email;
                existingClient.Phone = updateClient.Phone;

                await dbContext.SaveChangesAsync();

                return Ok(existingClient);

            }

            return NotFound();

        }

        [HttpDelete]
        [Route("{Id:guid}")]

        public async Task<IActionResult> DeleteClient(Guid Id)
        {
            var existingClient = await dbContext.BankClients.FindAsync(Id);

            if (existingClient != null)
            {
                dbContext.Remove(existingClient);
                await dbContext.SaveChangesAsync();

                return Ok(existingClient);
            }

            return NotFound();
        }
    }
}