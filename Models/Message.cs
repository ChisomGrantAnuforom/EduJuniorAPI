using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Message
{
    public long MessageId { get; set; }

    public long? MessageIdLocal { get; set; }

    public string? Header { get; set; }

    public string? Body { get; set; }

    public string? Image { get; set; }

    public string? StarterPhoneNumber { get; set; }

    public string? SenderPhoneNumber { get; set; }

    public string? RecipientPhoneNumber { get; set; }

    public string? DateTimeSent { get; set; }

    public string? Seen { get; set; }

    public string? Uploaded { get; set; }

    public long? MessageUserPegId { get; set; }

    public virtual MessageUserPeg? MessageUserPeg { get; set; }
}
