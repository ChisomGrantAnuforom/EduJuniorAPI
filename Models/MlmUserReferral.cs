using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MlmUserReferral
{
    public long UserReferralId { get; set; }

    public long? UserId { get; set; }

    public long? ReferralId { get; set; }

    public string? DateReferred { get; set; }

    public virtual EduJuniorStaff? Referral { get; set; }

    public virtual EduJuniorStaff? User { get; set; }
}
