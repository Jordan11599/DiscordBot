using DisCatSharp.Enums;
using DisCatSharp;
using System;
using System.Text.Json;
using DisCatSharp.CommandsNext;
using System.Reflection;
using DisCatSharp.VoiceNext;
using DisCatSharp.Entities;


namespace DiscordBot;

class Program
{
    static void Main(string[] args)
    {

        MainAsync().GetAwaiter().GetResult();

    }

    static async Task MainAsync()
    {

        var data = File.ReadAllText(@"./config.json");
        var secret = JsonSerializer.Deserialize<Config>(data);

        var discord = new DiscordClient(new DiscordConfiguration()
        {
            Token = secret?.Token,
            TokenType = TokenType.Bot,
            Intents = DiscordIntents.AllUnprivileged | DiscordIntents.MessageContent
        });

        discord.UseVoiceNext();

        var commands = discord.UseCommandsNext(new CommandsNextConfiguration()
        {
            StringPrefixes = new List<string> { ";" }
        });

        commands.RegisterCommands(Assembly.GetExecutingAssembly());


        await discord.ConnectAsync();
        await Task.Delay(-1);

    }


    
}