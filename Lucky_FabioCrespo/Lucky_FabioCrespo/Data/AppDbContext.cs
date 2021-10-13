using Lucky_FabioCrespo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucky_FabioCrespo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Agregar los modelos a utilizar Model -> Cancion
        public DbSet<Suerte> Suerte { get; set; }
    }
}
