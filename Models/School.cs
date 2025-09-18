using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class School
{
    public int SchoolId { get; set; }

    public int? ServerSchoolId { get; set; }

    public string? SchoolName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public int? LocationId { get; set; }

    public string? ProprietorFullName { get; set; }

    public string? HeadFullName { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? RegKey { get; set; }

    public string? Active { get; set; }

    public string? Uploaded { get; set; }

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();

    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<Level> Levels { get; set; } = new List<Level>();

    public virtual State? Location { get; set; }

    public virtual ICollection<PickUpPerson> PickUpPeople { get; set; } = new List<PickUpPerson>();

    public virtual ICollection<PickUpPersonPupil> PickUpPersonPupils { get; set; } = new List<PickUpPersonPupil>();

    public virtual ICollection<PickUp> PickUps { get; set; } = new List<PickUp>();

    public virtual ICollection<PupilSecurity> PupilSecurities { get; set; } = new List<PupilSecurity>();

    public virtual ICollection<Pupil> Pupils { get; set; } = new List<Pupil>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();

    public virtual ICollection<SchoolFee> SchoolFees { get; set; } = new List<SchoolFee>();

    public virtual ICollection<SchoolReferral> SchoolReferrals { get; set; } = new List<SchoolReferral>();

    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();

    public virtual ICollection<SmsTracker> SmsTrackers { get; set; } = new List<SmsTracker>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    public virtual ICollection<TeacherClass> TeacherClasses { get; set; } = new List<TeacherClass>();

    public virtual ICollection<Term> Terms { get; set; } = new List<Term>();
}
