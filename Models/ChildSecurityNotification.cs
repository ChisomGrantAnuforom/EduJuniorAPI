using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class ChildSecurityNotification
{
    public long Id { get; set; }

    public long ParentId { get; set; }

    public long StudentId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime SentAt { get; set; }

    public string Channel { get; set; } = null!;
}
