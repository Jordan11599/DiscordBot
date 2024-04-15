using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;
public class Avatar
{
    [Key]
    public int AvatarId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }

}