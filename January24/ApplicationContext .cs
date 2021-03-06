using January24;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<People> Peoples { get; set; } = null!;
    public DbSet<Kid> Kids { get; set; } = null!;
    public ApplicationContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();   
        //Database.Migrate();
    }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("Data Source=helloapp.db");
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=helloappdb;Trusted_Connection=True;");
    }
}