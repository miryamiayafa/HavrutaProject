using System;
using System.Collections.Generic;
using DAL_Havruta.Model;
using Microsoft.EntityFrameworkCore;

namespace DAL_Havruta.DB;

public partial class HavrutaDbContext : DbContext
{
    public HavrutaDbContext()
    {
    }

    public HavrutaDbContext(DbContextOptions<HavrutaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Study> Studies { get; set; }

    public virtual DbSet<StudyCriterion> StudyCriteria { get; set; }

    public virtual DbSet<StudyTime> StudyTimes { get; set; }

    public virtual DbSet<StudyType> StudyTypes { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserStudyType> UserStudyTypes { get; set; }

    public virtual DbSet<UserSubject> UserSubjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\;Database=HavrutaDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Idcomment);

            entity.Property(e => e.Idcomment)
                .ValueGeneratedNever()
                .HasColumnName("IDComment");
            entity.Property(e => e.Comment1)
                .HasMaxLength(300)
                .HasColumnName("comment");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.IdGettingComment).HasColumnName("idGettingComment");
            entity.Property(e => e.IdWritesComment).HasColumnName("idWritesComment");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.IdWritesCommentNavigation).WithMany(p => p.Comments)
                .HasForeignKey(d => d.IdWritesComment)
                .HasConstraintName("FK_Comments_User");
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.HasKey(e => e.Idmanager);

            entity.ToTable("Manager");

            entity.Property(e => e.Idmanager)
                .ValueGeneratedNever()
                .HasColumnName("IDManager");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FName)
                .HasMaxLength(25)
                .HasColumnName("fName");
            entity.Property(e => e.LName)
                .HasMaxLength(25)
                .HasColumnName("lName");
            entity.Property(e => e.Password)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Idrequest);

            entity.ToTable("Request");

            entity.Property(e => e.Idrequest)
                .ValueGeneratedNever()
                .HasColumnName("IDRequest");
            entity.Property(e => e.AllDay).HasColumnName("allDay");
            entity.Property(e => e.DescriptionRequest).HasMaxLength(300);
            entity.Property(e => e.EndTime).HasColumnName("endTime");
            entity.Property(e => e.IdAcceptingRequest).HasColumnName("idAcceptingRequest");
            entity.Property(e => e.IdAsking).HasColumnName("idAsking");
            entity.Property(e => e.IdStudyType).HasColumnName("idStudyType");
            entity.Property(e => e.IdSubject).HasColumnName("idSubject");
            entity.Property(e => e.Ok).HasColumnName("ok");
            entity.Property(e => e.StartTime).HasColumnName("startTime");

            entity.HasOne(d => d.IdAskingNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.IdAsking)
                .HasConstraintName("FK_Request_User");

            entity.HasOne(d => d.IdStudyTypeNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.IdStudyType)
                .HasConstraintName("FK_Request_StudyType");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.IdSubject)
                .HasConstraintName("FK_Request_Subject-");
        });

        modelBuilder.Entity<Study>(entity =>
        {
            entity.HasKey(e => e.Idstudy);

            entity.ToTable("Study");

            entity.Property(e => e.Idstudy)
                .ValueGeneratedNever()
                .HasColumnName("IDStudy");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("endTime");
            entity.Property(e => e.IdRequest).HasColumnName("idRequest");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("startTime");

            entity.HasOne(d => d.IdRequestNavigation).WithMany(p => p.Studies)
                .HasForeignKey(d => d.IdRequest)
                .HasConstraintName("FK_Study_Request");
        });

        modelBuilder.Entity<StudyCriterion>(entity =>
        {
            entity.HasKey(e => e.Idcriterion);

            entity.Property(e => e.Idcriterion)
                .ValueGeneratedNever()
                .HasColumnName("IDCriterion");
            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.MaxAge).HasColumnName("maxAge");
            entity.Property(e => e.MinAge).HasColumnName("minAge");
            entity.Property(e => e.Sector)
                .HasMaxLength(10)
                .HasColumnName("sector");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.StudyCriteria)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_StudyCriteria_User");
        });

        modelBuilder.Entity<StudyTime>(entity =>
        {
            entity.HasKey(e => e.Idtime);

            entity.ToTable("StudyTime");

            entity.Property(e => e.Idtime)
                .ValueGeneratedNever()
                .HasColumnName("IDTime");
            entity.Property(e => e.AllDay).HasColumnName("allDay");
            entity.Property(e => e.Day).HasColumnName("day");
            entity.Property(e => e.EndTime)
                .HasColumnType("datetime")
                .HasColumnName("endTime");
            entity.Property(e => e.IdUser)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("idUser");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("startTime");
        });

        modelBuilder.Entity<StudyType>(entity =>
        {
            entity.HasKey(e => e.Idstudy);

            entity.ToTable("StudyType");

            entity.Property(e => e.Idstudy)
                .ValueGeneratedNever()
                .HasColumnName("IDStudy");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("description");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Idsubject);

            entity.ToTable("Subject-");

            entity.Property(e => e.Idsubject)
                .ValueGeneratedNever()
                .HasColumnName("IDSubject");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .HasColumnName("description");
            entity.Property(e => e.Subject1)
                .HasMaxLength(50)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Iduser);

            entity.ToTable("User");

            entity.Property(e => e.Iduser)
                .ValueGeneratedNever()
                .HasColumnName("IDUser");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.DecriptionMyStudy)
                .HasMaxLength(300)
                .HasColumnName("decriptionMyStudy");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FName)
                .HasMaxLength(25)
                .HasColumnName("fName");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .HasColumnName("gender");
            entity.Property(e => e.LName)
                .HasMaxLength(25)
                .HasColumnName("lName");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Sector)
                .HasMaxLength(10)
                .HasColumnName("sector");
        });

        modelBuilder.Entity<UserStudyType>(entity =>
        {
            entity.HasKey(e => e.IduserStudyType);

            entity.ToTable("UserStudyType");

            entity.Property(e => e.IduserStudyType)
                .ValueGeneratedNever()
                .HasColumnName("IDUserStudyType");
            entity.Property(e => e.IdStudyType).HasColumnName("idStudyType");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdStudyTypeNavigation).WithMany(p => p.UserStudyTypes)
                .HasForeignKey(d => d.IdStudyType)
                .HasConstraintName("FK_UserStudyType_StudyType");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserStudyTypes)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_UserStudyType_User");
        });

        modelBuilder.Entity<UserSubject>(entity =>
        {
            entity.HasKey(e => e.IduserSubject);

            entity.ToTable("UserSubject");

            entity.Property(e => e.IduserSubject)
                .ValueGeneratedNever()
                .HasColumnName("IDUserSubject");
            entity.Property(e => e.IdSubject).HasColumnName("idSubject");
            entity.Property(e => e.IdUser).HasColumnName("idUser");

            entity.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.UserSubjects)
                .HasForeignKey(d => d.IdSubject)
                .HasConstraintName("FK_UserSubject_Subject-");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserSubjects)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_UserSubject_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
