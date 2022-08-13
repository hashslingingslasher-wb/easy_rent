using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyRent.Models;

    public class EasyRentDataContext : DbContext
    {
        public EasyRentDataContext (DbContextOptions<EasyRentDataContext> options)
            : base(options)
        {
        }

        public DbSet<EasyRent.Models.EasyRentData> EasyRent { get; set; } = default!;
    }
