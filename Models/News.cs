using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class News
{
    public long NewsId { get; set; }

    public string? NewsHeading { get; set; }

    public string? NewsContent { get; set; }

    public string? ExternalUrl { get; set; }

    public DateTime? DateAdded { get; set; }

    public long? UploadedBy { get; set; }

    public virtual ICollection<NewsComment> NewsComments { get; set; } = new List<NewsComment>();

    public virtual ICollection<NewsImage> NewsImages { get; set; } = new List<NewsImage>();

    public virtual ICollection<NewsLike> NewsLikes { get; set; } = new List<NewsLike>();
}
