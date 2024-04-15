using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;

public class User
{
    public int Id { get; set; }
    public string Discord_Id { get; set; }

    public string UID { get; set; }

    public Player Player { get; set; }

    public virtual ICollection<Characters> Characters { get; set; }

}