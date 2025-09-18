using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class SmsTracker
{
    public long SmsTrackerId { get; set; }

    public long? SmsTrackerIdLocal { get; set; }

    public long? PupilId { get; set; }

    public int? SchoolId { get; set; }

    public string? SmsContent { get; set; }

    public string? SmsCategory { get; set; }

    public DateTime? DateSent { get; set; }

    public string? Uploaded { get; set; }

    public virtual Pupil? Pupil { get; set; }

    public virtual School? School { get; set; }
}
