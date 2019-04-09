using Microsoft.EntityFrameworkCore;
using tecweb2.webapi.Models.Entities;

namespace tecweb2.webapi.Contexts
{
    public class SqlContext : DbContext
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="options">Options.</param>
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public SqlContext()
        {
        }

        public DbSet<CareerEntity> Careers { get; set; }

        public DbSet<CareerSubjectiveEntity> CareerSubjectives { get; set; }

        public DbSet<ClassEntity> Classes { get; set; }

        public DbSet<ItemEntity> Itens { get; set; }

        public DbSet<SemesterEntity> Semesters { get; set; }

        public DbSet<SubjectiveEntity> Subjectives { get; set; }

        public DbSet<SubjectiveSemesterEntity> SubjectiveSemesters { get; set; }

        public DbSet<TeachingPlanEntity> TeachingPlans { get; set; }

        public DbSet<TeachingPlanItemEntity> TeachingPlanItens { get; set; }

        public DbSet<TeachingPlanLogEntity> TeachingPlanLogs { get; set; }

        public DbSet<UserCareerEntity> UserCareers { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<UserSubjectiveEntity> UserSubjectives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}