using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication30.Models;

namespace WebApplication30.Data
{
    public class WebApplication30Context : DbContext
    {
        public WebApplication30Context (DbContextOptions<WebApplication30Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication30.Models.Shops> Shops { get; set; } = default!;
    }
}
