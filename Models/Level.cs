using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Level
{
    public long LevelId { get; set; }

    public long? LevelIdLocal { get; set; }

    public string? LevelName { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual School? School { get; set; }
}
