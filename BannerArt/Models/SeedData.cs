using Microsoft.EntityFrameworkCore;
using System;
using BannerArt.Data;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace BannerArt.Models
{
    public class SeedData               //Seeddata in case of no existing records
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BannerArtContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BannerArtContext>>()))
            {
                
                if (context.Flag.Any())
                {
                    return;   // DB has been seeded
                }

                context.Flag.AddRange(
                    new Flag
                    {
                        FlagName = "Pirates",
                        DesignerName = "Roy",
                        Material= "Cotton",
                        Size = "Medium",
                        ReleaseDate= DateTime.Parse("1984-3-13"),
                        Price=34.88M,
                        CustomerReview=3,
                        Rating="Average",
                 
                    },

                    new Flag
                    {
                        FlagName = "Bingo",
                        DesignerName = "Mills",
                        Material = "Silk",
                        Size = "Large",
                        ReleaseDate = DateTime.Parse("1997-5-23"),
                        Price = 45M,
                        CustomerReview = 5,
                        Rating = "Excellent",
                    },

                    new Flag
                    {
                        FlagName = "Racer",
                        DesignerName = "Charlie",
                        Material = "Polyester",
                        Size = "Small",
                        ReleaseDate = DateTime.Parse("2001-3-21"),
                        Price = 56M,
                        CustomerReview = 3,
                        Rating = "Average",
                    },

                    new Flag
                    {
                        FlagName = "Rango",
                        DesignerName = "Leo",
                        Material = "Cotton",
                        Size = "Large",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Price = 21M,
                        CustomerReview = 2,
                        Rating = "Average",
                    },
                    new Flag
                    {
                        FlagName = "CoolBreeze",
                        DesignerName = "Lilly",
                        Material = "Silk",
                        Size = "Small",
                        ReleaseDate = DateTime.Parse("2003-4-13"),
                        Price = 54.76M,
                        CustomerReview = 4,
                        Rating = "Excellent",
                    },
                    new Flag
                    {
                        FlagName = "RicknMorty",
                        DesignerName = "Rick",
                        Material = "Alienfabric",
                        Size = "Large",
                        ReleaseDate = DateTime.Parse("2006-2-21"),
                        Price = 34.88M,
                        CustomerReview = 5,
                        Rating = "Excellent",
                    },
                    new Flag
                    {
                        FlagName = "Popeye",
                        DesignerName = "Chris",
                        Material = "Cotton",
                        Size = "Medium",
                        ReleaseDate = DateTime.Parse("1994-3-13"),
                        Price = 34.88M,
                        CustomerReview = 3,
                        Rating = "Average",
                    },
                    new Flag
                    {
                        FlagName = "Powerpuff",
                        DesignerName = "Dexter",
                        Material = "Polyster",
                        Size = "Medium",
                        ReleaseDate = DateTime.Parse("1976-3-13"),
                        Price = 34.88M,
                        CustomerReview = 4,
                        Rating = "Excellent",
                    },
                    new Flag
                    {
                        FlagName = "EddEdnEddy",
                        DesignerName = "Ed",
                        Material = "Cotton",
                        Size = "Small",
                        ReleaseDate = DateTime.Parse("2013-3-23"),
                        Price = 42M,
                        CustomerReview = 4,
                        Rating = "Excellent",
                    },
                    new Flag
                    {
                        FlagName = "DextersLab",
                        DesignerName = "Manny",
                        Material = "Cotton",
                        Size = "Large",
                        ReleaseDate = DateTime.Parse("2000-5-30"),
                        Price = 36M,
                        CustomerReview = 3.6,
                        Rating = "Average",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
