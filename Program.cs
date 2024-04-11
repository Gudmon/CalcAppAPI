using CalcAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using QuestPDF.Infrastructure;
using CalcAppAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

QuestPDF.Settings.License = LicenseType.Community;

builder.Services.AddScoped<IDealerPdfGenerator, DealerPdfGenerator>();
builder.Services.AddScoped<IUserPdfGenerator, UserPdfGenerator>();
builder.Services.AddScoped<IEmailSender, EmailSender>();

var db = builder.Configuration["DBConnection"];

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(db.ToString());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
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


