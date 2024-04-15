namespace DiscordBot.Models;
public class Relic_Sets
{
    public int Relic_SetsId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public int Num { get; set; }
    public string Desc { get; set;}
    public List<Properties> Properties { get; set; }
}