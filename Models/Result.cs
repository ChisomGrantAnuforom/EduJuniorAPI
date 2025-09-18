using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Result
{
    public long ResultId { get; set; }

    public long? ResultIdLocal { get; set; }

    public long? PupilId { get; set; }

    public long? ExamId { get; set; }

    public long? SubjectId { get; set; }

    public decimal? Score { get; set; }

    public string? DatePublished { get; set; }

    public string? PublishedBy { get; set; }

    public string? Approved { get; set; }

    public int? SchoolId { get; set; }

    public long? TermId { get; set; }

    public long? SessionId { get; set; }

    public string? Uploaded { get; set; }

    public string? TeacherRemarks { get; set; }

    public long? LevelId { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Level? Level { get; set; }

    public virtual Pupil? Pupil { get; set; }

    public virtual School? School { get; set; }

    public virtual Session? Session { get; set; }

    public virtual Subject? Subject { get; set; }

    public virtual Term? Term { get; set; }
}
