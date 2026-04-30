using ApiProcessamento.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// 1. Configura o Banco de Dados SQLite (O arquivo sensores.db será criado aqui)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=sensores.db"));

builder.Services.AddControllers();

// Configurações do Swagger (Para testar a API no navegador)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 2. Garante que o banco de dados seja criado automaticamente ao iniciar
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

// Configuração do Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();