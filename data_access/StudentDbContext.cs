using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    public class StudentDbContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        public StudentDbContext() : base() { }
        public StudentDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>()
                .Property(st => st.FullName)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .ToTable(t => t.HasCheckConstraint("CK_Student_AverageGrade", "AverageGrade >= 2 AND AverageGrade <= 5"));

            modelBuilder.Entity<Group>()
                .Property(g => g.Name)
                .IsRequired();

            modelBuilder.Entity<Group>()
                .ToTable(t => t.HasCheckConstraint("CK_Group_StudyYear", "StudyYear >= 1 AND StudyYear <= 4"));


            // Relationships configuration 

            // Student - Group (* - 1)

            modelBuilder.Entity<Student>()
                .HasOne(st => st.Group)
                .WithMany(g => g.Students)
                .HasForeignKey(st => st.GroupId);

            modelBuilder.SeedGroups();
            modelBuilder.SeedStudents();

        }

    }
}
