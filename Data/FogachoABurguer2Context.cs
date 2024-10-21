using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FogachoABurguer2.Models;

    public class FogachoABurguer2Context : DbContext
    {
        public FogachoABurguer2Context (DbContextOptions<FogachoABurguer2Context> options)
            : base(options)
        {
        }

        public DbSet<FogachoABurguer2.Models.Burguer> Burguer { get; set; } = default!;
    }
