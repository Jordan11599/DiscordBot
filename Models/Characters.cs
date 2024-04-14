namespace DiscordBot.Models;
public class Characters
{
    public string id { get; set; }
    public string name { get; set; }
    public int rarity { get; set; }
    public int rank { get; set; }
    public int level { get; set; }
    public int promotion { get; set; }
    public string icon { get; set; }
    public string preview { get; set; }
    public List<string> rank_icons { get; set; }
    public Path path { get; set; }
    public Element element { get; set; }
    public List<Skills> skills { get; set; }
    public List<Skill_Trees> skill_trees { get; set; }
    public Light_Cone light_cone { get; set; }
    public List<Relics> relics { get; set; }
    public List<Relic_Sets> relic_sets { get; set; }
    public List<Attributes> attributes { get; set; }
    public List<Additions> additions { get; set; }
    public List<Properties> properties { get; set; }

}
