using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class Subject
{
    public int Idsubject { get; set; }

    public string? Subject1 { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<UserSubject> UserSubjects { get; set; } = new List<UserSubject>();
}
