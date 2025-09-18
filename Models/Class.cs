using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public int? ClassIdLocal { get; set; }

    public string? ClassName { get; set; }

    public long? LevelId { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();

    public virtual School? School { get; set; }

    public virtual ICollection<TeacherClass> TeacherClasses { get; set; } = new List<TeacherClass>();
}
