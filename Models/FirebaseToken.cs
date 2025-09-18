using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class FirebaseToken
{
    public long Id { get; set; }

    public string? FirebaseTokenDetail { get; set; }

    public string? PhoneNumber { get; set; }

    public string? UserCategory { get; set; }

    public long? UserServerId { get; set; }

    public string? DateCaptured { get; set; }
}
