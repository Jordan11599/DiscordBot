namespace DiscordBot.Models;
public class Player { 
    
    public string uid { get; set; }
    public string nickname { get; set; }
    public int level { get; set; }
    public int world_level { get; set; }
    public int friend_count { get; set; }
    public Avatar avatar { get; set;}
    public string signature { get; set; }
    public bool is_display { get; set; }
    public Space_Info space_info { get; set; }

}