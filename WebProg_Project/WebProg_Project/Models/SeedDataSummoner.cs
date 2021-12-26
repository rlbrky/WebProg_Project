using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebProg_Project.Data;
using System;
using System.Linq;

namespace WebProg_Project.Models
{
    public static class SeedDataSummoner
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebProg_ProjectContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<WebProg_ProjectContext>>()))
            {
                // Look for any summoners
                if (context.Summoner.Any())
                {
                    return; // DB has been seeded
                }

                context.Summoner.AddRange(
                    new Summoner
                    {
                        //Id = "4FElUEm8R_zf4CxTTZyKKMSs8rUEmZBySfduPWVP19tuBQ",
                        //AccountId = "mACiCUShtXyCLXv6s8SH8pmjyxKolDgqC00PZDbbYxgB-so",
                        //PuuId = "VI4hvF05YoUiWu92R-njLaJfS1m5ZWs-Pgt4-clVZSRLwu7YIrDEQW_wPmrjN3fyNdjz8U7sKO2jgg",
                        Name = "pistipist",
                        ProfileIconId = 1386,
                        RevisionDate = Convert.ToDateTime(1640381656000),
                        SummonerLevel = 245
                    },

                    new Summoner
                    {
                        //Id = "aVR0HD9zmWqza1X1amRtDjrFpOYpicGylDjV6qUDONdY1g",
                        //AccountId = "8VZzvytuZM30yJUgM19Wgp5AiKfWuIyyy2zlWf2cMyE7-OQ",
                        //PuuId = "9MnqcW4RzyiXLcTlWFidAFTd-nLmJCS8M-TfLIvvamLNy2aOoesDy-pBCJMVl2hoAQG_OhRTrkMSJA",
                        Name = "Obskurität",
                        ProfileIconId = 4631,
                        RevisionDate = Convert.ToDateTime(1640383826000),
                        SummonerLevel = 273
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
