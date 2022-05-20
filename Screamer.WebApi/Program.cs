using Npgsql;
using Screamer.Infrastructure.Repositories;
using Screamer.Infrastructure.Repositories.Interfaces;
using Screamer.Infrastructure.Services;
using Screamer.Infrastructure.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddEnvironmentVariables();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

builder.Services.AddTransient<NpgsqlConnection>((s) => new NpgsqlConnection(connectionString));
builder.Services.AddScoped<IExampleRepository, ExampleRepository>();
builder.Services.AddScoped<IExampleService, ExampleService>();


var app = builder.Build();
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
