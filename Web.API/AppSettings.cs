using Web.API.Configurations;

namespace Web.API;

public class AppSettings
{
    public string DbConnection { get; init; }
    public AzureAiTranslatorConfiguration AzureAiTranslatorConfiguration { get; init; }
}