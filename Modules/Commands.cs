using DisCatSharp.CommandsNext;
using DisCatSharp.CommandsNext.Attributes;
using System.ComponentModel.Design;
using DiscordBot.Util;
using Microsoft.VisualBasic;
using DisCatSharp.VoiceNext;
using DisCatSharp.Entities;
using DisCatSharp.Common.Utilities;
using DisCatSharp.VoiceNext.EventArgs;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json;
using Utils.API;
using DiscordBot.Models;


namespace DiscordBot.Modules;


public class Commands : BaseCommandModule
{
    private DBConnection _connection;
    public Commands(DBConnection DBConnection){

        _connection = DBConnection;
        
    }

    


    [Command("getdata")]
    public async Task getdata(CommandContext ctx)
    {
        
        await ctx.RespondAsync("a");
        //await ctx.RespondAsync(Embed.GetCustomHelpCommandEmbed(ctx));
    }

    [Command("register")]
    public async Task Registered(CommandContext ctx, int UID)
    {
        var user = await Utils.API.Initializing.CallAPI(UID);
        try
        {
            _connection.User.Add(user);
        } catch (Exception ex)
        {
            Console.WriteLine(ex);
            // "The instance of entity type 'Element' cannot be tracked because another instance
            // with the same key value for {'Id'} is already being tracked. When attaching existing
            // entities, ensure that only one entity instance with a given key value is attached.
            // Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the conflicting
            // key values."}
            //Tomorrows issue!

        }

        //var test = _connection.User.First();


        await ctx.RespondAsync(_connection.User.First().Player.Nickname);
        
        
    }

    
    [Command("characters"), Aliases("character")]
    public async Task ttt(CommandContext ctx)
    {
        await ctx.RespondAsync($"This is a test");
        //Todo
        //Check DB for UID based on Discord User PRIMARY KEY
        //if not exists, Store UID into DB
        //await Utils.API.Initializing.CallAPI(UID);
    }

    [Command("join")]
    public async Task StartCommand(CommandContext ctx, DiscordChannel channel = null)
    {
        channel ??= ctx.Member.VoiceState?.Channel;
        var connection = await channel.ConnectAsync();

        Directory.CreateDirectory("Output");
        connection.VoiceReceived += VoiceReceiveHandler;
    }

    [Command("stop")]
    public Task StopCommand(CommandContext ctx)
    {
        var vnext = ctx.Client.GetVoiceNext();

        var connection = vnext.GetConnection(ctx.Guild);
        connection.VoiceReceived -= VoiceReceiveHandler;
        connection.Dispose();

        return Task.CompletedTask;
    }

    private async Task VoiceReceiveHandler(VoiceNextConnection connection, VoiceReceiveEventArgs args)
    {
        var fileName = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        var ffmpeg = Process.Start(new ProcessStartInfo
        {
            FileName = "ffmpeg",
            Arguments = $@"-ac 2 -f s16le -ar 48000 -i pipe:0 -ac 2 -ar 44100 Output/{fileName}.wav",
            RedirectStandardInput = true
        });

        await ffmpeg.StandardInput.BaseStream.WriteAsync(args.PcmData);
        ffmpeg.Dispose();
    }

}