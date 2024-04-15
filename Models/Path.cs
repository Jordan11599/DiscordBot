﻿using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;
public class Path
{
    [Key]
    public int PathId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }

}