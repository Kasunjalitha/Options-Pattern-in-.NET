namespace Web.API.Configurations;

public class AzureAiTranslatorConfiguration
{
    public string Key { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string TextEndpoint { get; set; } = string.Empty;
    public string DocumentEndpoint { get; set; } = string.Empty;
}