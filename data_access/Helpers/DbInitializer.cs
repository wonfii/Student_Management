using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Helpers
{
    public static class DbInitializer
    {
        public static void SeedGroups(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Name = "Group A", StudyYear = 1 },
                new Group { Id = 2, Name = "Group B", StudyYear = 2 },
                new Group { Id = 3, Name = "Group C", StudyYear = 3 },
                new Group { Id = 4, Name = "Group D", StudyYear = 2 }
            );
        }

        public static void SeedStudents(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, FullName = "Alice Smith", StudyField = "Computer Science", AverageGrade = 4.5M, GroupId = 1 },
                new Student { Id = 2, FullName = "John Doe", StudyField = "Computer Science", AverageGrade = 3.9M, GroupId = 1 },
                new Student { Id = 3, FullName = "Emily Clark", StudyField = "Mechanical Engineering", AverageGrade = 4.1M, GroupId = 2 },
                new Student { Id = 4, FullName = "Michael Johnson", StudyField = "Mechanical Engineering", AverageGrade = 3.7M, GroupId = 2 },
                new Student { Id = 5, FullName = "Sophia Williams", StudyField = "Electrical Engineering", AverageGrade = 4.3M, GroupId = 3 },
                new Student { Id = 6, FullName = "Liam Brown", StudyField = "Physics", AverageGrade = 4.0M, GroupId = 4 },
                new Student { Id = 7, FullName = "Olivia Davis", StudyField = "Physics", AverageGrade = 3.8M, GroupId = 4 }
            );
        }
    }
}
