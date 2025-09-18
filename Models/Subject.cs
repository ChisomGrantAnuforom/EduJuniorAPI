using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Subject
{
    public long SubjectId { get; set; }

    public long? SubjectIdLocal { get; set; }

    public string? SubjectName { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual School? School { get; set; }
}
