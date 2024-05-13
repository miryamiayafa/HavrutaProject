using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DAL_Havruta.Model;

public partial class Manager
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Idmanager { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }
}
