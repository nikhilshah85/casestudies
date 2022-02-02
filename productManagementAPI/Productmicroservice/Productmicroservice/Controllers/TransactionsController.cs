using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productmicroservice.Repository.Transaction;
using Productmicroservice.Models;


namespace Productmicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionRepository _trRepo;

        public TransactionsController(ITransactionRepository trRepoRef)
        {
            _trRepo = trRepoRef;
        }

        [HttpGet]
        public IActionResult GetTransaction()
        {
            return Ok(_trRepo.GetTransactions());
        }
        [HttpPost]
        public IActionResult Post(Transactions newTr)
        {
            return Created("",_trRepo.AddTransaction(newTr));
        }
    }
}