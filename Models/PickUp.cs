using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PickUp
{
    public long PickUpId { get; set; }

    public long? PickUpIdLocal { get; set; }

    public DateTime? PickUpTime { get; set; }

    public long? PickUpPersonPupilId { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual PickUpPersonPupil? PickUpPersonPupil { get; set; }

    public virtual School? School { get; set; }
}
