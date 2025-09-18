using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class AppNotification
{
    public long AppNotificationId { get; set; }

    public string? Title { get; set; }

    public string? Message { get; set; }

    public string? Date { get; set; }
}
