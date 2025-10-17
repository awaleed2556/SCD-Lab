// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddDbContext<DatabaseContext>(options =>
            options.UseSqlServer("Data Source=(local);Initial Catalog=StudentDB;Integrated Security=True;Encrypt=False"));
    })
    .Build();