using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class StudyTime
{
    public int Idtime { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateOnly? Day { get; set; }

    public bool? AllDay { get; set; }

    public string? IdUser { get; set; }
}
