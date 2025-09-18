using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class NewsComment
{
    public long NewsCommentId { get; set; }

    public long? NewsId { get; set; }

    public string? Comment { get; set; }

    public long? UserId { get; set; }

    public DateTime? DateOfComment { get; set; }

    public virtual News? News { get; set; }

    public virtual User? User { get; set; }
}
