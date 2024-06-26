﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DiscordBot.Models;

public class Element
{
    [Key]
    public int ElementId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Icon { get; set; }

}