using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectWebProg.Models;

namespace ProjectWebProg.Data
{
    public class ProjectWebProgContext : DbContext
    {
        public ProjectWebProgContext (DbContextOptions<ProjectWebProgContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectWebProg.Models.Summoner> Summoner { get; set; }
    }
}
