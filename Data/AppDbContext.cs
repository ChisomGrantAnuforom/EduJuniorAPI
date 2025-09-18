using System;
using System.Collections.Generic;
using EduJuniorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EduJuniorAPI.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppNotification> AppNotifications { get; set; }

    public virtual DbSet<AttendanceLog> AttendanceLogs { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<ChildSecurityNotification> ChildSecurityNotifications { get; set; }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<EduJuniorStaff> EduJuniorStaffs { get; set; }

    public virtual DbSet<EduJuniorStaffBank> EduJuniorStaffBanks { get; set; }

    public virtual DbSet<ElearningCategory> ElearningCategories { get; set; }

    public virtual DbSet<ElearningContent> ElearningContents { get; set; }

    public virtual DbSet<ElearningGrade> ElearningGrades { get; set; }

    public virtual DbSet<ElearningSubject> ElearningSubjects { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<FirebaseToken> FirebaseTokens { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<HomeWork> HomeWorks { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageUserPeg> MessageUserPegs { get; set; }

    public virtual DbSet<MlmPosition> MlmPositions { get; set; }

    public virtual DbSet<MlmUserPosition> MlmUserPositions { get; set; }

    public virtual DbSet<MlmUserReceivedBonu> MlmUserReceivedBonus { get; set; }

    public virtual DbSet<MlmUserReferral> MlmUserReferrals { get; set; }

    public virtual DbSet<MlmUserReferralAccount> MlmUserReferralAccounts { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<NewsComment> NewsComments { get; set; }

    public virtual DbSet<NewsImage> NewsImages { get; set; }

    public virtual DbSet<NewsLike> NewsLikes { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<PartnershipApplication> PartnershipApplications { get; set; }

    public virtual DbSet<PaymentRequest> PaymentRequests { get; set; }

    public virtual DbSet<PickUp> PickUps { get; set; }

    public virtual DbSet<PickUpPerson> PickUpPeople { get; set; }

    public virtual DbSet<PickUpPersonPupil> PickUpPersonPupils { get; set; }

    public virtual DbSet<Pupil> Pupils { get; set; }

    public virtual DbSet<PupilSecurity> PupilSecurities { get; set; }

    public virtual DbSet<RegKey> RegKeys { get; set; }

    public virtual DbSet<Result> Results { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<SchoolFee> SchoolFees { get; set; }

    public virtual DbSet<SchoolReferral> SchoolReferrals { get; set; }

    public virtual DbSet<SchoolReferralAccount> SchoolReferralAccounts { get; set; }

    public virtual DbSet<SchoolReferralAccountHistory> SchoolReferralAccountHistories { get; set; }

    public virtual DbSet<Security> Securities { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<SmsTracker> SmsTrackers { get; set; }

    public virtual DbSet<StaffSchoolEngagement> StaffSchoolEngagements { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherClass> TeacherClasses { get; set; }

    public virtual DbSet<Term> Terms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserCategory> UserCategories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppNotification>(entity =>
        {
            entity.ToTable("APP_NOTIFICATION");

            entity.Property(e => e.AppNotificationId)
                .ValueGeneratedNever()
                .HasColumnName("APP_NOTIFICATION_ID");
            entity.Property(e => e.Date)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DATE");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<AttendanceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AttendanceLogs");

            entity.ToTable("ATTENDANCE_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttendanceType).HasColumnName("ATTENDANCE_TYPE");
            entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");
            entity.Property(e => e.TimeIn).HasColumnName("TIME_IN");
            entity.Property(e => e.TimeOut).HasColumnName("TIME_OUT");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("BANK");

            entity.Property(e => e.BankId)
                .ValueGeneratedNever()
                .HasColumnName("BANK_ID");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_NAME");
        });

        modelBuilder.Entity<ChildSecurityNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Notifications");

            entity.ToTable("CHILD_SECURITY_NOTIFICATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Channel).HasColumnName("CHANNEL");
            entity.Property(e => e.Message).HasColumnName("MESSAGE");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
            entity.Property(e => e.SentAt).HasColumnName("SENT_AT");
            entity.Property(e => e.StudentId).HasColumnName("STUDENT_ID");
        });

        modelBuilder.Entity<Class>(entity =>
        {
            entity.ToTable("CLASS");

            entity.Property(e => e.ClassId)
                .ValueGeneratedNever()
                .HasColumnName("CLASS_ID");
            entity.Property(e => e.ClassIdLocal).HasColumnName("CLASS_ID_LOCAL");
            entity.Property(e => e.ClassName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASS_NAME");
            entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Classes)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_CLASS_SCHOOL");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("COUNTRY");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("COUNTRY_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_NAME");
        });

        modelBuilder.Entity<EduJuniorStaff>(entity =>
        {
            entity.HasKey(e => e.EduJuniorStaffId).HasName("PK_SOMICLE_STAFF");

            entity.ToTable("EDU_JUNIOR_STAFF");

            entity.Property(e => e.EduJuniorStaffId)
                .ValueGeneratedNever()
                .HasColumnName("EDU_JUNIOR_STAFF_ID");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HOME_ADDRESS");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.OtherNames)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHER_NAMES");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.ReferralPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REFERRAL_PHONE_NUMBER");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Verified)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VERIFIED");
        });

        modelBuilder.Entity<EduJuniorStaffBank>(entity =>
        {
            entity.HasKey(e => e.EduJuniorStaffBankId).HasName("PK_USER_BANK");

            entity.ToTable("EDU_JUNIOR_STAFF_BANK");

            entity.Property(e => e.EduJuniorStaffBankId)
                .ValueGeneratedNever()
                .HasColumnName("EDU_JUNIOR_STAFF_BANK_ID");
            entity.Property(e => e.AccountName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_NAME");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_NO");
            entity.Property(e => e.BankName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BANK_NAME");
            entity.Property(e => e.DateAdded)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_ADDED");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.EduJuniorStaffId).HasColumnName("EDU_JUNIOR_STAFF_ID");
            entity.Property(e => e.SortCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SORT_CODE");

            entity.HasOne(d => d.EduJuniorStaff).WithMany(p => p.EduJuniorStaffBanks)
                .HasForeignKey(d => d.EduJuniorStaffId)
                .HasConstraintName("FK_EDU_JUNIOR_STAFF_BANK_EDU_JUNIOR_STAFF");
        });

        modelBuilder.Entity<ElearningCategory>(entity =>
        {
            entity.ToTable("ELEARNING_CATEGORY");

            entity.Property(e => e.ElearningCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("ELEARNING_CATEGORY_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_NAME");
        });

        modelBuilder.Entity<ElearningContent>(entity =>
        {
            entity.ToTable("ELEARNING_CONTENT");

            entity.Property(e => e.ElearningContentId)
                .ValueGeneratedNever()
                .HasColumnName("ELEARNING_CONTENT_ID");
            entity.Property(e => e.ElearningCategoryId).HasColumnName("ELEARNING_CATEGORY_ID");
            entity.Property(e => e.ElearningGradeId).HasColumnName("ELEARNING_GRADE_ID");
            entity.Property(e => e.ElearningSubjectId).HasColumnName("ELEARNING_SUBJECT_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Url)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.ElearningCategory).WithMany(p => p.ElearningContents)
                .HasForeignKey(d => d.ElearningCategoryId)
                .HasConstraintName("FK_ELEARNING_CONTENT_ELEARNING_CATEGORY");

            entity.HasOne(d => d.ElearningGrade).WithMany(p => p.ElearningContents)
                .HasForeignKey(d => d.ElearningGradeId)
                .HasConstraintName("FK_ELEARNING_CONTENT_ELEARNING_GRADE");

            entity.HasOne(d => d.ElearningSubject).WithMany(p => p.ElearningContents)
                .HasForeignKey(d => d.ElearningSubjectId)
                .HasConstraintName("FK_ELEARNING_CONTENT_ELEARNING_SUBJECT");
        });

        modelBuilder.Entity<ElearningGrade>(entity =>
        {
            entity.ToTable("ELEARNING_GRADE");

            entity.Property(e => e.ElearningGradeId)
                .ValueGeneratedNever()
                .HasColumnName("ELEARNING_GRADE_ID");
            entity.Property(e => e.GradeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GRADE_NAME");
        });

        modelBuilder.Entity<ElearningSubject>(entity =>
        {
            entity.ToTable("ELEARNING_SUBJECT");

            entity.Property(e => e.ElearningSubjectId)
                .ValueGeneratedNever()
                .HasColumnName("ELEARNING_SUBJECT_ID");
            entity.Property(e => e.ElearningGradeId).HasColumnName("ELEARNING_GRADE_ID");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBJECT_NAME");

            entity.HasOne(d => d.ElearningGrade).WithMany(p => p.ElearningSubjects)
                .HasForeignKey(d => d.ElearningGradeId)
                .HasConstraintName("FK_ELEARNING_SUBJECT_ELEARNING_GRADE");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("EXAM");

            entity.Property(e => e.ExamId)
                .ValueGeneratedNever()
                .HasColumnName("EXAM_ID");
            entity.Property(e => e.ExamIdLocal).HasColumnName("EXAM_ID_LOCAL");
            entity.Property(e => e.ExamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXAM_NAME");
            entity.Property(e => e.OverallScore)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OVERALL_SCORE");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Exams)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_EXAM_SCHOOL");
        });

        modelBuilder.Entity<FirebaseToken>(entity =>
        {
            entity.ToTable("FIREBASE_TOKEN");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.DateCaptured)
                .IsUnicode(false)
                .HasColumnName("DATE_CAPTURED");
            entity.Property(e => e.FirebaseTokenDetail)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("FIREBASE_TOKEN_DETAIL");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.UserCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_CATEGORY");
            entity.Property(e => e.UserServerId).HasColumnName("USER_SERVER_ID");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.ToTable("GRADE");

            entity.Property(e => e.GradeId)
                .ValueGeneratedNever()
                .HasColumnName("GRADE_ID");
            entity.Property(e => e.GradeIdLocal).HasColumnName("GRADE_ID_LOCAL");
            entity.Property(e => e.GradeName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GRADE_NAME");
            entity.Property(e => e.MaximumPercentage).HasColumnName("MAXIMUM_PERCENTAGE");
            entity.Property(e => e.MinimumPercentage).HasColumnName("MINIMUM_PERCENTAGE");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Grades)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_GRADE_SCHOOL");
        });

        modelBuilder.Entity<HomeWork>(entity =>
        {
            entity.ToTable("HOME_WORK");

            entity.Property(e => e.HomeWorkId)
                .ValueGeneratedNever()
                .HasColumnName("HOME_WORK_ID");
            entity.Property(e => e.DateForSubmission)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_FOR_SUBMISSION");
            entity.Property(e => e.DatePosted)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_POSTED");
            entity.Property(e => e.Detail)
                .IsUnicode(false)
                .HasColumnName("DETAIL");
            entity.Property(e => e.HomeWorkIdLocal).HasColumnName("HOME_WORK_ID_LOCAL");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("IMAGE");
            entity.Property(e => e.InitiatingTeacherId).HasColumnName("INITIATING_TEACHER_ID");
            entity.Property(e => e.PostedBy).HasColumnName("POSTED_BY");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.InitiatingTeacher).WithMany(p => p.HomeWorkInitiatingTeachers)
                .HasForeignKey(d => d.InitiatingTeacherId)
                .HasConstraintName("FK_HOME_WORK_TEACHER");

            entity.HasOne(d => d.PostedByNavigation).WithMany(p => p.HomeWorkPostedByNavigations)
                .HasForeignKey(d => d.PostedBy)
                .HasConstraintName("FK_HOME_WORK_TEACHER1");

            entity.HasOne(d => d.Pupil).WithMany(p => p.HomeWorks)
                .HasForeignKey(d => d.PupilId)
                .HasConstraintName("FK_HOME_WORK_PUPIL");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.ToTable("LEVEL");

            entity.Property(e => e.LevelId)
                .ValueGeneratedNever()
                .HasColumnName("LEVEL_ID");
            entity.Property(e => e.LevelIdLocal).HasColumnName("LEVEL_ID_LOCAL");
            entity.Property(e => e.LevelName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LEVEL_NAME");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Levels)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_LEVEL_SCHOOL");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("LOCATION");

            entity.Property(e => e.LocationId)
                .ValueGeneratedNever()
                .HasColumnName("LOCATION_ID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCATION_NAME");
            entity.Property(e => e.StateId).HasColumnName("STATE_ID");

            entity.HasOne(d => d.State).WithMany(p => p.Locations)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_LOCATION_STATE");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("MESSAGE");

            entity.Property(e => e.MessageId)
                .ValueGeneratedNever()
                .HasColumnName("MESSAGE_ID");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.DateTimeSent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_TIME_SENT");
            entity.Property(e => e.Header)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HEADER");
            entity.Property(e => e.Image)
                .IsUnicode(false)
                .HasColumnName("IMAGE");
            entity.Property(e => e.MessageIdLocal).HasColumnName("MESSAGE_ID_LOCAL");
            entity.Property(e => e.MessageUserPegId).HasColumnName("MESSAGE_USER_PEG_ID");
            entity.Property(e => e.RecipientPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECIPIENT_PHONE_NUMBER");
            entity.Property(e => e.Seen)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEEN");
            entity.Property(e => e.SenderPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SENDER_PHONE_NUMBER");
            entity.Property(e => e.StarterPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STARTER_PHONE_NUMBER");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.MessageUserPeg).WithMany(p => p.Messages)
                .HasForeignKey(d => d.MessageUserPegId)
                .HasConstraintName("FK_MESSAGE_MESSAGE_USER_PEG");
        });

        modelBuilder.Entity<MessageUserPeg>(entity =>
        {
            entity.ToTable("MESSAGE_USER_PEG");

            entity.Property(e => e.MessageUserPegId)
                .ValueGeneratedNever()
                .HasColumnName("MESSAGE_USER_PEG_ID");
            entity.Property(e => e.DatePeged)
                .HasColumnType("datetime")
                .HasColumnName("DATE_PEGED");
            entity.Property(e => e.UserOnePhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_ONE_PHONE_NUMBER");
            entity.Property(e => e.UserTwoPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_TWO_PHONE_NUMBER");
        });

        modelBuilder.Entity<MlmPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId);

            entity.ToTable("MLM.POSITION");

            entity.Property(e => e.PositionId).HasColumnName("POSITION_ID");
            entity.Property(e => e.ActivityCountFrom).HasColumnName("ACTIVITY_COUNT_FROM");
            entity.Property(e => e.ActivityCountTo).HasColumnName("ACTIVITY_COUNT_TO");
            entity.Property(e => e.Bonus)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BONUS");
            entity.Property(e => e.PositionName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSITION_NAME");
            entity.Property(e => e.Share)
                .HasColumnType("decimal(18, 1)")
                .HasColumnName("SHARE");
        });

        modelBuilder.Entity<MlmUserPosition>(entity =>
        {
            entity.HasKey(e => e.UserPositionId);

            entity.ToTable("MLM.USER_POSITION");

            entity.Property(e => e.UserPositionId)
                .ValueGeneratedNever()
                .HasColumnName("USER_POSITION_ID");
            entity.Property(e => e.CurrentActivityCount).HasColumnName("CURRENT_ACTIVITY_COUNT");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.PositionId).HasColumnName("POSITION_ID");
            entity.Property(e => e.ReferralUserId).HasColumnName("REFERRAL_USER_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Position).WithMany(p => p.MlmUserPositions)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_MLM.USER_POSITION_MLM.POSITION");

            entity.HasOne(d => d.User).WithMany(p => p.MlmUserPositions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MLM.USER_POSITION_SOMICLE_STAFF");
        });

        modelBuilder.Entity<MlmUserReceivedBonu>(entity =>
        {
            entity.HasKey(e => e.UserReceivedBonusId).HasName("PK_USER_RECEIVED_BONUS");

            entity.ToTable("MLM.USER_RECEIVED_BONUS");

            entity.Property(e => e.UserReceivedBonusId)
                .ValueGeneratedNever()
                .HasColumnName("USER_RECEIVED_BONUS_ID");
            entity.Property(e => e.BonusReceived)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BONUS_RECEIVED");
            entity.Property(e => e.DateReceived)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_RECEIVED");
            entity.Property(e => e.PositionId).HasColumnName("POSITION_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Position).WithMany(p => p.MlmUserReceivedBonus)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_MLM.USER_RECEIVED_BONUS_MLM.POSITION");

            entity.HasOne(d => d.User).WithMany(p => p.MlmUserReceivedBonus)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MLM.USER_RECEIVED_BONUS_SOMICLE_STAFF");
        });

        modelBuilder.Entity<MlmUserReferral>(entity =>
        {
            entity.HasKey(e => e.UserReferralId);

            entity.ToTable("MLM.USER_REFERRAL");

            entity.Property(e => e.UserReferralId)
                .ValueGeneratedNever()
                .HasColumnName("USER_REFERRAL_ID");
            entity.Property(e => e.DateReferred)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REFERRED");
            entity.Property(e => e.ReferralId).HasColumnName("REFERRAL_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.Referral).WithMany(p => p.MlmUserReferralReferrals)
                .HasForeignKey(d => d.ReferralId)
                .HasConstraintName("FK_MLM.USER_REFERRAL_SOMICLE_STAFF1");

            entity.HasOne(d => d.User).WithMany(p => p.MlmUserReferralUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_MLM.USER_REFERRAL_SOMICLE_STAFF");
        });

        modelBuilder.Entity<MlmUserReferralAccount>(entity =>
        {
            entity.HasKey(e => e.UserReferralAccountId).HasName("PK_USER_REFERRAL_ACCOUNT");

            entity.ToTable("MLM.USER_REFERRAL_ACCOUNT");

            entity.Property(e => e.UserReferralAccountId)
                .ValueGeneratedNever()
                .HasColumnName("USER_REFERRAL_ACCOUNT_ID");
            entity.Property(e => e.AmountToBeCleared)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_TO_BE_CLEARED");
            entity.Property(e => e.DateLastCleared)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_CLEARED");
            entity.Property(e => e.DateOfLastTransaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_LAST_TRANSACTION");
            entity.Property(e => e.NoOfReferralReferredStudentsUncleared).HasColumnName("NO_OF_REFERRAL_REFERRED_STUDENTS_UNCLEARED");
            entity.Property(e => e.SomicleStaffId).HasColumnName("SOMICLE_STAFF_ID");
            entity.Property(e => e.TotalAmountCleared)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL_AMOUNT_CLEARED");
            entity.Property(e => e.TotalNoOfSchoolsReferredByReferrals).HasColumnName("TOTAL_NO_OF_SCHOOLS_REFERRED_BY_REFERRALS");
            entity.Property(e => e.TotalNoOfStudentsReferredByReferrals).HasColumnName("TOTAL_NO_OF_STUDENTS_REFERRED_BY_REFERRALS");

            entity.HasOne(d => d.SomicleStaff).WithMany(p => p.MlmUserReferralAccounts)
                .HasForeignKey(d => d.SomicleStaffId)
                .HasConstraintName("FK_MLM.USER_REFERRAL_ACCOUNT_SOMICLE_STAFF");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.ToTable("NEWS");

            entity.Property(e => e.NewsId)
                .ValueGeneratedNever()
                .HasColumnName("NEWS_ID");
            entity.Property(e => e.DateAdded)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ADDED");
            entity.Property(e => e.ExternalUrl)
                .IsUnicode(false)
                .HasColumnName("EXTERNAL_URL");
            entity.Property(e => e.NewsContent)
                .IsUnicode(false)
                .HasColumnName("NEWS_CONTENT");
            entity.Property(e => e.NewsHeading)
                .IsUnicode(false)
                .HasColumnName("NEWS_HEADING");
            entity.Property(e => e.UploadedBy).HasColumnName("UPLOADED_BY");
        });

        modelBuilder.Entity<NewsComment>(entity =>
        {
            entity.ToTable("NEWS_COMMENT");

            entity.Property(e => e.NewsCommentId)
                .ValueGeneratedNever()
                .HasColumnName("NEWS_COMMENT_ID");
            entity.Property(e => e.Comment)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.DateOfComment)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_COMMENT");
            entity.Property(e => e.NewsId).HasColumnName("NEWS_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.News).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_NEWS_COMMENT_NEWS");

            entity.HasOne(d => d.User).WithMany(p => p.NewsComments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_NEWS_COMMENT_USER");
        });

        modelBuilder.Entity<NewsImage>(entity =>
        {
            entity.ToTable("NEWS_IMAGE");

            entity.Property(e => e.NewsImageId)
                .ValueGeneratedNever()
                .HasColumnName("NEWS_IMAGE_ID");
            entity.Property(e => e.ImageTag)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IMAGE_TAG");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.NewsId).HasColumnName("NEWS_ID");

            entity.HasOne(d => d.News).WithMany(p => p.NewsImages)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_NEWS_IMAGE_NEWS");
        });

        modelBuilder.Entity<NewsLike>(entity =>
        {
            entity.ToTable("NEWS_LIKE");

            entity.Property(e => e.NewsLikeId)
                .ValueGeneratedNever()
                .HasColumnName("NEWS_LIKE_ID");
            entity.Property(e => e.DateOfLike)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_LIKE");
            entity.Property(e => e.NewsId).HasColumnName("NEWS_ID");
            entity.Property(e => e.UserId).HasColumnName("USER_ID");

            entity.HasOne(d => d.News).WithMany(p => p.NewsLikes)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_NEWS_LIKE_NEWS");

            entity.HasOne(d => d.User).WithMany(p => p.NewsLikes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_NEWS_LIKE_USER");
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.ToTable("PARENT");

            entity.Property(e => e.ParentId)
                .ValueGeneratedNever()
                .HasColumnName("PARENT_ID");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HOME_ADDRESS");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OCCUPATION");
            entity.Property(e => e.OtherNames)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHER_NAMES");
            entity.Property(e => e.ParentIdLocal).HasColumnName("PARENT_ID_LOCAL");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");
        });

        modelBuilder.Entity<PartnershipApplication>(entity =>
        {
            entity.ToTable("PARTNERSHIP_APPLICATION");

            entity.Property(e => e.PartnershipApplicationId)
                .ValueGeneratedNever()
                .HasColumnName("PARTNERSHIP_APPLICATION_ID");
            entity.Property(e => e.Age).HasColumnName("AGE");
            entity.Property(e => e.CityOfResidence)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY_OF_RESIDENCE");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.EmploymentStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMPLOYMENT_STATUS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("HOME_ADDRESS");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.StateOfResidence).HasColumnName("STATE_OF_RESIDENCE");
            entity.Property(e => e.Surname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SURNAME");

            entity.HasOne(d => d.StateOfResidenceNavigation).WithMany(p => p.PartnershipApplications)
                .HasForeignKey(d => d.StateOfResidence)
                .HasConstraintName("FK_PARTNERSHIP_APPLICATION_STATE");
        });

        modelBuilder.Entity<PaymentRequest>(entity =>
        {
            entity.ToTable("PAYMENT_REQUEST");

            entity.Property(e => e.PaymentRequestId)
                .ValueGeneratedNever()
                .HasColumnName("PAYMENT_REQUEST_ID");
            entity.Property(e => e.AmountToPay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_TO_PAY");
            entity.Property(e => e.DateOfRequest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_REQUEST");
            entity.Property(e => e.DateOfSettlement)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_SETTLEMENT");
            entity.Property(e => e.Settled)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SETTLED");
            entity.Property(e => e.SomicleStaffId).HasColumnName("SOMICLE_STAFF_ID");

            entity.HasOne(d => d.SomicleStaff).WithMany(p => p.PaymentRequests)
                .HasForeignKey(d => d.SomicleStaffId)
                .HasConstraintName("FK_PAYMENT_REQUEST_SOMICLE_STAFF");
        });

        modelBuilder.Entity<PickUp>(entity =>
        {
            entity.ToTable("PICK_UP");

            entity.Property(e => e.PickUpId)
                .ValueGeneratedNever()
                .HasColumnName("PICK_UP_ID");
            entity.Property(e => e.PickUpIdLocal).HasColumnName("PICK_UP_ID_LOCAL");
            entity.Property(e => e.PickUpPersonPupilId).HasColumnName("PICK_UP_PERSON_PUPIL_ID");
            entity.Property(e => e.PickUpTime)
                .HasColumnType("datetime")
                .HasColumnName("PICK_UP_TIME");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.PickUpPersonPupil).WithMany(p => p.PickUps)
                .HasForeignKey(d => d.PickUpPersonPupilId)
                .HasConstraintName("FK_PICK_UP_PICK_UP_PERSON_PUPIL");

            entity.HasOne(d => d.School).WithMany(p => p.PickUps)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_PICK_UP_SCHOOL");
        });

        modelBuilder.Entity<PickUpPerson>(entity =>
        {
            entity.ToTable("PICK_UP_PERSON");

            entity.Property(e => e.PickUpPersonId)
                .ValueGeneratedNever()
                .HasColumnName("PICK_UP_PERSON_ID");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.Fp1)
                .HasColumnType("image")
                .HasColumnName("FP1");
            entity.Property(e => e.Fp2)
                .HasColumnType("image")
                .HasColumnName("FP2");
            entity.Property(e => e.Fp3)
                .HasColumnType("image")
                .HasColumnName("FP3");
            entity.Property(e => e.Fp4)
                .HasColumnType("image")
                .HasColumnName("FP4");
            entity.Property(e => e.PickUpPersonIdLocal).HasColumnName("PICK_UP_PERSON_ID_LOCAL");
            entity.Property(e => e.PupAddress)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PUP_ADDRESS");
            entity.Property(e => e.PupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUP_NAME");
            entity.Property(e => e.PupPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PUP_PHONE_NUMBER");
            entity.Property(e => e.PupSex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PUP_SEX");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.PickUpPeople)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_PICK_UP_PERSON_SCHOOL");
        });

        modelBuilder.Entity<PickUpPersonPupil>(entity =>
        {
            entity.ToTable("PICK_UP_PERSON_PUPIL");

            entity.Property(e => e.PickUpPersonPupilId)
                .ValueGeneratedNever()
                .HasColumnName("PICK_UP_PERSON_PUPIL_ID");
            entity.Property(e => e.PickUpPersonId).HasColumnName("PICK_UP_PERSON_ID");
            entity.Property(e => e.PickUpPersonPupilIdLocal).HasColumnName("PICK_UP_PERSON_PUPIL_ID_LOCAL");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.PickUpPerson).WithMany(p => p.PickUpPersonPupils)
                .HasForeignKey(d => d.PickUpPersonId)
                .HasConstraintName("FK_PICK_UP_PERSON_PUPIL_PICK_UP_PERSON");

            entity.HasOne(d => d.Pupil).WithMany(p => p.PickUpPersonPupils)
                .HasForeignKey(d => d.PupilId)
                .HasConstraintName("FK_PICK_UP_PERSON_PUPIL_PUPIL");

            entity.HasOne(d => d.School).WithMany(p => p.PickUpPersonPupils)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_PICK_UP_PERSON_PUPIL_SCHOOL");
        });

        modelBuilder.Entity<Pupil>(entity =>
        {
            entity.ToTable("PUPIL");

            entity.Property(e => e.PupilId)
                .ValueGeneratedNever()
                .HasColumnName("PUPIL_ID");
            entity.Property(e => e.ActiveInteractive)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_INTERACTIVE");
            entity.Property(e => e.ActiveSecurity)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ACTIVE_SECURITY");
            entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");
            entity.Property(e => e.DateEnroled)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_ENROLED");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateOfBirthDay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_DAY");
            entity.Property(e => e.DateOfBirthMonth)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_MONTH");
            entity.Property(e => e.DateOfBirthYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_YEAR");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.Enabled)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENABLED");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.Fp1)
                .HasColumnType("image")
                .HasColumnName("FP1");
            entity.Property(e => e.Fp2)
                .HasColumnType("image")
                .HasColumnName("FP2");
            entity.Property(e => e.Fp3)
                .HasColumnType("image")
                .HasColumnName("FP3");
            entity.Property(e => e.Fp4)
                .HasColumnType("image")
                .HasColumnName("FP4");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HOME_ADDRESS");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");
            entity.Property(e => e.OtherNames)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHER_NAMES");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
            entity.Property(e => e.ParentId2).HasColumnName("PARENT_ID_2");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.Picture)
                .HasColumnType("image")
                .HasColumnName("PICTURE");
            entity.Property(e => e.PupilIdLocal).HasColumnName("PUPIL_ID_LOCAL");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Class).WithMany(p => p.Pupils)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_PUPIL_CLASS");

            entity.HasOne(d => d.Level).WithMany(p => p.Pupils)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_PUPIL_LEVEL");

            entity.HasOne(d => d.Parent).WithMany(p => p.Pupils)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_PUPIL_PARENT");

            entity.HasOne(d => d.School).WithMany(p => p.Pupils)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_PUPIL_SCHOOL");
        });

        modelBuilder.Entity<PupilSecurity>(entity =>
        {
            entity.ToTable("PUPIL_SECURITY");

            entity.Property(e => e.PupilSecurityId)
                .ValueGeneratedNever()
                .HasColumnName("PUPIL_SECURITY_ID");
            entity.Property(e => e.AuthType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUTH_TYPE");
            entity.Property(e => e.DateTime)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("DATE_TIME");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.School).WithMany(p => p.PupilSecurities)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_PUPIL_SECURITY_SCHOOL");
        });

        modelBuilder.Entity<RegKey>(entity =>
        {
            entity.ToTable("REG_KEY");

            entity.Property(e => e.RegKeyId)
                .ValueGeneratedNever()
                .HasColumnName("REG_KEY_ID");
            entity.Property(e => e.AssignedSchool)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ASSIGNED_SCHOOL");
            entity.Property(e => e.AssignedSomicleStaffId).HasColumnName("ASSIGNED_SOMICLE_STAFF_ID");
            entity.Property(e => e.DateUsed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_USED");
            entity.Property(e => e.RegKeyDetail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REG_KEY_DETAIL");
            entity.Property(e => e.Used)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("USED");
            entity.Property(e => e.UsedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("USED_BY");
        });

        modelBuilder.Entity<Result>(entity =>
        {
            entity.ToTable("RESULT");

            entity.Property(e => e.ResultId)
                .ValueGeneratedNever()
                .HasColumnName("RESULT_ID");
            entity.Property(e => e.Approved)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPROVED");
            entity.Property(e => e.DatePublished)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATE_PUBLISHED");
            entity.Property(e => e.ExamId).HasColumnName("EXAM_ID");
            entity.Property(e => e.LevelId).HasColumnName("LEVEL_ID");
            entity.Property(e => e.PublishedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PUBLISHED_BY");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.ResultIdLocal).HasColumnName("RESULT_ID_LOCAL");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Score)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SCORE");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.SubjectId).HasColumnName("SUBJECT_ID");
            entity.Property(e => e.TeacherRemarks)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TEACHER_REMARKS");
            entity.Property(e => e.TermId).HasColumnName("TERM_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Exam).WithMany(p => p.Results)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_RESULT_EXAM");

            entity.HasOne(d => d.Level).WithMany(p => p.Results)
                .HasForeignKey(d => d.LevelId)
                .HasConstraintName("FK_RESULT_LEVEL");

            entity.HasOne(d => d.Pupil).WithMany(p => p.Results)
                .HasForeignKey(d => d.PupilId)
                .HasConstraintName("FK_RESULT_PUPIL");

            entity.HasOne(d => d.School).WithMany(p => p.Results)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_RESULT_SCHOOL");

            entity.HasOne(d => d.Session).WithMany(p => p.Results)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("FK_RESULT_SESSION");

            entity.HasOne(d => d.Subject).WithMany(p => p.Results)
                .HasForeignKey(d => d.SubjectId)
                .HasConstraintName("FK_RESULT_SUBJECT");

            entity.HasOne(d => d.Term).WithMany(p => p.Results)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_RESULT_TERM");
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.ToTable("SCHOOL");

            entity.Property(e => e.SchoolId)
                .ValueGeneratedNever()
                .HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Active)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ACTIVE");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.DateAdded)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_ADDED");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.HeadFullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HEAD_FULL_NAME");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.ProprietorFullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROPRIETOR_FULL_NAME");
            entity.Property(e => e.RegKey)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REG_KEY");
            entity.Property(e => e.SchoolName)
                .IsUnicode(false)
                .HasColumnName("SCHOOL_NAME");
            entity.Property(e => e.ServerSchoolId).HasColumnName("SERVER_SCHOOL_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Location).WithMany(p => p.Schools)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_SCHOOL_STATE");
        });

        modelBuilder.Entity<SchoolFee>(entity =>
        {
            entity.ToTable("SCHOOL_FEE");

            entity.Property(e => e.SchoolFeeId)
                .ValueGeneratedNever()
                .HasColumnName("SCHOOL_FEE_ID");
            entity.Property(e => e.AmountPaid)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_PAID");
            entity.Property(e => e.AmountToPay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_TO_PAY");
            entity.Property(e => e.AmountToSomicle)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_TO_SOMICLE");
            entity.Property(e => e.AssignedSms).HasColumnName("ASSIGNED_SMS");
            entity.Property(e => e.Balance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BALANCE");
            entity.Property(e => e.DateDay).HasColumnName("DATE_DAY");
            entity.Property(e => e.DateFinal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DATE_FINAL");
            entity.Property(e => e.DateMonth).HasColumnName("DATE_MONTH");
            entity.Property(e => e.DateYear).HasColumnName("DATE_YEAR");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.Remitted)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("REMITTED");
            entity.Property(e => e.SchoolFeeIdLocal).HasColumnName("SCHOOL_FEE_ID_LOCAL");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.SessionId).HasColumnName("SESSION_ID");
            entity.Property(e => e.TermId).HasColumnName("TERM_ID");
            entity.Property(e => e.TermStartDateDay)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TERM_START_DATE_DAY");
            entity.Property(e => e.TermStartDateMonth)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TERM_START_DATE_MONTH");
            entity.Property(e => e.TermStartDateYear)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TERM_START_DATE_YEAR");
            entity.Property(e => e.TotalAmountToPay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL_AMOUNT_TO_PAY");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Pupil).WithMany(p => p.SchoolFees)
                .HasForeignKey(d => d.PupilId)
                .HasConstraintName("FK_SCHOOL_FEE_PUPIL");

            entity.HasOne(d => d.School).WithMany(p => p.SchoolFees)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_SCHOOL_FEE_SCHOOL");

            entity.HasOne(d => d.Session).WithMany(p => p.SchoolFees)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("FK_SCHOOL_FEE_SESSION");

            entity.HasOne(d => d.Term).WithMany(p => p.SchoolFees)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_SCHOOL_FEE_TERM");
        });

        modelBuilder.Entity<SchoolReferral>(entity =>
        {
            entity.HasKey(e => e.SchoolReferralId).HasName("PK_USER_REFERRAL");

            entity.ToTable("SCHOOL_REFERRAL");

            entity.Property(e => e.SchoolReferralId)
                .ValueGeneratedNever()
                .HasColumnName("SCHOOL_REFERRAL_ID");
            entity.Property(e => e.DateOfReferral)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_REFERRAL");
            entity.Property(e => e.EduJuniorStaffId).HasColumnName("EDU_JUNIOR_STAFF_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.UsedRegKey)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USED_REG_KEY");

            entity.HasOne(d => d.EduJuniorStaff).WithMany(p => p.SchoolReferrals)
                .HasForeignKey(d => d.EduJuniorStaffId)
                .HasConstraintName("FK_SCHOOL_REFERRAL_EDU_JUNIOR_STAFF");

            entity.HasOne(d => d.School).WithMany(p => p.SchoolReferrals)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_SCHOOL_REFERRAL_SCHOOL");
        });

        modelBuilder.Entity<SchoolReferralAccount>(entity =>
        {
            entity.HasKey(e => e.SchoolReferralAccountId).HasName("PK_REFERRAL_ACCOUNT");

            entity.ToTable("SCHOOL_REFERRAL_ACCOUNT");

            entity.Property(e => e.SchoolReferralAccountId)
                .ValueGeneratedNever()
                .HasColumnName("SCHOOL_REFERRAL_ACCOUNT_ID");
            entity.Property(e => e.AmountToBeCleared)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_TO_BE_CLEARED");
            entity.Property(e => e.DateLastCleared)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_CLEARED");
            entity.Property(e => e.DateOfLastTransaction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_LAST_TRANSACTION");
            entity.Property(e => e.EduJuniorStaffId).HasColumnName("EDU_JUNIOR_STAFF_ID");
            entity.Property(e => e.NoOfReferredStudentsUncleared).HasColumnName("NO_OF_REFERRED_STUDENTS_UNCLEARED");
            entity.Property(e => e.TotalAmountCleared)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TOTAL_AMOUNT_CLEARED");
            entity.Property(e => e.TotalNoOfSchoolsReferred).HasColumnName("TOTAL_NO_OF_SCHOOLS_REFERRED");
            entity.Property(e => e.TotalNoOfStudentsReferred).HasColumnName("TOTAL_NO_OF_STUDENTS_REFERRED");

            entity.HasOne(d => d.EduJuniorStaff).WithMany(p => p.SchoolReferralAccounts)
                .HasForeignKey(d => d.EduJuniorStaffId)
                .HasConstraintName("FK_SCHOOL_REFERRAL_ACCOUNT_EDU_JUNIOR_STAFF");
        });

        modelBuilder.Entity<SchoolReferralAccountHistory>(entity =>
        {
            entity.HasKey(e => e.SchoolReferralAccountHistoryId).HasName("PK_REFERRAL_ACCOUNT_HISTORY");

            entity.ToTable("SCHOOL_REFERRAL_ACCOUNT_HISTORY");

            entity.Property(e => e.SchoolReferralAccountHistoryId)
                .ValueGeneratedNever()
                .HasColumnName("SCHOOL_REFERRAL_ACCOUNT_HISTORY_ID");
            entity.Property(e => e.AmountCleared)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AMOUNT_CLEARED");
            entity.Property(e => e.DateCleared)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_CLEARED");
            entity.Property(e => e.NoOfStudentsCleared).HasColumnName("NO_OF_STUDENTS_CLEARED");
            entity.Property(e => e.SchoolReferralAccountId).HasColumnName("SCHOOL_REFERRAL_ACCOUNT_ID");

            entity.HasOne(d => d.SchoolReferralAccount).WithMany(p => p.SchoolReferralAccountHistories)
                .HasForeignKey(d => d.SchoolReferralAccountId)
                .HasConstraintName("FK_SCHOOL_REFERRAL_ACCOUNT_HISTORY_SCHOOL_REFERRAL_ACCOUNT");
        });

        modelBuilder.Entity<Security>(entity =>
        {
            entity.ToTable("SECURITY");

            entity.Property(e => e.SecurityId)
                .ValueGeneratedNever()
                .HasColumnName("SECURITY_ID");
            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.SecurityIdLocal).HasColumnName("SECURITY_ID_LOCAL");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Time)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TIME");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");
            entity.Property(e => e.UserCategory)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_CATEGORY");
            entity.Property(e => e.UserServerId).HasColumnName("USER_SERVER_ID");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.ToTable("SESSION");

            entity.Property(e => e.SessionId)
                .ValueGeneratedNever()
                .HasColumnName("SESSION_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.SessionIdLocal).HasColumnName("SESSION_ID_LOCAL");
            entity.Property(e => e.SessionName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SESSION_NAME");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_SESSION_SCHOOL");
        });

        modelBuilder.Entity<SmsTracker>(entity =>
        {
            entity.ToTable("SMS_TRACKER");

            entity.Property(e => e.SmsTrackerId)
                .ValueGeneratedNever()
                .HasColumnName("SMS_TRACKER_ID");
            entity.Property(e => e.DateSent)
                .HasColumnType("datetime")
                .HasColumnName("DATE_SENT");
            entity.Property(e => e.PupilId).HasColumnName("PUPIL_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.SmsCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SMS_CATEGORY");
            entity.Property(e => e.SmsContent)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("SMS_CONTENT");
            entity.Property(e => e.SmsTrackerIdLocal).HasColumnName("SMS_TRACKER_ID_LOCAL");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Pupil).WithMany(p => p.SmsTrackers)
                .HasForeignKey(d => d.PupilId)
                .HasConstraintName("FK_SMS_TRACKER_PUPIL");

            entity.HasOne(d => d.School).WithMany(p => p.SmsTrackers)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_SMS_TRACKER_SCHOOL");
        });

        modelBuilder.Entity<StaffSchoolEngagement>(entity =>
        {
            entity.ToTable("STAFF_SCHOOL_ENGAGEMENT");

            entity.Property(e => e.StaffSchoolEngagementId)
                .ValueGeneratedNever()
                .HasColumnName("STAFF_SCHOOL_ENGAGEMENT_ID");
            entity.Property(e => e.DateOfEngagement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_ENGAGEMENT");
            entity.Property(e => e.EduJuniorStaffId).HasColumnName("EDU_JUNIOR_STAFF_ID");
            entity.Property(e => e.LocationId).HasColumnName("LOCATION_ID");
            entity.Property(e => e.LocationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION_NAME");
            entity.Property(e => e.PhoneNoOfSchoolContact)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO_OF_SCHOOL_CONTACT");
            entity.Property(e => e.SchoolEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SCHOOL_EMAIL_ADDRESS");
            entity.Property(e => e.SchoolName)
                .IsUnicode(false)
                .HasColumnName("SCHOOL_NAME");
            entity.Property(e => e.StaffName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STAFF_NAME");

            entity.HasOne(d => d.EduJuniorStaff).WithMany(p => p.StaffSchoolEngagements)
                .HasForeignKey(d => d.EduJuniorStaffId)
                .HasConstraintName("FK_STAFF_SCHOOL_ENGAGEMENT_EDU_JUNIOR_STAFF");

            entity.HasOne(d => d.Location).WithMany(p => p.StaffSchoolEngagements)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK_STAFF_SCHOOL_ENGAGEMENT_LOCATION");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("STATE");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("STATE_ID");
            entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE_NAME");

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_STATE_COUNTRY");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.ToTable("SUBJECT");

            entity.Property(e => e.SubjectId)
                .ValueGeneratedNever()
                .HasColumnName("SUBJECT_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.SubjectIdLocal).HasColumnName("SUBJECT_ID_LOCAL");
            entity.Property(e => e.SubjectName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUBJECT_NAME");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Subjects)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_SUBJECT_SCHOOL");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.ToTable("TEACHER");

            entity.Property(e => e.TeacherId)
                .ValueGeneratedNever()
                .HasColumnName("TEACHER_ID");
            entity.Property(e => e.Certificate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CERTIFICATE");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateOfAppointmentDay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_APPOINTMENT_DAY");
            entity.Property(e => e.DateOfAppointmentMonth)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_APPOINTMENT_MONTH");
            entity.Property(e => e.DateOfAppointmentYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_APPOINTMENT_YEAR");
            entity.Property(e => e.DateOfBirthDay)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_DAY");
            entity.Property(e => e.DateOfBirthMonth)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_MONTH");
            entity.Property(e => e.DateOfBirthYear)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH_YEAR");
            entity.Property(e => e.DateRegistered)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_REGISTERED");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.Enabled)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ENABLED");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.HomeAddress)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("HOME_ADDRESS");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.OtherNames)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHER_NAMES");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NUMBER");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.Sex)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.TeacherIdLocal).HasColumnName("TEACHER_ID_LOCAL");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");
        });

        modelBuilder.Entity<TeacherClass>(entity =>
        {
            entity.ToTable("TEACHER_CLASS");

            entity.Property(e => e.TeacherClassId)
                .ValueGeneratedNever()
                .HasColumnName("TEACHER_CLASS_ID");
            entity.Property(e => e.ClassId).HasColumnName("CLASS_ID");
            entity.Property(e => e.DateAdded)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_ADDED");
            entity.Property(e => e.DateLastUpdated)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.TeacherClassIdLocal).HasColumnName("TEACHER_CLASS_ID_LOCAL");
            entity.Property(e => e.TeacherId).HasColumnName("TEACHER_ID");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.Class).WithMany(p => p.TeacherClasses)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_TEACHER_CLASS_CLASS");

            entity.HasOne(d => d.School).WithMany(p => p.TeacherClasses)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_TEACHER_CLASS_SCHOOL");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherClasses)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_TEACHER_CLASS_TEACHER");
        });

        modelBuilder.Entity<Term>(entity =>
        {
            entity.ToTable("TERM");

            entity.Property(e => e.TermId)
                .ValueGeneratedNever()
                .HasColumnName("TERM_ID");
            entity.Property(e => e.SchoolId).HasColumnName("SCHOOL_ID");
            entity.Property(e => e.TermIdLocal).HasColumnName("TERM_ID_LOCAL");
            entity.Property(e => e.TermName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TERM_NAME");
            entity.Property(e => e.Uploaded)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("UPLOADED");

            entity.HasOne(d => d.School).WithMany(p => p.Terms)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("FK_TERM_SCHOOL");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USER");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("USER_ID");
            entity.Property(e => e.AreaOfInterest)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("AREA_OF_INTEREST");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateLastUpdated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LAST_UPDATED");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.OtherNames)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHER_NAMES");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PHONE_NO");
            entity.Property(e => e.PhoneNoOtp).HasColumnName("PHONE_NO_OTP");
            entity.Property(e => e.PhoneNoOtpExpiration)
                .HasColumnType("datetime")
                .HasColumnName("PHONE_NO_OTP_EXPIRATION");
            entity.Property(e => e.ProfilePicture)
                .IsUnicode(false)
                .HasColumnName("PROFILE_PICTURE");
            entity.Property(e => e.Sex)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEX");
            entity.Property(e => e.SignalrConnId)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SIGNALR_CONN_ID");
            entity.Property(e => e.SiteVisitCount).HasColumnName("SITE_VISIT_COUNT");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Surname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SURNAME");
            entity.Property(e => e.UserCategoryId).HasColumnName("USER_CATEGORY_ID");
            entity.Property(e => e.Verified)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("VERIFIED");

            entity.HasOne(d => d.UserCategory).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserCategoryId)
                .HasConstraintName("FK_USER_USER");
        });

        modelBuilder.Entity<UserCategory>(entity =>
        {
            entity.ToTable("USER_CATEGORY");

            entity.Property(e => e.UserCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("USER_CATEGORY_ID");
            entity.Property(e => e.UserCategoryName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USER_CATEGORY_NAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
