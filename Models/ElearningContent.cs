using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class ElearningContent
{
    public long ElearningContentId { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public int? ElearningGradeId { get; set; }

    public int? ElearningCategoryId { get; set; }

    public int? ElearningSubjectId { get; set; }

    public virtual ElearningCategory? ElearningCategory { get; set; }

    public virtual ElearningGrade? ElearningGrade { get; set; }

    public virtual ElearningSubject? ElearningSubject { get; set; }
}
