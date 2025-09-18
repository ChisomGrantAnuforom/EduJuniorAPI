using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class EduJuniorStaff
{
    public long EduJuniorStaffId { get; set; }

    public string? FirstName { get; set; }

    public string? OtherNames { get; set; }

    public string? LastName { get; set; }

    public string? Sex { get; set; }

    public string? HomeAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Verified { get; set; }

    public string? ReferralPhoneNumber { get; set; }

    public virtual ICollection<EduJuniorStaffBank> EduJuniorStaffBanks { get; set; } = new List<EduJuniorStaffBank>();

    public virtual ICollection<MlmUserPosition> MlmUserPositions { get; set; } = new List<MlmUserPosition>();

    public virtual ICollection<MlmUserReceivedBonu> MlmUserReceivedBonus { get; set; } = new List<MlmUserReceivedBonu>();

    public virtual ICollection<MlmUserReferralAccount> MlmUserReferralAccounts { get; set; } = new List<MlmUserReferralAccount>();

    public virtual ICollection<MlmUserReferral> MlmUserReferralReferrals { get; set; } = new List<MlmUserReferral>();

    public virtual ICollection<MlmUserReferral> MlmUserReferralUsers { get; set; } = new List<MlmUserReferral>();

    public virtual ICollection<PaymentRequest> PaymentRequests { get; set; } = new List<PaymentRequest>();

    public virtual ICollection<SchoolReferralAccount> SchoolReferralAccounts { get; set; } = new List<SchoolReferralAccount>();

    public virtual ICollection<SchoolReferral> SchoolReferrals { get; set; } = new List<SchoolReferral>();

    public virtual ICollection<StaffSchoolEngagement> StaffSchoolEngagements { get; set; } = new List<StaffSchoolEngagement>();
}
