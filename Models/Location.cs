using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public string? LocationName { get; set; }

    public int? StateId { get; set; }

    public virtual ICollection<StaffSchoolEngagement> StaffSchoolEngagements { get; set; } = new List<StaffSchoolEngagement>();

    public virtual State? State { get; set; }
}
