using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;
public class Relics
{
    [Key]
    public int RelicsId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Set_Id { get; set; }
    public string Set_Name { get; set; }
    public int Rarity { get; set; }
    public int Level { get; set; }
    public string Icon { get; set; }
    public Main_Affix? Main_Affix { get; set; }
    public virtual ICollection<Sub_Affix> Sub_Affix { get; set; }

}