using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Data;

namespace BankApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ClientAccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]

        public JsonResult GET()
        {
            string query = @"
                select * from bankclients            
            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("BankAppCon");
            NpgsqlDataReader myReader;
            using (NpgsqlConnection myCon = new NpgsqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (NpgsqlCommand myCommand = new NpgsqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();

                }
            }

            return new JsonResult(table);

        }
    }
}
