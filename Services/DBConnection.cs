using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using DiscordBot.Models;
public class DBConnection : DbContext
{
    public DbSet<User> User { get; set; }
    //public DbSet<Characters> Characters { get; set; }

    public string DbPath { get; }

    public DBConnection()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(@"C:\Users\Jordan\Desktop\CSharp\DiscordBot\", "CachedData.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
