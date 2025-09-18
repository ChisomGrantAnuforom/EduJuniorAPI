using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Country
{
    public short CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
