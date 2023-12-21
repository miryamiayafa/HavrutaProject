using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class StudyCriterion
{
    public int Idcriterion { get; set; }

    public string? Sector { get; set; }

    public int? MinAge { get; set; }

    public int? MaxAge { get; set; }

    public int? IdUser { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
