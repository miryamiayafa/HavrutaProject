using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO_Havruta.Model;

public partial class User
{
 
    public int Iduser { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? Address { get; set; }

    public int? Phone { get; set; }

    public string? Sector { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? DecriptionMyStudy { get; set; }
    public string Password { get; set; } = "";

}
