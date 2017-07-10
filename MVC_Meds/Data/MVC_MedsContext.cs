using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Meds.Models
{
    public class MVC_MedsContext : DbContext
    {
        public MVC_MedsContext (DbContextOptions<MVC_MedsContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Meds.Models.Meds> Meds { get; set; }
    }
}
