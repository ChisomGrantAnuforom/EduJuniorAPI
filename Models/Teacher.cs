using System;
using System.Collections.Generic;

namespace EduJuniorAPI.Models;

public partial class Teacher
{
    public long TeacherId { get; set; }

    public long? TeacherIdLocal { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? OtherNames { get; set; }

    public string? LastName { get; set; }

    public string? HomeAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public string? DateOfBirthDay { get; set; }

    public string? DateOfBirthMonth { get; set; }

    public string? DateOfBirthYear { get; set; }

    public string? Sex { get; set; }

    public string? DateOfAppointmentDay { get; set; }

    public string? DateOfAppointmentMonth { get; set; }

    public string? DateOfAppointmentYear { get; set; }

    public string? Certificate { get; set; }

    public string? Designation { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public string? Enabled { get; set; }

    public virtual ICollection<HomeWork> HomeWorkInitiatingTeachers { get; set; } = new List<HomeWork>();

    public virtual ICollection<HomeWork> HomeWorkPostedByNavigations { get; set; } = new List<HomeWork>();

    public virtual ICollection<TeacherClass> TeacherClasses { get; set; } = new List<TeacherClass>();
}
