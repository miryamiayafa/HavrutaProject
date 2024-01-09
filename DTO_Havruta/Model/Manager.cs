using System;
using System.Collections.Generic;

namespace DTO_Havruta.Model;

public partial class Manager
{
    public int Idmanager { get; set; }

    public string? FName { get; set; }

    public string? LName { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? Phone { get; set; }
}
