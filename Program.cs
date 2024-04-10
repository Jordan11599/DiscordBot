using DisCatSharp.Enums;
using DisCatSharp;
using System;
using System.Text.Json;

namespace DiscordBot;

class Program
{
    static void Main(string[] args)
    {
        MainAsync().GetAwaiter().GetResult();
    }

    static async Task MainAsync()
    {

        var text = File.ReadAllText(@"./config.json");
        var secret = JsonSerializer.Deserialize<Config>(text);

        var discord = new DiscordClient(new DiscordConfiguration()
        {
            Token = secret?.Token,
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContent
        });

        discord.MessageCreated += async (s, e) =>
        {
            if (e.Message.Content.ToLower().StartsWith("ping"))
                await e.Message.RespondAsync("pong!");

        };

        await discord.ConnectAsync();
        await Task.Delay(-1);

    }

    
}
public class Config
{
    public string Token { get; set; }

}