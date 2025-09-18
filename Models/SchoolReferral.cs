using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class SchoolReferral
{
    public long SchoolReferralId { get; set; }

    public int? SchoolId { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public string? DateOfReferral { get; set; }

    public string? UsedRegKey { get; set; }

    public virtual EduJuniorStaff? EduJuniorStaff { get; set; }

    public virtual School? School { get; set; }
}
