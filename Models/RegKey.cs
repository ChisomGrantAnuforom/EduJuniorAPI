using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class RegKey
{
    public long RegKeyId { get; set; }

    public string? RegKeyDetail { get; set; }

    public string? AssignedSchool { get; set; }

    public string? Used { get; set; }

    public string? DateUsed { get; set; }

    public string? UsedBy { get; set; }

    public int? AssignedSomicleStaffId { get; set; }
}
