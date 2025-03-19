using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SnackTrackerApp.Models
{
    public class SnackDbContext : DbContext
    {
        public DbSet<Snack> Snacks { get; set; }

        public SnackDbContext() : base("name=SnackTrackerDB")
        {
        }
    }
}
