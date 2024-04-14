namespace DiscordBot.Models;
public class User
{
    public string discordid { get; set; }

    public string uid { get; set; }

    public Player player { get; set; }

    public List<Characters> characters { get; set; }

}