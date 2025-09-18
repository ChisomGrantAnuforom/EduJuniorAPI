using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class State
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public short? CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<PartnershipApplication> PartnershipApplications { get; set; } = new List<PartnershipApplication>();

    public virtual ICollection<School> Schools { get; set; } = new List<School>();
}
