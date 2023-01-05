using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WTF.api.Data;

namespace WTF.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsApiController : ControllerBase
    {
        public AppDbContext _context;

        public TransactionsApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var transaction= _context.Transactions.Include(t=>t.purchasedItems).Where(t=>t.Id==id);
           
            return Ok(transaction);
        }
         [HttpGet]
        public async Task<IActionResult> Get()
        {
            var transactions= _context.Transactions.ToList();
            return Ok(transactions);
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var transaction  = new Transaction();
            await _context.Transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
            transaction.purchasedItems= _context.Items.Where(i=>i.MenuId==2 || i.MenuId==1).ToList();
            return Ok(transaction);
        }
    }
}