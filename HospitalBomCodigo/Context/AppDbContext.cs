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

            var patientsFaker = new Bogus.Faker<Patient>("pt_BR")
                .RuleFor(x => x.Id, f => Guid.NewGuid())
                .RuleFor(x => x.Name, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName())
                .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(x => x.Document, f => f.Random.ReplaceNumbers("###.###.###-##"))
                .Generate(30);

            modelBuilder.Entity<Patient>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Patient>()
                .HasData(patientsFaker);

            var patientsId = patientsFaker.Select(x => x.Id).ToArray();

            var examFaker = new Bogus.Faker<Exam>()
                .RuleFor(x => x.Id, f => Guid.NewGuid())
                .RuleFor(x => x.PatientId, f => f.PickRandom(patientsId))
                .RuleFor(x => x.Type, f => f.PickRandom(new[] { "Exame de Sangue", "Raio-X", "MRI" }))
                .RuleFor(x => x.Description, f => f.Lorem.Sentence())
                .RuleFor(x => x.Status, f => ExamStatus.Pending);


            var exams = examFaker.Generate(100);

            modelBuilder.Entity<Exam>()
                .HasData(exams);
        }


        public DbSet<Exam> Exams { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
