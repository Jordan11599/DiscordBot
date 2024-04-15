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
    public virtual ICollection<string> Rank_Icons { get; set; }
    public Path? Path { get; set; }
    public Element? Element { get; set; }
    public virtual ICollection<Skills> Skills { get; set; }
    public virtual ICollection<Skill_Trees> Skill_Trees { get; set; }
    public Light_Cone? Light_Cone { get; set; }
    public virtual ICollection<Relics> Relics { get; set; }
    public virtual ICollection<Relic_Sets> Relic_Sets { get; set; }
    public virtual ICollection<Attributes> Attributes { get; set; }
    public virtual ICollection<Additions> Additions { get; set; }
    public virtual ICollection<Properties> Properties { get; set; }

}
