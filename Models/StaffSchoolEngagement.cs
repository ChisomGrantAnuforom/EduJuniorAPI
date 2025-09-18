using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class StaffSchoolEngagement
{
    public long StaffSchoolEngagementId { get; set; }

    public string? SchoolName { get; set; }

    public int? LocationId { get; set; }

    public string? LocationName { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public string? StaffName { get; set; }

    public string? PhoneNoOfSchoolContact { get; set; }

    public string? DateOfEngagement { get; set; }

    public string? SchoolEmailAddress { get; set; }

    public virtual EduJuniorStaff? EduJuniorStaff { get; set; }

    public virtual Location? Location { get; set; }
}
