using Microsoft.EntityFrameworkCore;
using Productmicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productmicroservice.DatabaseContext
{
    public class ProductDBContext : DbContext
    {
        //have the list of tables this context will manage, as a properties

        public DbSet<Product> Products { get; set; }

        public DbSet<Productmicroservice.Models.Transactions> Transactions { get; set; }

        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options)
        {

        }
    
    }
}
