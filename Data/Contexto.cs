using Link_Estudo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Link_Estudo.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Estudo> Estudo { get; set; }
    }
}
