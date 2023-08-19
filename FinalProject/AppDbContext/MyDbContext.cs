using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Poll> Polls { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<UserAnswers> UserAnswers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=ZFinalProject;Trusted_Connection=True; TrustServerCertificate=True");
        }
    }
}