using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WTF.api.Data
{
    public class AppDbContext:DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
    public DbSet<Menu> FoodMenus { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    }
}