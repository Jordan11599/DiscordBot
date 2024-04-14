namespace DiscordBot.Models;
public class Skill_Trees
{
    public string id { get; set; }
    public int level { get; set; }
    public string anchor { get; set; }
    public int max_level { get; set; }
    public string icon { get; set;}
    public string parent { get; set; }
}