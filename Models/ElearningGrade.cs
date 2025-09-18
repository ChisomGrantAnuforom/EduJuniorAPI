using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class ElearningGrade
{
    public int ElearningGradeId { get; set; }

    public string? GradeName { get; set; }

    public virtual ICollection<ElearningContent> ElearningContents { get; set; } = new List<ElearningContent>();

    public virtual ICollection<ElearningSubject> ElearningSubjects { get; set; } = new List<ElearningSubject>();
}
