using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Exam
{
    public long ExamId { get; set; }

    public long? ExamIdLocal { get; set; }

    public string? ExamName { get; set; }

    public int? SchoolId { get; set; }

    public string? OverallScore { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual School? School { get; set; }
}
