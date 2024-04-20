using DisCatSharp.CommandsNext;
using DisCatSharp.Entities;
using System.Runtime.CompilerServices;

namespace DiscordBot.Util;

public class Embed
{
    public static DiscordEmbed GetCustomHelpCommandEmbed(CommandContext ctx)
    {
        var embed = new DiscordEmbedBuilder();
        embed.Color = new DiscordColor("6A0DAD");
        embed.Title = "Help Commands";
        embed.Description = "List here";
        return embed.Build();
    }

}