namespace DiscordBot.Models;
public class Relics
{
    public string id { get; set; }
    public string name { get; set; }

    //Look for workaround
    //public string set_id { get; set; }
    //public string set_name { get; set; }
    public int rarity { get; set; }
    public int level { get; set; }
    public string icon { get; set; }
    public Main_Affix main_affix { get; set; }
    public List<Sub_Affix> sub_affix { get; set; }

}