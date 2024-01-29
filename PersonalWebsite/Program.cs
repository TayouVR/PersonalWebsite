// See https://aka.ms/new-console-template for more information

public class Program
{
    public static async Task<int> Main(string[] args) => await Bootstrapper.Factory.CreateWeb(args).RunAsync();
}