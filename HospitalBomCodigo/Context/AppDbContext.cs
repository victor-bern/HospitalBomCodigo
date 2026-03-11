using HospitalBomCodigo.Models;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>()
                .HasKey(x => x.Id);

            var examFaker = new Bogus.Faker<Exam>()
                .RuleFor(x => x.Id, f => Guid.NewGuid())
                .RuleFor(x => x.Type, f => f.PickRandom(new[] { "Exame de Sangue", "Raio-X", "MRI" }))
                .RuleFor(x => x.Description, f => f.Lorem.Sentence())
                .RuleFor(x => x.Status, f => ExamStatus.Pending);


            var exams = examFaker.Generate(100);

            modelBuilder.Entity<Exam>()
                .HasData(exams);
        }


        public DbSet<Exam> Exams { get; set; }
    }
}
