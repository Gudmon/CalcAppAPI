using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using CalcAppAPI.Data;
using CalcAppAPI.Models.Email;
using CalcAppAPI.Services.Krpan;
using CalcAppAPI.Services.Palms;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

QuestPDF.Settings.License = LicenseType.Community;
// PALMS
builder.Services.AddScoped<IDealerPdfGenerator, DealerPdfGenerator>();
builder.Services.AddScoped<IUserPdfGenerator, UserPdfGenerator>();
builder.Services.AddScoped<IEmailSender, EmailSender>();

// KRPAN
builder.Services.AddScoped<IKrpanDealerPdfGenerator, KrpanDealerPdfGenerator>();
builder.Services.AddScoped<IKrpanUserPdfGenerator, KrpanUserPdfGenerator>();
builder.Services.AddScoped<IKrpanEmailSender, KrpanEmailSender>();

var kvUri = "https://calc-app-keyvault.vault.azure.net/";

var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
var dbSecret = await client.GetSecretAsync("DBConnection");
var blobSecret = await client.GetSecretAsync("BlobConnection");

MyOptions.BlobConnection = blobSecret.Value.Value.Trim('"');

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(dbSecret.Value.Value.Trim('"'));
});

var fromEmailAddress = await client.GetSecretAsync("FromEmailAddress");
var toEmailAddress = await client.GetSecretAsync("ToEmailAddress");
var toEmailAddressTest = await client.GetSecretAsync("ToEmailAddressTest");
var fromEmailPw = await client.GetSecretAsync("FromEmailPassword");

builder.Services.Configure<EmailOptions>(options =>
{
    options.FromEmailAddress = fromEmailAddress.Value.Value.Trim('"');
    options.ToEmailAddress = toEmailAddress.Value.Value.Trim('"');
    options.ToEmailAddressTest = toEmailAddressTest.Value.Value.Trim('"');
    options.FromEmailPw = fromEmailPw.Value.Value.Trim('"');
    options.SmtpHost = "smtp.gmail.com";
    options.SmtpPort = 587;
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

public static class MyOptions
{
    public static string BlobConnection { get; set; }
}
