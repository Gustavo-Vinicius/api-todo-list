using Microsoft.Extensions.Options;
using TaskManager.API.Data.Configuracoes;
using TaskManager.API.Data.Repositories;
using TaskManager.API.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DataBaseConfig>(builder.Configuration.GetSection(nameof(DataBaseConfig)));
builder.Services.AddSingleton<IDataBaseConfig>(sp => sp.GetRequiredService<IOptions<DataBaseConfig>>().Value);
builder.Services.AddSingleton<ITarefasRepository, TarefasRepository>();
builder.Services.AddSingleton<ITarefaService, TarefaService>();

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
