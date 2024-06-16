using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Migrations.Model;

public partial class UserSubject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IDUserSubject { get; set; }

    public int? IdUser { get; set; }

    public int? IdSubject { get; set; }

}
