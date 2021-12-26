using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProg_Project.Models;

namespace WebProg_Project.Data
{
    public class WebProg_ProjectContext : DbContext
    {
        public WebProg_ProjectContext (DbContextOptions<WebProg_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebProg_Project.Models.Summoner> Summoner { get; set; }

        public DbSet<WebProg_Project.Models.FreeChampionRotation> FreeChampionRotation { get; set; }

        public DbSet<WebProg_Project.Models.SummonerChampionMastery> SummonerChampionMastery { get; set; }

        public DbSet<WebProg_Project.Models.SummonerRankedLeagueDetail> SummonerRankedLeagueDetail { get; set; }
    }
}
