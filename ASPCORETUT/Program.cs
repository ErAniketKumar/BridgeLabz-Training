using ASPCORETUT.Data;
using ASPCORETUT.Endpoints;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GameStoreContext>(options =>
options.UseSqlServer(
    builder.Configuration.GetConnectionString("GameStore")
));

builder.Services.AddScoped<GameStoreContext>();

builder.Services.AddValidation();
var app = builder.Build();
app.MapGamesEndpoints();

app.MigrateDb();

app.Run();
