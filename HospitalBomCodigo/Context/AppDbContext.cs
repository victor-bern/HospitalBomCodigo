using HospitalBomCodigo.Models;
using Microsoft.EntityFrameworkCore;

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
            string[] tiposExames = {
                "Hemograma Completo",
                "Glicose em Jejum",
                "Colesterol Total e Frações",
                "Creatinina (Função Renal)",
                "Transaminase Oxalacética (TGO)",
                "Transaminase Pirúvica (TGP)",
                "Ureia",
                "Ácido Úrico",
                "TSH (Hormônio Tireoestimulante)",
                "Vitamina D (25-hidroxivitamina D)",
                "Vitamina B12",
                "Exame de Urina (EAS)",
                "Urocultura com Antibiograma",
                "Exame de Fezes (EPF)",
                "Raio-X de Tórax",
                "Eletrocardiograma (ECG)",
                "Proteína C Reativa (PCR)",
                "Tempo de Protrombina (TAP)",
                "Hemoglobina Glicada",
                "Beta HCG (Teste de Gravidez)"
            };


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
                .RuleFor(x => x.Type, f => f.PickRandom(tiposExames))
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
