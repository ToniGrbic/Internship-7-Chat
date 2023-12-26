using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ChatApp.Data.Entities.Models;
//using ChatApp.Data.Seeds;

namespace ChatApp.Data.Entities;

public class ChatAppDbContext : DbContext
{
    public ChatAppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Groups> Groups => Set<Groups>();
    public DbSet<Users> Users => Set<Users>();
    public DbSet<GroupUsers> GroupUsers => Set<GroupUsers>();
    public DbSet<GroupMessages> GroupMessages => Set<GroupMessages>();
    public DbSet<PrivateMessages> PrivateMesseges => Set<PrivateMessages>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //DatabaseSeeder.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}

public class TodoAppDbContextFactory : IDesignTimeDbContextFactory<ChatAppDbContext>
{
    public ChatAppDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddXmlFile("App.config")
            .Build();

        config.Providers
            .First()
            .TryGet("connectionStrings:add:ChatApp:connectionString", out var connectionString);

        var options = new DbContextOptionsBuilder<ChatAppDbContext>()
            .UseNpgsql(connectionString)
            .Options;

        return new ChatAppDbContext(options);
    }
}