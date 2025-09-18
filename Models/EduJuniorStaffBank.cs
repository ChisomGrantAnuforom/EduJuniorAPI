using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class EduJuniorStaffBank
{
    public long EduJuniorStaffBankId { get; set; }

    public string? BankName { get; set; }

    public string? AccountName { get; set; }

    public string? AccountNo { get; set; }

    public string? SortCode { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public virtual EduJuniorStaff? EduJuniorStaff { get; set; }
}
