using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Security
{
    public long SecurityId { get; set; }

    public long? SecurityIdLocal { get; set; }

    public long? UserServerId { get; set; }

    public string? UserCategory { get; set; }

    public int? SchoolId { get; set; }

    public string? Action { get; set; }

    public string? Status { get; set; }

    public string? Time { get; set; }

    public string? Uploaded { get; set; }
}
