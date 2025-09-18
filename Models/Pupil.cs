using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Pupil
{
    public long PupilId { get; set; }

    public long? PupilIdLocal { get; set; }

    public string? FirstName { get; set; }

    public string? OtherNames { get; set; }

    public string? LastName { get; set; }

    public string? Sex { get; set; }

    public string? DateOfBirthDay { get; set; }

    public string? DateOfBirthMonth { get; set; }

    public string? DateOfBirthYear { get; set; }

    public string? HomeAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public long? ParentId { get; set; }

    public int? ClassId { get; set; }

    public long? LevelId { get; set; }

    public int? SchoolId { get; set; }

    public byte[]? Picture { get; set; }

    public byte[]? Fp1 { get; set; }

    public byte[]? Fp2 { get; set; }

    public byte[]? Fp3 { get; set; }

    public byte[]? Fp4 { get; set; }

    public string? DateEnroled { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Uploaded { get; set; }

    public string? ActiveSecurity { get; set; }

    public string? ActiveInteractive { get; set; }

    public string? Enabled { get; set; }

    public long? ParentId2 { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<HomeWork> HomeWorks { get; set; } = new List<HomeWork>();

    public virtual Level? Level { get; set; }

    public virtual Parent? Parent { get; set; }

    public virtual ICollection<PickUpPersonPupil> PickUpPersonPupils { get; set; } = new List<PickUpPersonPupil>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual School? School { get; set; }

    public virtual ICollection<SchoolFee> SchoolFees { get; set; } = new List<SchoolFee>();

    public virtual ICollection<SmsTracker> SmsTrackers { get; set; } = new List<SmsTracker>();
}
