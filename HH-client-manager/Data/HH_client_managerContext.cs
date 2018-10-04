using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HH_client_manager.Models
{
    public class HH_client_managerContext : DbContext
    {
        public HH_client_managerContext (DbContextOptions<HH_client_managerContext> options)
            : base(options)
        {
        }

        public DbSet<HH_client_manager.Models.Client> Client { get; set; }
    }
}
