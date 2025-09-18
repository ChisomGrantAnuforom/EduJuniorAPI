using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class PaymentRequest
{
    public long PaymentRequestId { get; set; }

    public long? SomicleStaffId { get; set; }

    public decimal? AmountToPay { get; set; }

    public string? Settled { get; set; }

    public string? DateOfRequest { get; set; }

    public string? DateOfSettlement { get; set; }

    public virtual EduJuniorStaff? SomicleStaff { get; set; }
}
