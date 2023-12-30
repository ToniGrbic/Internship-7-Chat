using Microsoft.EntityFrameworkCore;
using System.Configuration;
using ChatApp.Data.Entities;
using Microsoft.Extensions.Configuration;
using ChatApp.Data.Entities.Models;
using System;

namespace ChatApp.Domain.Factories;

public static class DbContextFactory
{
    public static ChatAppDbContext GetChatAppDbContext()
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
            string parentDirectory = Directory.GetParent(basePath)!.FullName;

            // If the parent directory is null, break the loop to avoid an infinite loop
            if (parentDirectory == null)
            {
                throw new InvalidOperationException("Unable to find project root directory.");
            }

            basePath = parentDirectory;
        }

        return basePath;
    }
}
