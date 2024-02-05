using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<QuizEntity> Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuizEntity>()
                 .HasOne(q => q.User)
                 .WithOne(u => u.Quiz)
                 .HasForeignKey<QuizEntity>(q => q.UserId);

        }
    }
}
