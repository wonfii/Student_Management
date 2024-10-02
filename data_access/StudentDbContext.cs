using data_access.Entities;
using data_access.Helpers;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
                                            Initial Catalog=StudentDb;
                                            Integrated Security=True;
                                            Connect Timeout=30;
                                            Encrypt=False;
                                            Trust Server Certificate=False;
                                            Application Intent=ReadWrite;
                                            Multi Subnet Failover=False");
        }

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
