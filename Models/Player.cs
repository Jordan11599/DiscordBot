namespace DiscordBot.Models;
public class Player {
    public int Id { get; set; }
    public string UID { get; set; }
    public string Nickname { get; set; }
    public int Level { get; set; }
    public int World_Level { get; set; }
    public int Friend_Count { get; set; }
    public Avatar Avatar { get; set;}
    public string Signature { get; set; }
    public bool Is_Display { get; set; }
    public Space_Info Space_Info { get; set; }

}