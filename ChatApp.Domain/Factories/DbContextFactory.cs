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
            .SetBasePath("C:\\Users\\Toni\\source\\repos\\Internship-7-Chat\\ChatApp.Data")
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
