// See https://aka.ms/new-console-template for more information

using Db;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Migrating DB");

var builder = Host.CreateApplicationBuilder(args);
builder.Services
    .AddDbContext<CresticContext>(
        options => options.UseSqlite("Data Source=crestic.db", b => b.MigrationsAssembly("Db"))
    );

var host = builder.Build();
host.Run();