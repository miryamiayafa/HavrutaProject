using System;
using System.Collections.Generic;

namespace DTO_Havruta.Model;

public partial class UserStudyType
{
    public int IduserStudyType { get; set; }

    public int? IdUser { get; set; }

    public int? IdStudyType { get; set; }

    public virtual StudyType? IdStudyTypeNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
