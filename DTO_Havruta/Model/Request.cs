using System;
using System.Collections.Generic;

namespace DTO_Havruta.Model;

public partial class Request
{
    public int Idrequest { get; set; }

    public int? IdAsking { get; set; }

    public int? IdAcceptingRequest { get; set; }

    public int? IdSubject { get; set; }

    public int? IdStudyType { get; set; }

    public string? DescriptionRequest { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public bool? AllDay { get; set; }

    public bool? Ok { get; set; }

    public virtual User? IdAskingNavigation { get; set; }

    public virtual StudyType? IdStudyTypeNavigation { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }

    
}
