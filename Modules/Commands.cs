﻿using DisCatSharp.CommandsNext;
using DisCatSharp.CommandsNext.Attributes;
using System.ComponentModel.Design;
using DiscordBot.Util;
using Microsoft.VisualBasic;
using DisCatSharp.VoiceNext;
using DisCatSharp.Entities;
using DisCatSharp.Common.Utilities;
using DisCatSharp.VoiceNext.EventArgs;
using System.Diagnostics;


namespace DiscordBot.Modules;


public class Commands : BaseCommandModule
{

    [Command("test")]
    public async Task Help(CommandContext ctx)
    {
        await ctx.RespondAsync(Embed.GetCustomHelpCommandEmbed(ctx));
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