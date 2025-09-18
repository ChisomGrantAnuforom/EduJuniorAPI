using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PartnershipApplication
{
    public long PartnershipApplicationId { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? Sex { get; set; }

    public byte? Age { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? HomeAddress { get; set; }

    public int? StateOfResidence { get; set; }

    public string? CityOfResidence { get; set; }

    public string? EmploymentStatus { get; set; }

    public virtual State? StateOfResidenceNavigation { get; set; }
}
