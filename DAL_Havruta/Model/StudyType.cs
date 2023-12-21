using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class StudyType
{
    public int Idstudy { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<UserStudyType> UserStudyTypes { get; set; } = new List<UserStudyType>();
}
