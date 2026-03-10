using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalBomCodigo.Context
{
    public class AppDbContext(DbContextOptions opt) : DbContext(opt)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HospitalBomCodigo.db");
        }
    }
}
