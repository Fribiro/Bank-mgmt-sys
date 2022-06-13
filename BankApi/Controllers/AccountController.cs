using BankApi.Models;
using BankApi.Models.DTO;
using BankApi.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Controllers
{
    public class AccountController: Controller
    {
        private readonly BankApiContext dbContext;

        public AccountController(BankApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClientAccounts() {

           var accountDetails = await dbContext.AccountDetails.ToListAsync();

           return Ok(accountDetails);

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

        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetBankAccountById")]
        public async Task<IActionResult> GetBankAccountById(Guid Id) {
            
            var account = await dbContext.AccountDetails.FirstOrDefaultAsync(ac => ac.Id == Id);

            if (account != null)
            {
                return Ok(account);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddAccountDetails(AddAccountDetails addAccountDetails)
        {
            
            var newaccount = new AccountDetails()
            {
                AccountType = addAccountDetails.AccountType,
                AccountBalance = addAccountDetails.AccountBalance
            };

            newaccount.Id = Guid.NewGuid();
            //newaccount.BankClients = await dbContext.BankClients.FirstOrDefaultAsync(ac => ac.Id == BankClients.Id);
            await dbContext.AccountDetails.AddAsync(newaccount);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBankAccountById), new { Id = newaccount.Id }, newaccount);
            
        }

        [HttpPut]
        [Route("{Id:guid}")]

        public async Task<IActionResult> UpdateAccountDetails([FromRoute] Guid Id, UpdateAccountDetails updateAccountDetails)
        {

            //check if client exists
            var existingAccount = await dbContext.AccountDetails.FindAsync(Id);

            if (existingAccount != null )
            {
                existingAccount.AccountType = updateAccountDetails.AccountType;
                existingAccount.AccountBalance = updateAccountDetails.AccountBalance;

                await dbContext.SaveChangesAsync();

                return Ok(existingAccount);

            }

            return NotFound();

        }

        [HttpDelete]
        [Route("{Id:guid}")]

        public async Task<IActionResult> DeleteAccount(Guid Id)
        {
            var existingAccount = await dbContext.AccountDetails.FindAsync(Id);

            if (existingAccount != null)
            {
                dbContext.Remove(existingAccount);
                await dbContext.SaveChangesAsync();

                return Ok(existingAccount);
            }

            return NotFound();
        }
    }
}