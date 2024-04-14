namespace DiscordBot.Models;
public class Skill_Trees
{
    public string Id { get; set; }
    public int Level { get; set; }
    public string Anchor { get; set; }
    public int Max_Level { get; set; }
    public string Icon { get; set;}
    public string? Parent { get; set; }
}