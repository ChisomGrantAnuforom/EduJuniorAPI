using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class ElearningCategory
{
    public int ElearningCategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<ElearningContent> ElearningContents { get; set; } = new List<ElearningContent>();
}
