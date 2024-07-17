using Microsoft.EntityFrameworkCore;
using PG.Crossfit.Ranking.Infra.BancoDeDados.Contextos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AdicionarServicosApi(builder.Configuration);

builder.Configuration.AddJsonFile("appsettings.Development.json");
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<RankingContexto>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();