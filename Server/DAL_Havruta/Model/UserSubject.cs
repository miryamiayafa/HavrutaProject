using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Model;

public partial class UserSubject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IduserSubject { get; set; }

    public int? IdUser { get; set; }

    public int? IdSubject { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
