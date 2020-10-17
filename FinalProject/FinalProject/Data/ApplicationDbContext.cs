using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           


            builder.Entity<UserSkills>().HasKey(x => new { x.UserId, x.InterpersonalSkillId, x.TechnicalSkillId });
            builder.Entity<UserSkills>()
                .HasOne<User>(u => u.User)
                .WithMany(ut => ut.UserSkills)
                .HasForeignKey(u => u.UserId);

            builder.Entity<UserSkills>()
               .HasOne<TechnicalSkill>(t => t.TechnicalSkill)
               .WithMany(ut => ut.UserSkills)
               .HasForeignKey(t => t.TechnicalSkillId);

            builder.Entity<UserSkills>()
             .HasOne<InterpersonalSkill>(i => i.InterpersonalSkill)
             .WithMany(ut => ut.UserSkills)
             .HasForeignKey(i => i.InterpersonalSkillId);

            builder.Entity<UserUniversity>().HasKey(x => new { x.UserId, x.UniversityId,x.DegreeId});
            builder.Entity<UserUniversity>()
                .HasOne<User>(u => u.User)
                .WithMany(un => un.UserUniversity)
                .HasForeignKey(u => u.UserId);

            builder.Entity<UserUniversity>()
               .HasOne<University>(u => u.University)
               .WithMany(un => un.UserUniversity)
               .HasForeignKey(u => u.UniversityId);

            builder.Entity<UserUniversity>()
              .HasOne<Degree>(d=>d.Degree)
              .WithMany(un => un.UserUniversity)
              .HasForeignKey(d=>d.DegreeId);

            builder.Entity<Project>()
                .HasOne<User>(u => u.User)
                .WithMany(p => p.Project)
                .HasForeignKey(u => u.UserId);
        }
        public DbSet<User> Userss { get; set; }
        public DbSet<InterpersonalSkill> InterpersonalSkills { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        public DbSet<University> Universites { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<UserUniversity> UserUniversities { get; set; }
        public DbSet<Project> Projects { get; set; }

    }
}
