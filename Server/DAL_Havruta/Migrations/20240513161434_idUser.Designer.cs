﻿// <auto-generated />
using System;
using DAL_Havruta.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL_Havruta.Migrations
{
    [DbContext(typeof(HavrutaDbContext))]
    [Migration("20240513161434_idUser")]
    partial class idUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL_Havruta.Model.Comment", b =>
                {
                    b.Property<int>("Idcomment")
                        .HasColumnType("int")
                        .HasColumnName("IDComment");

                    b.Property<string>("Comment1")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("comment");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("date");

                    b.Property<int?>("IdGettingComment")
                        .HasColumnType("int")
                        .HasColumnName("idGettingComment");

                    b.Property<int?>("IdWritesComment")
                        .HasColumnType("int")
                        .HasColumnName("idWritesComment");

                    b.Property<int?>("IdWritesCommentNavigationIduser")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.HasKey("Idcomment");

                    b.HasIndex("IdWritesCommentNavigationIduser");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DAL_Havruta.Model.Manager", b =>
                {
                    b.Property<int>("Idmanager")
                        .HasColumnType("int")
                        .HasColumnName("IDManager");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("fName");

                    b.Property<string>("LName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("lName");

                    b.Property<string>("Password")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("password");

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.HasKey("Idmanager");

                    b.ToTable("Manager", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.Request", b =>
                {
                    b.Property<int>("Idrequest")
                        .HasColumnType("int")
                        .HasColumnName("IDRequest");

                    b.Property<bool?>("AllDay")
                        .HasColumnType("bit")
                        .HasColumnName("allDay");

                    b.Property<string>("DescriptionRequest")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<TimeOnly?>("EndTime")
                        .HasColumnType("time")
                        .HasColumnName("endTime");

                    b.Property<int?>("IdAcceptingRequest")
                        .HasColumnType("int")
                        .HasColumnName("idAcceptingRequest");

                    b.Property<int?>("IdAsking")
                        .HasColumnType("int")
                        .HasColumnName("idAsking");

                    b.Property<int?>("IdAskingNavigationIduser")
                        .HasColumnType("int");

                    b.Property<int?>("IdStudyType")
                        .HasColumnType("int")
                        .HasColumnName("idStudyType");

                    b.Property<int?>("IdSubject")
                        .HasColumnType("int")
                        .HasColumnName("idSubject");

                    b.Property<bool?>("Ok")
                        .HasColumnType("bit")
                        .HasColumnName("ok");

                    b.Property<TimeOnly?>("StartTime")
                        .HasColumnType("time")
                        .HasColumnName("startTime");

                    b.HasKey("Idrequest");

                    b.HasIndex("IdAskingNavigationIduser");

                    b.HasIndex("IdStudyType");

                    b.HasIndex("IdSubject");

                    b.ToTable("Request", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.Study", b =>
                {
                    b.Property<int>("Idstudy")
                        .HasColumnType("int")
                        .HasColumnName("IDStudy");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime")
                        .HasColumnName("endTime");

                    b.Property<int?>("IdRequest")
                        .HasColumnType("int")
                        .HasColumnName("idRequest");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime")
                        .HasColumnName("startTime");

                    b.HasKey("Idstudy");

                    b.HasIndex("IdRequest");

                    b.ToTable("Study", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.StudyCriterion", b =>
                {
                    b.Property<int>("Idcriterion")
                        .HasColumnType("int")
                        .HasColumnName("IDCriterion");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("idUser");

                    b.Property<int?>("IdUserNavigationIduser")
                        .HasColumnType("int");

                    b.Property<int?>("MaxAge")
                        .HasColumnType("int")
                        .HasColumnName("maxAge");

                    b.Property<int?>("MinAge")
                        .HasColumnType("int")
                        .HasColumnName("minAge");

                    b.Property<string>("Sector")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sector");

                    b.HasKey("Idcriterion");

                    b.HasIndex("IdUserNavigationIduser");

                    b.ToTable("StudyCriteria");
                });

            modelBuilder.Entity("DAL_Havruta.Model.StudyTime", b =>
                {
                    b.Property<int>("Idtime")
                        .HasColumnType("int")
                        .HasColumnName("IDTime");

                    b.Property<bool?>("AllDay")
                        .HasColumnType("bit")
                        .HasColumnName("allDay");

                    b.Property<DateOnly?>("Day")
                        .HasColumnType("date")
                        .HasColumnName("day");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime")
                        .HasColumnName("endTime");

                    b.Property<string>("IdUser")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("idUser")
                        .IsFixedLength();

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime")
                        .HasColumnName("startTime");

                    b.HasKey("Idtime");

                    b.ToTable("StudyTime", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.StudyType", b =>
                {
                    b.Property<int>("Idstudy")
                        .HasColumnType("int")
                        .HasColumnName("IDStudy");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("description");

                    b.HasKey("Idstudy");

                    b.ToTable("StudyType", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.Subject", b =>
                {
                    b.Property<int>("Idsubject")
                        .HasColumnType("int")
                        .HasColumnName("IDSubject");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("description");

                    b.Property<string>("Subject1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("subject");

                    b.HasKey("Idsubject");

                    b.ToTable("Subject-", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.User", b =>
                {
                    b.Property<int>("Iduser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IDUser");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Iduser"));

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("address");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("DecriptionMyStudy")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("decriptionMyStudy");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("fName");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("gender");

                    b.Property<string>("LName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("lName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<int?>("Phone")
                        .HasColumnType("int")
                        .HasColumnName("phone");

                    b.Property<string>("Sector")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("sector");

                    b.HasKey("Iduser");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.UserStudyType", b =>
                {
                    b.Property<int>("IduserStudyType")
                        .HasColumnType("int")
                        .HasColumnName("IDUserStudyType");

                    b.Property<int?>("IdStudyType")
                        .HasColumnType("int")
                        .HasColumnName("idStudyType");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("idUser");

                    b.Property<int?>("IdUserNavigationIduser")
                        .HasColumnType("int");

                    b.HasKey("IduserStudyType");

                    b.HasIndex("IdStudyType");

                    b.HasIndex("IdUserNavigationIduser");

                    b.ToTable("UserStudyType", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.UserSubject", b =>
                {
                    b.Property<int>("IduserSubject")
                        .HasColumnType("int")
                        .HasColumnName("IDUserSubject");

                    b.Property<int?>("IdSubject")
                        .HasColumnType("int")
                        .HasColumnName("idSubject");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("idUser");

                    b.Property<int?>("IdUserNavigationIduser")
                        .HasColumnType("int");

                    b.HasKey("IduserSubject");

                    b.HasIndex("IdSubject");

                    b.HasIndex("IdUserNavigationIduser");

                    b.ToTable("UserSubject", (string)null);
                });

            modelBuilder.Entity("DAL_Havruta.Model.Comment", b =>
                {
                    b.HasOne("DAL_Havruta.Model.User", "IdWritesCommentNavigation")
                        .WithMany()
                        .HasForeignKey("IdWritesCommentNavigationIduser");

                    b.Navigation("IdWritesCommentNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.Request", b =>
                {
                    b.HasOne("DAL_Havruta.Model.User", "IdAskingNavigation")
                        .WithMany()
                        .HasForeignKey("IdAskingNavigationIduser");

                    b.HasOne("DAL_Havruta.Model.StudyType", "IdStudyTypeNavigation")
                        .WithMany("Requests")
                        .HasForeignKey("IdStudyType")
                        .HasConstraintName("FK_Request_StudyType");

                    b.HasOne("DAL_Havruta.Model.Subject", "IdSubjectNavigation")
                        .WithMany("Requests")
                        .HasForeignKey("IdSubject")
                        .HasConstraintName("FK_Request_Subject-");

                    b.Navigation("IdAskingNavigation");

                    b.Navigation("IdStudyTypeNavigation");

                    b.Navigation("IdSubjectNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.Study", b =>
                {
                    b.HasOne("DAL_Havruta.Model.Request", "IdRequestNavigation")
                        .WithMany("Studies")
                        .HasForeignKey("IdRequest")
                        .HasConstraintName("FK_Study_Request");

                    b.Navigation("IdRequestNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.StudyCriterion", b =>
                {
                    b.HasOne("DAL_Havruta.Model.User", "IdUserNavigation")
                        .WithMany()
                        .HasForeignKey("IdUserNavigationIduser");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.UserStudyType", b =>
                {
                    b.HasOne("DAL_Havruta.Model.StudyType", "IdStudyTypeNavigation")
                        .WithMany("UserStudyTypes")
                        .HasForeignKey("IdStudyType")
                        .HasConstraintName("FK_UserStudyType_StudyType");

                    b.HasOne("DAL_Havruta.Model.User", "IdUserNavigation")
                        .WithMany()
                        .HasForeignKey("IdUserNavigationIduser");

                    b.Navigation("IdStudyTypeNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.UserSubject", b =>
                {
                    b.HasOne("DAL_Havruta.Model.Subject", "IdSubjectNavigation")
                        .WithMany("UserSubjects")
                        .HasForeignKey("IdSubject")
                        .HasConstraintName("FK_UserSubject_Subject-");

                    b.HasOne("DAL_Havruta.Model.User", "IdUserNavigation")
                        .WithMany()
                        .HasForeignKey("IdUserNavigationIduser");

                    b.Navigation("IdSubjectNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("DAL_Havruta.Model.Request", b =>
                {
                    b.Navigation("Studies");
                });

            modelBuilder.Entity("DAL_Havruta.Model.StudyType", b =>
                {
                    b.Navigation("Requests");

                    b.Navigation("UserStudyTypes");
                });

            modelBuilder.Entity("DAL_Havruta.Model.Subject", b =>
                {
                    b.Navigation("Requests");

                    b.Navigation("UserSubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
