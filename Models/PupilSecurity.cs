using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PupilSecurity
{
    public long PupilSecurityId { get; set; }

    public long? PupilId { get; set; }

    public int? SchoolId { get; set; }

    public string? Status { get; set; }

    public string? DateTime { get; set; }

    public string? AuthType { get; set; }

    public virtual School? School { get; set; }
}
