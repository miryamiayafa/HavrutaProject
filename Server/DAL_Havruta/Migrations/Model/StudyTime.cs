using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Migrations.Model;

public partial class StudyTime
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Idtime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateOnly? Day { get; set; }

    public bool? AllDay { get; set; }

    public string? IdUser { get; set; }
}
