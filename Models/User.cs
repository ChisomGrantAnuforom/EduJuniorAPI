using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class User
{
    public long UserId { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? OtherNames { get; set; }

    public string? Sex { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Email { get; set; }

    public string? PhoneNo { get; set; }

    public string? Password { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateLastUpdated { get; set; }

    public string? Status { get; set; }

    public string? ProfilePicture { get; set; }

    public long? SiteVisitCount { get; set; }

    public string? AreaOfInterest { get; set; }

    public string? SignalrConnId { get; set; }

    public int? UserCategoryId { get; set; }

    public int? PhoneNoOtp { get; set; }

    public DateTime? PhoneNoOtpExpiration { get; set; }

    public string? Verified { get; set; }

    public virtual ICollection<NewsComment> NewsComments { get; set; } = new List<NewsComment>();

    public virtual ICollection<NewsLike> NewsLikes { get; set; } = new List<NewsLike>();

    public virtual UserCategory? UserCategory { get; set; }
}
