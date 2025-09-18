using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class MessageUserPeg
{
    public long MessageUserPegId { get; set; }

    public string? UserOnePhoneNumber { get; set; }

    public string? UserTwoPhoneNumber { get; set; }

    public DateTime? DatePeged { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
