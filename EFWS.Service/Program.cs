using EFWS.Data;
using EFWS.Service;
using Microsoft.EntityFrameworkCore;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((ctx,services) =>
    {
      services.AddDbContext<LibraryContext>(options
        => options.UseSqlServer(ctx.Configuration.GetConnectionString("LibraryConnection")));
      services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();