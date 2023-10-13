using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BannerArt.Models;

namespace BannerArt.Data
{
    public class BannerArtContext : DbContext
    {
        public BannerArtContext (DbContextOptions<BannerArtContext> options)
            : base(options)
        {
        }

        public DbSet<BannerArt.Models.Flag> Flag { get; set; }
    }
}
