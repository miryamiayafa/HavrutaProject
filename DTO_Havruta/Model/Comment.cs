using System;
using System.Collections.Generic;

namespace DTO_Havruta.Model;

public partial class Comment
{
    public int Idcomment { get; set; }

    public int? IdWritesComment { get; set; }

    public int? IdGettingComment { get; set; }

    public int? Rating { get; set; }

    public string? Comment1 { get; set; }

    public DateTime? Date { get; set; }

    public virtual User? IdWritesCommentNavigation { get; set; }
}
