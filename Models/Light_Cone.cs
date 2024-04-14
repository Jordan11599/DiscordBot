namespace DiscordBot.Models;
public class Light_Cone
{
    public string id { get; set; }
    public string name { get; set; }
    public int rarity { get; set; }
    public int rank { get; set; }
    public int level { get; set; }
    public int promotion { get; set; }
    public string icon { get; set; }
    public string preview { get; set; }
    public string portrait { get; set; }
    public Path path { get; set; }
    public List<Attributes> attributes { get; set; }
    public List<Properties> properties { get; set; }

}