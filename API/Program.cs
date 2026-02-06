using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using CalcAppAPI.Application.Interfaces;
using CalcAppAPI.Application.Queries;
using CalcAppAPI.Application.Services.Palms.Email;
using CalcAppAPI.Application.Services.Pdf;
using CalcAppAPI.Application.Services.Pdf.Generators;
using CalcAppAPI.Application.Services.Pdf.Layout;
using CalcAppAPI.Infrastructure;
using Microsoft.AspNetCore.Diagnostics;
using QuestPDF.Infrastructure;
using Serilog;
using System;
using System.Text.Json.Serialization;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

QuestPDF.Settings.License = LicenseType.Community;
builder.Host.UseSerilog();

builder.Services.AddApplicationInsightsTelemetry();

builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPalmsQueryHandler, PalmsQueryHandler>();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", p =>
        p.WithOrigins("http://localhost:4200")
         .AllowAnyHeader()
         .AllowAnyMethod());
});

await builder.Services.AddInfrastructureAsync(builder.Configuration);

builder.Services.AddScoped<IBlobStorageService, BlobStorageService>();

builder.Services.AddScoped<IDealerPdfLayout, DealerPdfLayout>();
builder.Services.AddScoped<IUserPdfLayout, UserPdfLayout>();

builder.Services.AddScoped<IDealerPdfGenerator, DealerPdfGenerator>();
builder.Services.AddScoped<IUserPdfGenerator, UserPdfGenerator>();

builder.Services.AddScoped<IEmailSender, EmailSender>();


var app = builder.Build();

app.UseSerilogRequestLogging();
app.UseMiddleware<GlobalExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();