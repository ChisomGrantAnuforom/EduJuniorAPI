using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Term
{
    public long TermId { get; set; }

    public long? TermIdLocal { get; set; }

    public string? TermName { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual School? School { get; set; }

    public virtual ICollection<SchoolFee> SchoolFees { get; set; } = new List<SchoolFee>();
}
