using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class AttendanceLog
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public string AttendanceType { get; set; } = null!;

    public DateTime TimeIn { get; set; }

    public DateTime TimeOut { get; set; }
}
