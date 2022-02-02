using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1_core.Models
{
    public class newscontixit : DbContext
    {
        public newscontixit(DbContextOptions<newscontixit> options)
            : base(options)
        {
        }


        public DbSet<news> News { get; set; }
        public DbSet<catogri> catogris { get; set; }
        public DbSet<countactus> countactus { get; set; }
        public DbSet<temnmmber> temnmmbers { get; set; }




    }
}
