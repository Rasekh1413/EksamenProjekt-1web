using EksamenProjekt_1web.Services.Interfaces;
using EksamenProjekt_1web.Services.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<ISagRepository, SagRepository>();      // Tilføj fra Rasekh
builder.Services.AddScoped<IKundeRepository, KundeRepository>();  // Tilføj fra Rasekh




var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

// Rasekh

// Medina

// det er Elizabeth 

// Tobias 

