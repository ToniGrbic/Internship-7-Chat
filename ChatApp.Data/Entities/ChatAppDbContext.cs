using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

using ChatApp.Data.Entities.Models;
using ChatApp.Data.Seeds;
namespace ChatApp.Data.Entities;

public class ChatAppDbContext : DbContext
{
    public ChatAppDbContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Groups> Groups => Set<Groups>();
    public DbSet<Users> Users => Set<Users>();
    public DbSet<GroupUsers> GroupUsers => Set<GroupUsers>();
    public DbSet<GroupMessages> GroupMessages => Set<GroupMessages>();
    public DbSet<PrivateMessages> PrivateMessages => Set<PrivateMessages>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Users>()
            .HasIndex(u => u.Email)
            .IsUnique();
        //GroupUsers -> many to many
        modelBuilder.Entity<GroupUsers>()
            .HasKey(gu => new { gu.GroupId, gu.UserId });
        
        modelBuilder.Entity<GroupUsers>()
            .HasOne(gu => gu.Group)
            .WithMany(g => g.GroupUsers)
            .HasForeignKey(gu => gu.GroupId);
        
        modelBuilder.Entity<GroupUsers>()
            .HasOne(gu => gu.User)
            .WithMany(u => u.GroupUsers)
            .HasForeignKey(gu => gu.UserId);
        
        //GroupMessages -> many to many
        modelBuilder.Entity<GroupMessages>()
            .HasOne(gm => gm.Group)
            .WithMany(g => g.GroupMessages)
            .HasForeignKey(gm => gm.GroupID);

        modelBuilder.Entity<GroupMessages>()
            .HasOne(gm => gm.SenderUser)
            .WithMany(u => u.GroupMessages)
            .HasForeignKey(gm => gm.SenderUserID);

        //PrivateMessages - Users -> many to one
        modelBuilder.Entity<PrivateMessages>()
            .HasOne(pm => pm.SenderUser)
            .WithMany(u => u.PrivateMessagesSent)
            .HasForeignKey(pm => pm.SenderUserID);

        modelBuilder.Entity<PrivateMessages>()
            .HasOne(pm => pm.ReceiverUser)
            .WithMany(u => u.PrivateMessagesReceived)
            .HasForeignKey(pm => pm.ReceiverUserID);

        DatabaseSeeder.Seed(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }
}

public class ChatAppDbContextFactory : IDesignTimeDbContextFactory<ChatAppDbContext>
{
    public ChatAppDbContext CreateDbContext(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(FindProjectRoot(AppContext.BaseDirectory))
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

    public static string FindProjectRoot(string basePath)
    {
        // Move up the directory hierarchy until you find the project root
        while (!File.Exists(Path.Combine(basePath, "App.config")))
        {
            string parentDirectory = Directory.GetParent(basePath)!.FullName 
                ?? throw new InvalidOperationException("Unable to find project root directory.");
            basePath = parentDirectory;
        }

        return basePath;
    }
}