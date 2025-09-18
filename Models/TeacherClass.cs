using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class TeacherClass
{
    public long TeacherClassId { get; set; }

    public long? TeacherClassIdLocal { get; set; }

    public long? TeacherId { get; set; }

    public int? ClassId { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Uploaded { get; set; }

    public int? SchoolId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual School? School { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
