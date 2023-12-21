using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class Study
{
    public int Idstudy { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? IdRequest { get; set; }

    public virtual Request? IdRequestNavigation { get; set; }
}
