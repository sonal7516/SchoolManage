using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolManage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManage.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {

        }

        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Year> Year { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<StudentSubject> StudentSubject { get; set; }
        public virtual DbSet<TeacherSubject> TeacherSubject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentSubject>().HasKey(t => new { t.ApplicationUserID, t.SubjectId });
            modelBuilder.Entity<TeacherSubject>().HasKey(t => new { t.ApplicationUserID, t.SubjectId });
        }
    }
}
