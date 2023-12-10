using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGenNewtonsoftSupport();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options => options.AddPolicy("ÔÊÐí¿çÓò", policy => policy.AllowAnyOrigin()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.UseSwagger();
string version = "v1";
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint($"/swagger/{version}/swagger.json", version);
    c.EnableDeepLinking();
    c.EnableFilter();
});
app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod()
           .SetPreflightMaxAge(TimeSpan.FromSeconds(2000000));
});
app.MapControllers();

app.Run();
