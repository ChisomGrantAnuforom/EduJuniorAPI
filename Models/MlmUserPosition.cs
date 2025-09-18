using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MlmUserPosition
{
    public long UserPositionId { get; set; }

    public long? UserId { get; set; }

    public byte? PositionId { get; set; }

    public long? CurrentActivityCount { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public long? ReferralUserId { get; set; }

    public virtual MlmPosition? Position { get; set; }

    public virtual EduJuniorStaff? User { get; set; }
}
