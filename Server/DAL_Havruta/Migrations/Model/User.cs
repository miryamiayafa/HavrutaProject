using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Migrations.Model;

public partial class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Iduser { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? Address { get; set; }

    public int? Phone { get; set; }

    public string? Sector { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? DecriptionMyStudy { get; set; }
    public string Password { get; set; } = "";

    //public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    //public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    //public virtual ICollection<StudyCriterion> StudyCriteria { get; set; } = new List<StudyCriterion>();

    //public virtual ICollection<UserStudyType> UserStudyTypes { get; set; } = new List<UserStudyType>();

    //public virtual ICollection<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
}
