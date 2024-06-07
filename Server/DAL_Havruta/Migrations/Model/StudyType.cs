using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Migrations.Model;

public partial class StudyType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Idstudy { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<UserStudyType> UserStudyTypes { get; set; } = new List<UserStudyType>();
}
