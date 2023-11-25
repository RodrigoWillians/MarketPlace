using MarketPlace.DBContext;
using MarketPlace.Repository;
using MarketPlace.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MarketContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("Conexao"),
        new MySqlServerVersion(new Version(8, 0, 33)) 
    )
);

builder.Services.AddScoped<IBaseRepository, BaseRepository>();
builder.Services.AddScoped<CarrinhoRepository>();
builder.Services.AddScoped<CategoriaRepository>();
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<EnderecoRepository>();
builder.Services.AddScoped<ItemCarrinhoRepository>();
builder.Services.AddScoped<ProdutoRepository>();
builder.Services.AddScoped<VendedorRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
