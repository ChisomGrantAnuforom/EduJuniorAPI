using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MlmUserReferralAccount
{
    public long UserReferralAccountId { get; set; }

    public long? SomicleStaffId { get; set; }

    public long? TotalNoOfSchoolsReferredByReferrals { get; set; }

    public long? TotalNoOfStudentsReferredByReferrals { get; set; }

    public long? NoOfReferralReferredStudentsUncleared { get; set; }

    public decimal? AmountToBeCleared { get; set; }

    public decimal? TotalAmountCleared { get; set; }

    public string? DateLastCleared { get; set; }

    public string? DateOfLastTransaction { get; set; }

    public virtual EduJuniorStaff? SomicleStaff { get; set; }
}
