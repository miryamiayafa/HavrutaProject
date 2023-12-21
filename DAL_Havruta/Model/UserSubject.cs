using System;
using System.Collections.Generic;

namespace DAL_Havruta.Model;

public partial class UserSubject
{
    public int IduserSubject { get; set; }

    public int? IdUser { get; set; }

    public int? IdSubject { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
