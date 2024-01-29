// See https://aka.ms/new-console-template for more information

public class Program
{
    public static KeyValuePair<string, object>[] settings =
    {
        new("Host", "tayou.org"),
        new("Copyright", "Copyright © 2024 Tayou<contact-web@tayou.org> - GPLv3"),

        new("GenerateSearchIndex", false),
        new("DeployGitHubPages", true),
        new("LinksUseHttps", true),
        new("Image", "./images/site-image.avif"),
        new("GitHubToken", Environment.GetEnvironmentVariable("GITHUB_TOKEN")!),
    };
    
    public static async Task<int> Main(string[] args) => 
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .AddSettings(settings)
            .DeployToGitHubPages(
                "TayouVR", 
                "PersonalWebsite", 
                Config.FromSetting<string>("GitHubToken"))
            .RunAsync();
}