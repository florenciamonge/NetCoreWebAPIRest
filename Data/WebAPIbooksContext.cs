using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIbooks.Models;

namespace WebAPIbooks.Data
{
    public class WebAPIbooksContext : DbContext
    {
        public WebAPIbooksContext (DbContextOptions<WebAPIbooksContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPIbooks.Models.Book> Book { get; set; }
    }
}
