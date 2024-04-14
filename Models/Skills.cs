using System.Xml.Linq;

namespace DiscordBot.Models;
public class Skills
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Max_Level { get; set; }
    public Element Element { get; set; }
    public string Type { get; set; }
    public string Type_Text { get; set; }
    public string Effect { get; set; }
    public string Effect_Text { get; set; }
    public string Simple_Desc { get; set; }
    public string Desc { get; set; }
    public string Icon { get; set; }

}