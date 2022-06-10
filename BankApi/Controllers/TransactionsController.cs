using BankApi.Models;
using BankApi.Models.DTO;
using BankApi.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController: Controller
    {
        private readonly BankApiContext dbContext;

        public TransactionsController(BankApiContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBankTransactions() {

           var bankTransactions = await dbContext.Transactions.ToListAsync();

           return Ok(bankTransactions);

        }

        [HttpGet]
        [Route("{Id:guid}")]
        [ActionName("GetBankTransactionById")]
        public async Task<IActionResult> GetBankTransactionById(Guid Id) {
            
            var bankTransaction = await dbContext.Transactions.FirstOrDefaultAsync(tr => tr.Id == Id);

            if (bankTransaction != null)
            {
                return Ok(bankTransaction);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewTransaction(AddClientTransaction addClientTransaction)
        {
            
            var clientTransaction = new Transactions()
            {
                TransactionType = addClientTransaction.TransactionType,
                TransactionDate = addClientTransaction.TransactionDate,
                TransactionAmount = addClientTransaction.TransactionAmount
            };

            clientTransaction.Id = Guid.NewGuid();
            await dbContext.Transactions.AddAsync(clientTransaction);
            await dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBankTransactionById), new { Id = clientTransaction.Id }, clientTransaction);
            
        }

        [HttpPut]
        [Route("{Id:guid}")]

        public async Task<IActionResult> UpdateTransaction([FromRoute] Guid Id, UpdateBalance updateBalance)
        {

            //check if client exists
            var existingBalance = await dbContext.Transactions.FindAsync(Id);

            if (existingBalance != null )
            {
                existingBalance.AccountBalance = updateBalance.AccountBalance;

                await dbContext.SaveChangesAsync();

                return Ok(existingBalance);

            }

            return NotFound();

        }

        
    }

}