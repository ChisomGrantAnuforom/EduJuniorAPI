using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class ElearningSubject
{
    public int ElearningSubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int? ElearningGradeId { get; set; }

    public virtual ICollection<ElearningContent> ElearningContents { get; set; } = new List<ElearningContent>();

    public virtual ElearningGrade? ElearningGrade { get; set; }
}
