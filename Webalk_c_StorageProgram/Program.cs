using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adatb�zis kapcsolat karakterl�nca
var connectionString = builder.Configuration.GetConnectionString("RaktarAlkalmazasDB");

// Add services to the container.
builder.Services.AddRazorPages();

// Regisztr�ljuk a DbContext-et az Entity Framework sz�m�ra
builder.Services.AddDbContext<DbContext>(options =>
    options.UseOracle(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
