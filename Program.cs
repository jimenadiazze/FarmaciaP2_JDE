using Microsoft.EntityFrameworkCore;
using Farmacia.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// --- NUEVO: Configuración para la API y Swagger ---
builder.Services.AddControllers(); // Esto le dice a tu app que también maneja APIs
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// --------------------------------------------------

builder.Services.AddDbContext<FarmaciaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{
    // --- NUEVO: Habilitar la página azul de Swagger ---
    app.UseSwagger();
    app.UseSwaggerUI();
    // --------------------------------------------------
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// --- NUEVO: Habilitar las rutas de tu controlador API ---
app.MapControllers();
// --------------------------------------------------------

app.Run();