using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PickUpPerson
{
    public long PickUpPersonId { get; set; }

    public long? PickUpPersonIdLocal { get; set; }

    public string? PupName { get; set; }

    public string? PupSex { get; set; }

    public string? PupPhoneNumber { get; set; }

    public string? PupAddress { get; set; }

    public byte[]? Fp1 { get; set; }

    public byte[]? Fp2 { get; set; }

    public byte[]? Fp3 { get; set; }

    public byte[]? Fp4 { get; set; }

    public int? SchoolId { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<PickUpPersonPupil> PickUpPersonPupils { get; set; } = new List<PickUpPersonPupil>();

    public virtual School? School { get; set; }
}
