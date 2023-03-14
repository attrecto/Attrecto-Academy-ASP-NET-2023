using Academy_2023.Data;
using Academy_2023.Helpers;
using Academy_2023.Repositories;
using Academy_2023.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserRepository, UserRepository>();                      // többnyire a service és repo layerek scoped élettartammal szerepelnek
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>                      // ez elterjedt db context konfiguráció
    options.UseSqlite(builder.Configuration.GetConnectionString("Default")));       // rövidítés connectionString elérésre, de mûködne section-ön keresztül is

var tmp = builder.Configuration["Logging:LogLevel:Default"];                        // csak value-t a section végén
var tmp2 = builder.Configuration.GetRequiredSection("Logging:LogLevel");            // serction elérés

builder.Services.Configure<LogLevelHelper>(tmp2);                                   // a configure section-t vár

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
