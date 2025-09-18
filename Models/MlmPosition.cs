using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MlmPosition
{
    public byte PositionId { get; set; }

    public string? PositionName { get; set; }

    public decimal? Share { get; set; }

    public long? ActivityCountFrom { get; set; }

    public long? ActivityCountTo { get; set; }

    public string? Bonus { get; set; }

    public virtual ICollection<MlmUserPosition> MlmUserPositions { get; set; } = new List<MlmUserPosition>();

    public virtual ICollection<MlmUserReceivedBonu> MlmUserReceivedBonus { get; set; } = new List<MlmUserReceivedBonu>();
}
