using System.Xml.Linq;

namespace DiscordBot.Models;
public class Skills
{
    public string id { get; set; }
    public string name { get; set; }
    public int level { get; set; }
    public int max_level { get; set; }
    public Element element { get; set; }
    public string type { get; set; }
    public string type_text { get; set; }
    public string effect { get; set; }
    public string effect_text { get; set; }
    public string simple_desc { get; set; }
    public string desc { get; set; }
    public string icon { get; set; }

}