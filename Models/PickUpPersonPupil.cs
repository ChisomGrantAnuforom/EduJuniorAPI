using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PickUpPersonPupil
{
    public long PickUpPersonPupilId { get; set; }

    public long? PickUpPersonPupilIdLocal { get; set; }

    public long? PickUpPersonId { get; set; }

    public long? PupilId { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public virtual PickUpPerson? PickUpPerson { get; set; }

    public virtual ICollection<PickUp> PickUps { get; set; } = new List<PickUp>();

    public virtual Pupil? Pupil { get; set; }

    public virtual School? School { get; set; }
}
