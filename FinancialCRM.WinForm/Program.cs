using FinancialCRM.WinForm.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FinancialCRM.WinForm;
internal static class Program
{
    [STAThread]
    static void Main()
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json",optional:false, reloadOnChange:true)
            .Build();
        var connString = configuration.GetConnectionString("SqlConnection");
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer(connString);
        using var context = new AppDbContext(optionsBuilder.Options);

        ApplicationConfiguration.Initialize();
        Application.Run(new FormDashboard(context));
    }
}