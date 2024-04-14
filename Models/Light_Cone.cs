namespace DiscordBot.Models;
public class Light_Cone
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Rarity { get; set; }
    public int Rank { get; set; }
    public int Level { get; set; }
    public int Promotion { get; set; }
    public string Icon { get; set; }
    public string Preview { get; set; }
    public string Portrait { get; set; }
    public Path Path { get; set; }
    public List<Attributes> Attributes { get; set; }
    public List<Properties> Properties { get; set; }

}