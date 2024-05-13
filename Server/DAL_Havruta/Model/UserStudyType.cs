using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Model;

public partial class UserStudyType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IduserStudyType { get; set; }

    public int? IdUser { get; set; }

    public int? IdStudyType { get; set; }

    public virtual StudyType? IdStudyTypeNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
