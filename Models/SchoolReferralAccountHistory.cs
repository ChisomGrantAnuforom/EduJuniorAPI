using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class SchoolReferralAccountHistory
{
    public long SchoolReferralAccountHistoryId { get; set; }

    public long? SchoolReferralAccountId { get; set; }

    public string? DateCleared { get; set; }

    public decimal? AmountCleared { get; set; }

    public int? NoOfStudentsCleared { get; set; }

    public virtual SchoolReferralAccount? SchoolReferralAccount { get; set; }
}
