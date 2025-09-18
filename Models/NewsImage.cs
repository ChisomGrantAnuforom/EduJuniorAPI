using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class NewsImage
{
    public long NewsImageId { get; set; }

    public long? NewsId { get; set; }

    public string? ImageTag { get; set; }

    public string? ImageUrl { get; set; }

    public virtual News? News { get; set; }
}
