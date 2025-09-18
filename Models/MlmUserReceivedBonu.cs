using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MlmUserReceivedBonu
{
    public long UserReceivedBonusId { get; set; }

    public long? UserId { get; set; }

    public byte? PositionId { get; set; }

    public string? BonusReceived { get; set; }

    public string? DateReceived { get; set; }

    public virtual MlmPosition? Position { get; set; }

    public virtual EduJuniorStaff? User { get; set; }
}
