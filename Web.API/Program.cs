using Microsoft.Extensions.Options;
using Web.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/test-IOptions", (IOptions<AppSettings> options) => new
{
    options.Value.DbConnection,
    options.Value.AzureAiTranslatorConfiguration.Key,
    options.Value.AzureAiTranslatorConfiguration.Location,
    options.Value.AzureAiTranslatorConfiguration.TextEndpoint,
    options.Value.AzureAiTranslatorConfiguration.DocumentEndpoint
});

app.MapGet("/test-IOptionsMonitor", (IOptionsMonitor<AppSettings> options) => new
{
    options.CurrentValue.DbConnection,
    options.CurrentValue.AzureAiTranslatorConfiguration.Key,
    options.CurrentValue.AzureAiTranslatorConfiguration.Location,
    options.CurrentValue.AzureAiTranslatorConfiguration.TextEndpoint,
    options.CurrentValue.AzureAiTranslatorConfiguration.DocumentEndpoint
});

app.MapGet("/test-IOptionsSnapshot", (IOptionsSnapshot<AppSettings> options) => new
{
    options.Value.DbConnection,
    options.Value.AzureAiTranslatorConfiguration.Key,
    options.Value.AzureAiTranslatorConfiguration.Location,
    options.Value.AzureAiTranslatorConfiguration.TextEndpoint,
    options.Value.AzureAiTranslatorConfiguration.DocumentEndpoint
});

app.Run();