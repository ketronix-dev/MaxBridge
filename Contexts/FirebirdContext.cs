using FirebirdSql.EntityFrameworkCore.Firebird;
using MaxBridge.Classes;
using Microsoft.EntityFrameworkCore;


public class FirebirdContext : DbContext
{
    public DbSet<Good> Goods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseFirebird(@"Database=localhost/3060:C:\\ProgramData\\HiMarket\\data\\MAIN.FDB;User=SYSDBA;Password=masterkey;");
        }
    }
}