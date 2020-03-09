using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebEducationServices3.Models;

namespace WebEducationServices3.Data
{
    public class EdDbContext : DbContext
    {
        public EdDbContext (DbContextOptions<EdDbContext> options)
            : base(options)
        {
        }

        public DbSet<Major> Majors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {
            model.Entity<Student>(s => {
                s.HasIndex(x => x.StudentNumber).IsUnique();
            });
            model.Entity<Class>(c => {
                c.HasKey(x => x.Id);
                c.Property(x => x.Section).HasMaxLength(30).IsRequired();
                c.Property(x => x.Subject).HasMaxLength(30).IsRequired();

            });
        }

        public DbSet<WebEducationServices3.Models.StudentClassRel> StudentClassRel { get; set; }
    }

}
    