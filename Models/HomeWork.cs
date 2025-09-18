using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class HomeWork
{
    public long HomeWorkId { get; set; }

    public long? HomeWorkIdLocal { get; set; }

    public string? Title { get; set; }

    public string? Detail { get; set; }

    public byte[]? Image { get; set; }

    public string? DateForSubmission { get; set; }

    public long? PupilId { get; set; }

    public long? InitiatingTeacherId { get; set; }

    public long? PostedBy { get; set; }

    public string? DatePosted { get; set; }

    public string? Uploaded { get; set; }

    public virtual Teacher? InitiatingTeacher { get; set; }

    public virtual Teacher? PostedByNavigation { get; set; }

    public virtual Pupil? Pupil { get; set; }
}
