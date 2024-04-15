using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;
public class Characters
{
    [Key]
    public int CharactersId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public int Rarity { get; set; }
    public int Rank { get; set; }
    public int Level { get; set; }
    public int Promotion { get; set; }
    public string Icon { get; set; }
    public string Preview { get; set; }
    public List<string> Rank_Icons { get; set; }
    public Path? Path { get; set; }
    public Element? Element { get; set; }
    public List<Skills> Skills { get; set; }
    public List<Skill_Trees> Skill_Trees { get; set; }
    public Light_Cone? Light_Cone { get; set; }
    public List<Relics> Relics { get; set; }
    public List<Relic_Sets> Relic_Sets { get; set; }
    public List<Attributes> Attributes { get; set; }
    public List<Additions> Additions { get; set; }
    public List<Properties> Properties { get; set; }

}
