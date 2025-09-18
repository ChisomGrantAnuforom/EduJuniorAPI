using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class NewsLike
{
    public long NewsLikeId { get; set; }

    public long? NewsId { get; set; }

    public long? UserId { get; set; }

    public DateTime? DateOfLike { get; set; }

    public virtual News? News { get; set; }

    public virtual User? User { get; set; }
}
