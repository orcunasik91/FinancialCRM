using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.WinForm.Models.Context;
public class AppDbContext : DbContext
{
    private readonly string _connectionString;
    public AppDbContext() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public AppDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(_connectionString))
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
    public virtual DbSet<Bank> Banks { get; set; }
    public virtual DbSet<BankProcess> BankProcesses { get; set; }
    public virtual DbSet<Bill> Bills { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Spending> Spendings { get; set; }
    public virtual DbSet<User> Users { get; set; }
}